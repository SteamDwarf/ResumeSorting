using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml;

namespace ResumeSorting
{
    public partial class Form1 : Form
    {
        
        WordWorker fileReader;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dictionary<string, string[]> requestsKeys = new Dictionary<string, string[]>(6);
            try
            {
                requestsKeys.Add(labelFirstName.Text, textBoxFirstName.Text.Split(','));
                requestsKeys.Add(labelSecondName.Text, textBoxSecondName.Text.Split(','));
                requestsKeys.Add(labelThirdName.Text, textBoxThirdName.Text.Split(','));
                requestsKeys.Add(labelBirth.Text, textBoxBirth.Text.Split(','));
                requestsKeys.Add(labelEducation.Text, textBoxEducation.Text.Split(','));
                requestsKeys.Add(labelWorkExperience.Text, textBoxWorkExperience.Text.Split(','));
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
            List<string> filteredResumes = fileReader.FilteringResume(requestsKeys);
            ShowFilteredResumes(filteredResumes);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string path = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
            //string[] pathsWord = new string[3] { path + @"\WordResume\Резюме_1.docx", path + @"\WordResume\Резюме_2.docx", path + @"\WordResume\Резюме_3.docx"};
            string[] filesPath = Directory.GetFiles(path + @"\WordResume\");

            fileReader = new WordWorker(filesPath);

            try
            {
                //Paragraph paras = fileReader.ReadFile();
                //IEnumerable<Para> = fileReader.ReadFile();
                Dictionary<string, string>[] peoplesInfoDicts = fileReader.GetPeopleInfo();
                for (int i = 0; i < peoplesInfoDicts.Length; i++)
                {
                    label1.Text += "Человек " + (i + 1) + "\n";
                    foreach (var key in peoplesInfoDicts[i])
                    {
                        label1.Text += key.Key + " - " + key.Value + "\n";
                    }
                    label1.Text += "================================ \n";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void ShowFilteredResumes(List<string> resumesPath)
        {
            label2.Text = "";
;           for (int i = 0; i < resumesPath.Count; i++)
            {
                label2.Text += resumesPath[i] + "\n";
            }
        }
    }
}
