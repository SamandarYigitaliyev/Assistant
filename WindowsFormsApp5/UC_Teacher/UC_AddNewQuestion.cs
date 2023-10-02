using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using WindowsFormsApp5.DataPath;
using WindowsFormsApp5.Forms;
using WindowsFormsApp5.Questions;

namespace WindowsFormsApp5.UC_Teacher
{
    public partial class UC_AddNewQuestion : UserControl
    {

        public UC_AddNewQuestion()
        {
            InitializeComponent();
        }

        private void UC_AddNewQuestion_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        public int GetV(string text)
        {
            return int.Parse(text);
        }
        public int no;

        private void txtOption1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void txtOption3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnNext_Click_2(object sender, EventArgs e)
        {
            try
            {
                if (txtQuizname.Text != "")
                {
                    if (txtOption1.Text != "" && txtOption2.Text != "" && txtOption3.Text != "" && txtOption4.Text != "" && txtQuestion.Text != "" && comboVariant.Text != "")
                    {

                        no = GetV(lAddNumber.Text);

                        SaveData saveData = new SaveData()
                        {

                            QuizName = txtQuizname.Text,
                            Question = txtQuestion.Text,
                            Answer = comboVariant.Text,
                            Option1 = txtOption1.Text,
                            Option2 = txtOption2.Text,
                            Option3 = txtOption3.Text,
                            Option4 = txtOption4.Text,
                            Order = no
                        };


                        string basePath = Paths.QuizFilePath;
                        string na = txtQuizname.Text + ".json";


                        string path = Path.Combine(basePath, na);

                        if (!File.Exists(path))
                        {
                            File.WriteAllText(path, "[]");
                        }
                        string jsonContent = File.ReadAllText(path);
                        var tests = JsonConvert.DeserializeObject<List<SaveData>>(jsonContent);
                        tests.Add(saveData);

                        jsonContent = JsonConvert.SerializeObject(tests, Formatting.Indented);
                        File.WriteAllText(path, jsonContent);



                        MessageBox.Show("Test yaratildi keyingi testni yarating");

                        lAddNumber.Text = (GetV(lAddNumber.Text) + 1).ToString();

                        txtQuestion.Clear();
                        comboVariant.Text = "";
                        txtOption1.Clear();
                        txtOption2.Clear();
                        txtOption3.Clear();
                        txtOption4.Clear();



                    }
                    else
                    {
                        MessageBox.Show("Maydonlarni to'ldiring!!");
                    }
                }
                else
                {
                    MessageBox.Show("File ga nom bering");
                }
            }
            catch { }
        }

        private void btnReset_Click_1(object sender, EventArgs e)
        {
            txtQuestion.Clear();
            comboVariant.Text = "";
            txtOption1.Clear();
            txtOption2.Clear();
            txtOption3.Clear();
            txtOption4.Clear();
        }

        private void btnFinish_Click_1(object sender, EventArgs e)
        {

        }

        private void btnFinish_MouseDown_1(object sender, MouseEventArgs e)
        {

            DialogResult result = MessageBox.Show("Yana quiz file yaratishni hohlaysizmi?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (DialogResult.Yes == result)
            {
                txtQuizname.Clear();
                comboVariant.Text = "";
                txtOption1.Clear();
                txtOption2.Clear();
                txtOption3.Clear();
                txtOption4.Clear();
                lAddNumber.Text = "1";



            }
            else if (DialogResult.No == result)
            {
                txtQuizname.Clear();
                comboVariant.Text = "";
                txtOption1.Clear();
                txtOption2.Clear();
                txtOption3.Clear();
                txtOption4.Clear();
                lAddNumber.Text = "1";
                MessageBox.Show("Tabriklayman  Testlar yaratildi", "Result", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            }
        }

        
    }
}

