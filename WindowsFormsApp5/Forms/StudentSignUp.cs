using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Management;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using WindowsFormsApp5.DataPath;
using WindowsFormsApp5.Register;

namespace WindowsFormsApp5.Forms
{
    public partial class StudentSignUp : Form
    {

        public StudentSignUp()
        {
            InitializeComponent();
        }
        
        private void guna2Button2_Click(object sender, EventArgs e)
        {
      
            this.Close();

        }
        public bool IsNomer(string number)
        {
            if (int.TryParse(number, out int tmp))
            {
                string str = number.ToString();
                if (str.Length == 9)
                {
                    return true;
                }
                return false;
            }
            return false;
        }
        public bool IsEmail(string email)
        {
            if (char.IsLetter(email[0]))

            {
                if (Regex.Matches(email, "@gmail.com").Count == 1)
                    return true;
                else
                    return false;
            }
            else
                return false;


        }

        public string NickUsername; 
        private void btnRoyxatdanOtish_Click(object sender, EventArgs e)
        {
            string[] strin = Directory.GetFiles(Paths.UserTypePath);
            string str = File.ReadAllText(strin[0]);         
            
            if (str== "O'quvchi")
            {
                if (txtStudentName.Text != "" && txtStudentLast.Text != "" && txtEmail.Text != "" &&
                    txtStudentPhoneNumber.Text != "" && txtStudentPassword.Text != "")
                {
                    if (IsNomer(txtStudentPhoneNumber.Text))
                    {
                        if (IsEmail(txtEmail.Text))
                        {
                            if (txtResetPassword.Text == txtStudentPassword.Text)
                            {

                                SignUp register = new SignUp()
                                {
                                    FirstName = txtStudentName.Text,
                                    Email = txtEmail.Text,
                                    Password = txtStudentPassword.Text,
                                    LastName = txtStudentLast.Text,
                                    PhoneNumber = txtStudentPhoneNumber.Text

                                };

                                string BasePath = Paths.UsersFullPath;
                                string FileName = "StudentInformation.json";

                                string path = Path.Combine(BasePath, FileName);
                                if (!File.Exists(path))
                                {
                                    File.WriteAllText(path, "[]");
                                }
                                string jsoncontent = File.ReadAllText(path);
                                var information = JsonConvert.DeserializeObject<List<SignUp>>(jsoncontent);
                                information.Add(register);

                                jsoncontent = JsonConvert.SerializeObject(information, Formatting.Indented);
                                File.WriteAllText(path, jsoncontent);

                                MessageBox.Show("Tabriklayman, Ro'yxatdan o'tdingiz.", "Natija", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                txtEmail.Clear();
                                txtResetPassword.Clear();
                                txtStudentName.Clear();
                                txtStudentPhoneNumber.Clear();
                                txtStudentPassword.Clear();
                                txtStudentLast.Clear();

                             
                               
                                this.Close();
                                UserRegister user = new UserRegister();
                                user.Show();

                            }

                            else
                            {
                                MessageBox.Show("Parollar mos kelmadi.Qaytadan urunib ko'ring!!!", "Xato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                txtResetPassword.Clear();
                                txtStudentPassword.Clear();

                            }
                        }
                        else
                        {
                            MessageBox.Show("Email xato kritdingiz!!!", "Xato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtEmail.Clear();
                        }

                    }
                    else
                    {
                        MessageBox.Show("Telefon raqamingizni xato kiritdingiz!!!", "Xato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtStudentPhoneNumber.Clear();
                    }

                }
                else
                {
                    MessageBox.Show("Maydonlarni to'ldiring!!!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            
            /////////////////////////////
                ///

            else if (str == "O'qituvchi")
            {
                if (txtStudentName.Text != "" && txtStudentLast.Text != "" && txtEmail.Text != "" &&
                    txtStudentPhoneNumber.Text != "" && txtStudentPassword.Text != "")
                {
                    if (IsNomer(txtStudentPhoneNumber.Text))
                    {
                        if (IsEmail(txtEmail.Text))
                        {
                            if (txtResetPassword.Text == txtStudentPassword.Text)
                            {

                                SignUp register = new SignUp()
                                {
                                    FirstName = txtStudentName.Text,
                                    Email = txtEmail.Text,
                                    Password = txtStudentPassword.Text,
                                    LastName = txtStudentLast.Text,
                                    PhoneNumber = txtStudentPhoneNumber.Text

                                };

                                string BasePath = Paths.UsersFullPath;
                                string FileName = "TeacherInformation.json";

                                string path = Path.Combine(BasePath, FileName);
                                if (!File.Exists(path))
                                {
                                    File.WriteAllText(path, "[]");
                                }
                                string jsoncontent = File.ReadAllText(path);
                                var information = JsonConvert.DeserializeObject<List<SignUp>>(jsoncontent);
                                information.Add(register);

                                jsoncontent = JsonConvert.SerializeObject(information, Formatting.Indented);
                                File.WriteAllText(path, jsoncontent);

                                MessageBox.Show("Tabriklayman, Ro'yxatdan o'tdingiz.", "Natija", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                txtEmail.Clear();
                                txtResetPassword.Clear();
                                txtStudentName.Clear();
                                txtStudentPhoneNumber.Clear();
                                txtStudentPassword.Clear();
                                txtStudentLast.Clear();

                                this.Close();
                                UserRegister user = new UserRegister();
                                user.Show();

                            }

                            else
                            {
                                MessageBox.Show("Parollar mos kelmadi.Qaytadan urunib ko'ring!!!", "Xato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                txtResetPassword.Clear();
                                txtStudentPassword.Clear();

                            }
                        }
                        else
                        {
                            MessageBox.Show("Email xato kritdingiz!!!", "Xato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtEmail.Clear();
                        }

                    }
                    else
                    {
                        MessageBox.Show("Telefon raqamingizni xato kiritdingiz!!!", "Xato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtStudentPhoneNumber.Clear();
                    }

                }
                else
                {
                    MessageBox.Show("Maydonlarni to'ldiring!!!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            UserRegister userRegister = new UserRegister();
            userRegister.Show();
            
            
            

            
        }

        private void StudentSignUp_Load(object sender, EventArgs e)
        {
          

        }

        private void txtStudentName_TextChanged(object sender, EventArgs e)
        {

        }
    }

}



