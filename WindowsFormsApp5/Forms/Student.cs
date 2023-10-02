using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using WindowsFormsApp5.DataPath;
using WindowsFormsApp5.Questions;
using WindowsFormsApp5.Register;

namespace WindowsFormsApp5.Forms
{
    public partial class Student : Form
    {
        public Student()
        {
            InitializeComponent();
        }

        public string ComboTxt;
        public string p;
        private void comboQuizFilesName_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
               
                ComboTxt = comboQuizFilesName.Text;
                string[] str = Directory.GetFiles(Paths.QuizFilePath);
                foreach (string str2 in str)
                {
                    FileInfo file = new FileInfo(str2);

                    string name = file.Name.Remove(file.Name.Length - 5);
                    if (name == ComboTxt)
                    {
                        p = file.FullName;
                        btnBack.Enabled = true;
                        btnBoshlash.Enabled= true;
                        btnFinish.Enabled= true;
                        btnNext.Enabled= true;
                        
                    }
                }
            }
            catch { }
        }

        private void comboQuizFilesName_MouseEnter(object sender, EventArgs e)
        {
            try
            {
                string[] files = Directory.GetFiles(Paths.QuizFilePath);

                foreach (var file in files)
                {
                    try
                    {
                        FileInfo fileInfo1 = new FileInfo(file);
                        string name = fileInfo1.Name;
                        name = name.Remove(name.Length - 5);
                        comboQuizFilesName.Items.Add(name);
                    }
                    catch { }
                }
            }
            catch { }
        }

        private void comboQuizFilesName_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void comboQuizFilesName_MouseLeave(object sender, EventArgs e)
        {
            try
            {

                comboQuizFilesName.Items.Clear();
            }
            catch { }
        }

        private void txtStudentQuestion_TextChanged(object sender, EventArgs e)
        {

        }
        public int _checked = 0;
        public int result = 0;
        private void btnNext_Click(object sender, EventArgs e)
        {
            try
            {


                string jsoncontent = File.ReadAllText(p);
                var questions = JsonConvert.DeserializeObject<List<SaveData>>(jsoncontent);

                if (comboVariant.Text == "A" || comboVariant.Text == "B" || comboVariant.Text == "C" || comboVariant.Text == "D")
                {
                 
                    if (questions[index].Answer == comboVariant.Text)
                    {
                        result++;
                    }
                    
                }
                if (comboVariant.Text == "" )
                {
                    _checked += 1;
                }
                comboVariant.Text = "";
                index++;
                jsoncontent = File.ReadAllText(p);
                questions = JsonConvert.DeserializeObject<List<SaveData>>(jsoncontent);

                txtStudentQuestion.Text = questions[index].Question;
                txtOptionA.Text = questions[index].Option1;
                txtOptionB.Text = questions[index].Option2;
                txtOptionC.Text = questions[index].Option3;
                txtOptionD.Text = questions[index].Option4;

                LabelOrder.Text = (index + 1).ToString();
            }
            catch { 
                MessageBox.Show("Testni yechib bo'ldingiz! Natijani bilish uchun Tugatish tugmasini bosing.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void Student_Load(object sender, EventArgs e)
        {
        }



        public int quizLength = 0;
        private void btnBack_Click(object sender, EventArgs e)
        {
            try
            {
                if (index > 0)
                {
                    index -= 1;
                    LabelOrder.Text = (index + 1).ToString();

                    string jsoncontent = File.ReadAllText(p);
                    var questions = JsonConvert.DeserializeObject<List<SaveData>>(jsoncontent);

                    txtStudentQuestion.Text = questions[index].Question;
                    txtOptionA.Text = questions[index].Option1;
                    txtOptionB.Text = questions[index].Option2;
                    txtOptionC.Text = questions[index].Option3;
                    txtOptionD.Text = questions[index].Option4;

                    if (comboVariant.Text != "")
                    {
                        if (questions[index].Answer != comboVariant.Text)
                        {
                            result--;
                            
                        }
                    }
                    else if(comboVariant.Text == "")
                    {
                        _checked++;
                    }

                    comboVariant.Text ="";
                    // index++;
                }
            }
            catch { }
        }

        private void txtSavollarSoni_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            try
            {
                
              
                txtResult.Text = ((result * 100) / int.Parse(txtSavollarSoni.Text) + "%").ToString();
                index = -1;
                result = 0;
                txtSavollarSoni.Clear();
                LabelOrder.Text = string.Empty;
                txtOptionA.Text = string.Empty;
                txtOptionB.Text = string.Empty;
                txtOptionC.Text = string.Empty;
                txtOptionD.Text = string.Empty;
                txtStudentQuestion.Text = string.Empty;
                comboQuizFilesName.Text = string.Empty;
                comboQuizFilesName.Enabled= true;
                comboVariant.Text = string.Empty;
                btnNext.Enabled = false;
                btnBoshlash.Enabled = false;
                btnBack.Enabled = false;
                comboVariant.Enabled = false;
                _checked = 0;

               

                string _sBasePath = Paths.StudentResults;
                string _name = "natija.txt";
                string path = Path.Combine(_sBasePath, _name);

                File.AppendAllText(path, txtResult.Text +"\n");
                File.AppendAllText(path, ComboTxt);
                string[] s = File.ReadAllText(path).Split('\n');
                SignIn @in = new SignIn()
                {
                    QuizName = s[4],
                    Name = s[0],
                    Email = s[1],
                    Password = s[2],
                    Result = s[3]
                };

                string _Base = Paths.StudentResults;
                string _n = "StudentResult.json";
                string _p = Path.Combine(_Base, _n);

                if(!File.Exists(_p))
                {
                    File.WriteAllText(_p, "[]");
                }
                string _s = File.ReadAllText(_p);
                var  _l = JsonConvert.DeserializeObject<List<SignIn>>(_s);
                _l.Add(@in);
                _s = JsonConvert.SerializeObject(_l,Formatting.Indented);
                File.WriteAllText(_p, _s);



            }
            catch { }

        }




        private void btnStudentExit_Click(object sender, EventArgs e)
        {
            this.Close();
            UserRegister userRegister = new UserRegister();
            userRegister.Show();
        }
        public int index = -1;
        private void btnBoshlash_Click(object sender, EventArgs e)
        {
            try
            {
                comboVariant.Enabled = true;
                if (index == -1)

                {
                    txtResult.Text = string.Empty;
                    index++;
                    {
                        string jsoncontent = File.ReadAllText(p);
                        var questions = JsonConvert.DeserializeObject<List<SaveData>>(jsoncontent);

                        txtStudentQuestion.Text = questions[0].Question;
                        txtOptionA.Text = questions[0].Option1;
                        txtOptionB.Text = questions[0].Option2;
                        txtOptionC.Text = questions[0].Option3;
                        txtOptionD.Text = questions[0].Option4;
                        txtSavollarSoni.Text = questions.Count.ToString();
                    }
                }
                LabelOrder.Text = (index + 1).ToString();
                comboQuizFilesName.Enabled= false;
             
            }
            catch { }
        }

        private void LabelStudentNick_Click(object sender, EventArgs e)
        {

        }
    }
}










