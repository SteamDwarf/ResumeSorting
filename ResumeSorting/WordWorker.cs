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
    }
}
