using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;

namespace ResumeSorting
{
    class WordWorker
    {
        //WordprocessingDocument WD;
        private string[] files;
        private Dictionary<string, string>[] peopleInfoDict;

        public WordWorker(string[] filesName)
        {
            files = filesName;
            peopleInfoDict = new Dictionary<string, string>[files.Length];
        }

        private void TakeFilesFields()
        {
            for (int i = 0; i < files.Length; i++)
            {
                using (WordprocessingDocument wdDoc = WordprocessingDocument.Open(files[i], true))
                {
                    Body body = wdDoc.MainDocumentPart.Document.Body;
                    OpenXmlElement[] paragraphsArray = body.Elements<Paragraph>().ToArray();
                    //OpenXmlElement[] paragraphsArray = paragraphs.ToArray();
                    //string[] paragraphsText = new string[paragraphsArray.Length];
                    Dictionary<string, string> dictFields = new Dictionary<string, string>();

                    for (int j = 0; j < paragraphsArray.Length; j++)
                    {
                        string field = paragraphsArray[j].InnerText;
                        string[] arrayField = field.Split(':');
                        dictFields.Add(arrayField[0], arrayField[1]);
                    }

                    peopleInfoDict[i] = dictFields;
                }
            }
            
        }

        public Dictionary<string, string>[] GetPeopleInfo()
        {
            TakeFilesFields();
            return peopleInfoDict;
        }

        public List<dynamic[]> FilteringResume(Dictionary<string, List<string>> requestsKeys)
        {
            Dictionary<string, List<string>> filteredKeys = FilteringKeys(requestsKeys);
            List<dynamic[]> filteredResumes = new List<dynamic[]>();

            for (int i = 0; i < peopleInfoDict.Length; i++)
            {
                bool correctAll = false;
                Dictionary<string, string> person = peopleInfoDict[i];

                foreach (var key in filteredKeys)
                {
                    bool correctField = false;
                    string fieldKey = key.Key;
                    List<string> fieldValue = key.Value;

                    for (int j = 0; j < fieldValue.Count; j++)
                    {
                        string value = fieldValue[j].ToLower();
                        if (!person[fieldKey].ToLower().Contains(value))
                            correctField = false;
                        else
                        {
                            correctField = true;
                            break;
                        }
                            
                    }
                    if (correctField)
                        correctAll = true;
                    else
                    {
                        correctAll = false;
                        break;
                    }
                }
                if (correctAll)
                {
                    dynamic[] resume = {files[i], i};
                    filteredResumes.Add(resume);
                }
            }

            return filteredResumes;
        }

        private Dictionary<string, List<string>> FilteringKeys(Dictionary<string, List<string>> requestsKeys)
        {
            Dictionary<string, List<string>> filteredKeys = new Dictionary<string, List<string>>();

            foreach (var key in requestsKeys)
            {
                int valueLength = key.Value.Count;

                if (key.Value[0] == "" || key.Value[0] == " ")
                    continue;

                for (int i = 0; i < valueLength; i++)
                {
                    switch(key.Value[i].ToLower().Trim())
                    {
                        case "отсутствует":
                            key.Value.Add("нет");
                            break;
                        case "нет":
                            key.Value.Add("отсутствует");
                            break; 
                        case "высшее":
                            key.Value.Add("высших");
                            break;
                        case "высших":
                            key.Value.Add("высшее");
                            break;
                        case "есть":
                            key.Value.Add("1");
                            key.Value.Add("2");
                            key.Value.Add("3");
                            key.Value.Add("4");
                            key.Value.Add("5");
                            key.Value.Add("6");
                            key.Value.Add("7");
                            key.Value.Add("8");
                            key.Value.Add("9");
                            key.Value.Add("10");
                            break;
                    }
                }
                filteredKeys.Add(key.Key, key.Value);

            }

            return filteredKeys;
        }
    }
}
