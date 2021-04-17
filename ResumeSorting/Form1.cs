using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Diagnostics;
using System.Windows.Forms;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml;

namespace ResumeSorting
{
    public partial class Form1 : Form
    {

        WordWorker fileReader;
        Dictionary<string, string>[] peoplesInfoDicts;
        string path = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
        string filtResumes;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dictionary<string, List<string>> requestsKeys = new Dictionary<string, List<string>>();
            try
            {
                requestsKeys.Add(labelFirstName.Text, textBoxFirstName.Text.Split(',').ToList());
                requestsKeys.Add(labelSecondName.Text, textBoxSecondName.Text.Split(',').ToList());
                requestsKeys.Add(labelThirdName.Text, textBoxThirdName.Text.Split(',').ToList());
                requestsKeys.Add(labelBirth.Text, textBoxBirth.Text.Split(',').ToList());
                requestsKeys.Add(labelEducation.Text, textBoxEducation.Text.Split(',').ToList());
                requestsKeys.Add(labelWorkExperience.Text, textBoxWorkExperience.Text.Split(',').ToList());
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            List<dynamic[]> filteredResumes = fileReader.FilteringResume(requestsKeys);
            ShowFilteredResumes(filteredResumes);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //string[] pathsWord = new string[3] { path + @"\WordResume\Резюме_1.docx", path + @"\WordResume\Резюме_2.docx", path + @"\WordResume\Резюме_3.docx"};
            string[] filesPath = Directory.GetFiles(path + @"\WordResume\");

            fileReader = new WordWorker(filesPath);

            try
            {
                peoplesInfoDicts = fileReader.GetPeopleInfo();
                /*for (int i = 0; i < peoplesInfoDicts.Length; i++)
                {
                    if(i <= peoplesInfoDicts.Length / 2)
                    {
                        foreach (var key in peoplesInfoDicts[i])
                        {
                            label1.Text += key.Key + " - " + key.Value + "\n";
                        }
                        label1.Text += "================================ \n";
                    }
                    else
                    {
                        foreach (var key in peoplesInfoDicts[i])
                        {
                            label3.Text += key.Key + " - " + key.Value + "\n";
                        }
                        label3.Text += "================================ \n";
                    }
                }*/
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void ShowFilteredResumes(List<dynamic[]> resumesPath)
        {
            richTextBox1.Text = "";
            richTextBox2.Text = "";
            Directory.Delete(path + @"\FilteredResumes\", true);
            Directory.CreateDirectory(path + @"\FilteredResumes");
            filtResumes = path + @"\FilteredResumes\";

            for (int i = 0; i < resumesPath.Count; i++)
            {
                FileInfo resume = new FileInfo(resumesPath[i][0]);
                string filename = resume.Name;
                resume.CopyTo(filtResumes + filename);

                if (i < 4)
                {
                    richTextBox2.Text += filename + "\n";
                    foreach (var key in peoplesInfoDicts[resumesPath[i][1]])
                    {
                        richTextBox2.Text += key.Key + " - " + key.Value + "\n";
                    }
                    richTextBox2.Text += "================================ \n";
                }
                else
                {
                    richTextBox1.Text += filename + "\n";
                    foreach (var key in peoplesInfoDicts[resumesPath[i][1]])
                    {
                        richTextBox1.Text += key.Key + " - " + key.Value + "\n";
                    }
                    richTextBox1.Text += "================================ \n";
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (filtResumes == null)
                MessageBox.Show("Сперва выполните поиск");
            else
                Process.Start("explorer", filtResumes);
        }
    }
}
