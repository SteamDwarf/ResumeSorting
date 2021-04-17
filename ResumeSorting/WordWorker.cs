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
        private Dictionary<string, string>[] peopleInfoDict = new Dictionary<string, string>[3];

        public WordWorker(string[] filesName)
        {
            files = filesName;
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

        public List<string> FilteringResume(Dictionary<string, string[]> requestsKeys)
        {
            Dictionary<string, string[]> filteredKeys = FilteringKeys(requestsKeys);
            List<string> filteredResumes = new List<string>();

            for (int i = 0; i < peopleInfoDict.Length; i++)
            {
                bool correctAll = false;
                Dictionary<string, string> person = peopleInfoDict[i];

                foreach (var key in filteredKeys)
                {
                    bool correctField = false;
                    string fieldKey = key.Key;
                    string[] fieldValue = key.Value;

                    for (int j = 0; j < fieldValue.Length; j++)
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
                    filteredResumes.Add(files[i]);
            }

            return filteredResumes;
        }

        private Dictionary<string, string[]> FilteringKeys(Dictionary<string, string[]> requestsKeys)
        {
            Dictionary<string, string[]> filteredKeys = new Dictionary<string, string[]>();

            foreach (var key in requestsKeys)
            {
                if (key.Value[0] == "" || key.Value[0] == " ")
                    continue;
                filteredKeys.Add(key.Key, key.Value);

            }

            return filteredKeys;
        }
    }
}
