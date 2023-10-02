using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using WindowsFormsApp5.DataPath;
using WindowsFormsApp5.Questions;


namespace WindowsFormsApp5.UC_Teacher
{
    public partial class UControlUbdateQuestion : UserControl
    {
        public UControlUbdateQuestion()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UControlUbdateQuestion_Load(object sender, EventArgs e)
        {

        }

        public string FileFullPath;
        int j = 0;

        private void btnUbadate_Click_1(object sender, EventArgs e)
        {
            try
            {
                string jsonContent = File.ReadAllText(FileFullPath);
                var dates = JsonConvert.DeserializeObject<List<SaveData>>(jsonContent);
                foreach (var data in dates)
                {
                    if (data.Order == GetQuestionNo)
                    {
                        data.Question = txtQuestion.Text;
                        data.Answer = comboVariant.Text;
                        data.Option1 = txtOption1.Text;
                        data.Option2 = txtOption2.Text;
                        data.Option3 = txtOption3.Text;
                        data.Option4 = txtOption4.Text;

                    }
                }
                jsonContent = JsonConvert.SerializeObject(dates, Formatting.Indented);
                File.WriteAllText(FileFullPath, jsonContent);
            }
            catch { }
        }

        public int i = 0;
        public string GetFileName;
        public int GetQuestionNo;


        private void comboSelectQuestionNo_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            try
            {
                j = 1;
                GetQuestionNo = int.Parse(comboSelectQuestionNo.Text);
                if (i + j == 2)
                {


                    string jsonContent = File.ReadAllText(FileFullPath);
                    var dates = JsonConvert.DeserializeObject<List<SaveData>>(jsonContent);
                    foreach (var data in dates)
                    {
                        if (data.Order == GetQuestionNo)
                        {
                            txtOption1.Text = data.Option1;
                            txtOption2.Text = data.Option2;
                            comboVariant.Text = data.Answer;
                            txtOption3.Text = data.Option3;
                            txtOption4.Text = data.Option4;
                            txtQuestion.Text = data.Question;
                        }
                    }
                }

            }

            catch { }
        }

        private void comboSelectFile_SelectedIndexChanged_2(object sender, EventArgs e)
        {
            i = 1;
            GetFileName = comboSelectFile.Text;
        }

        private void comboSelectFile_MouseLeave_1(object sender, EventArgs e)
        {
            comboSelectFile.Items.Clear();
        }

        private void comboSelectQuestionNo_MouseLeave_1(object sender, EventArgs e)
        {
            comboSelectQuestionNo.Items.Clear();
        }

        private void comboSelectQuestionNo_MouseEnter_1(object sender, EventArgs e)
        {
            try
            {


                string[] files = Directory.GetFiles(Paths.QuizFilePath);
                foreach (var file in files)
                {

                    FileInfo fileInfo = new FileInfo(file);

                    string name = fileInfo.Name;


                    if (GetFileName == name.Remove(name.Length - 5))
                    {
                        FileFullPath = fileInfo.FullName;
                        string jsonContent = File.ReadAllText(file);
                        var dates = JsonConvert.DeserializeObject<List<SaveData>>(jsonContent);
                        foreach (var data in dates)
                        {


                            comboSelectQuestionNo.Items.Add(data.Order);
                        }
                    }


                }
            }
            catch { }
        }

        private void comboSelectFile_MouseEnter_1(object sender, EventArgs e)
        {
            string[] files = Directory.GetFiles(Paths.QuizFilePath);

            foreach (var file in files)
            {
                FileInfo fileInfo1 = new FileInfo(file);
                string name = fileInfo1.Name;
                name = name.Remove(name.Length - 5);
                comboSelectFile.Items.Add(name);

            }
        }
    }
}
