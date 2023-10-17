using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using WindowsFormsApp5.DataPath;
using WindowsFormsApp5.Register;

namespace WindowsFormsApp5.Forms
{
    public partial class UserRegister : Form
    {
        public UserRegister()
        {
            InitializeComponent();
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void txtStudentName_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkShowPassword.Checked)
            {
                txtSignInStudentPassword.PasswordChar = '\0';
            }
            else
            {
                txtSignInStudentPassword.PasswordChar = '*';
            }
        }

       
        private void buttonSignInUser_Click(object sender, EventArgs e)
        {
            string[] strin = Directory.GetFiles(Paths.UserTypePath);

            string txt = File.ReadAllText(strin[0]);

            if (txt == "O'quvchi")
            {
                Student student1 = new Student();
                this.Hide();
                student1.ShowDialog();
              
                //string BasePath = Paths.UsersFullPath;
                //string[] files = Directory.GetFiles(BasePath);

                //foreach (var file in files)
                //{
                //    FileInfo fileInfo = new FileInfo(file);
                //    if (fileInfo.Name == "StudentInformation.json")
                //    {
                //        string json = File.ReadAllText(file);
                //        var students = JsonConvert.DeserializeObject<List<SignUp>>(json);
                //        int Index = 0;
                //        foreach (var student in students)
                //        {

                //            if (student.FirstName == txtSignInStudentName.Text && student.Password == txtSignInStudentPassword.Text &&
                //               student.Email == txtSignInStudentEmail.Text)
                //            {

                //                File.Delete(strin[0]);

                //                string _sBasePath = Paths.StudentResults;
                //                string _name = "natija.txt";
                //                string path = Path.Combine(_sBasePath,_name);

                //                File.WriteAllText(path, txtSignInStudentName.Text+"\n");
                //                File.AppendAllText(path,txtSignInStudentEmail.Text+"\n");
                //                File.AppendAllText(path,txtSignInStudentPassword.Text + "\n");

                //                txtSignInStudentEmail.Clear();
                //                txtSignInStudentPassword.Clear();
                //                txtSignInStudentName.Clear();




                //            }
                //            else
                //            {
                //                Index++;

                //            }

                //        }
                //        if (students.Count == Index)
                //        {
                //            MessageBox.Show("Bunday foydalanuvchi malmotlari mavjud emas!!! Ro'yxatdan o'tish tugmasini bosing", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //            txtSignInStudentEmail.Clear();
                //            txtSignInStudentPassword.Clear();
                //            txtSignInStudentName.Clear();
                //        }
                //    }

                //}
            }
            else if (txt == "O'qituvchi")
            {
                string BasePath = Paths.UsersFullPath;
                string[] files = Directory.GetFiles(BasePath);
                foreach (var file in files)
                {
                    FileInfo fileInfo = new FileInfo(file);
                    string str = fileInfo.Name;

                    if (fileInfo.Name.Remove(fileInfo.Name.Length - 5) == "TeacherInformation")
                    {
                        string json = File.ReadAllText(file);
                        var students = JsonConvert.DeserializeObject<List<SignUp>>(json);
                        int Index = 0;
                        foreach (var student in students)
                        {

                            if (student.FirstName == txtSignInStudentName.Text && student.Password == txtSignInStudentPassword.Text &&
                               student.Email == txtSignInStudentEmail.Text)
                            {

                                File.Delete(strin[0]);
                                TeacherForm form = new TeacherForm();
                                form.Show();
                                this.Hide();



                                //await Task.Delay(1000);

                                //p_Xavfsizlik.BackColor = Color.Red;
                                //l_Xavfsizlik.Text = "Sizning parolingiz xavfsizlik talablariga\n" +
                                //                    "mos emas, iltimos, parolingizni\n" +
                                //                    "yangilang!";

                                //await Task.Delay(500);

                                //p_Tarmoq.BackColor = Color.PaleGreen;
                                //l_Tarmoq.Text = "Siz tizimga muvaffaqiyatli kirdingiz";



                                //await Task.Delay(3300);

                                //p_Tarmoq.BackColor = Color.FromArgb(240, 239, 235);
                                //l_Tarmoq.Text = String.Empty;


                                //await Task.Delay(1400);

                                //p_Xavfsizlik.BackColor = Color.FromArgb(240, 239, 235);
                                //l_Xavfsizlik.Text = String.Empty;


                            }
                            else
                            {
                                Index++;

                            }

                        }
                        if (students.Count == Index)
                        {
                            MessageBox.Show("Bunday foydalanuvchi malmotlari mavjud emas!!! Ro'yxatdan o'tish tugmasini bosing", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtSignInStudentEmail.Clear();
                            txtSignInStudentPassword.Clear();
                            txtSignInStudentName.Clear();
                        }
                    }

                }
            }


        }

        private void UserRegister_Load(object sender, EventArgs e)
        {
            UserType userType = new UserType();
            this.Hide();
            userType.ShowDialog();

            if (userType.selectt)
            {
                this.Show();
            }




        }

        private void btnRegistratsya_Click(object sender, EventArgs e)
        {
            StudentSignUp signUp = new StudentSignUp();
            this.Hide();
            signUp.ShowDialog();


        }

        //private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        //{

        //}

        private void guna2PictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void txtSignInStudentEmail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
