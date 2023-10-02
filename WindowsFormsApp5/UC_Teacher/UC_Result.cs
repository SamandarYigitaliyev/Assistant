using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp5.DataPath;
using WindowsFormsApp5.Register;

namespace WindowsFormsApp5.UC_Teacher
{
    public partial class UC_Result : UserControl
    {
        public UC_Result()
        {
            InitializeComponent();
        }

        private void ComboResultFileName_MouseEnter(object sender, EventArgs e)
        {
            string[] str = Directory.GetFiles(Paths.StudentResults);
            foreach (string str2 in str)
            {
                FileInfo fileInfo = new FileInfo(str2);
                string st = fileInfo.Name;
                if (st.Contains(".json"))
                {
                    string strr = File.ReadAllText(str2);
                    var json = JsonConvert.DeserializeObject<List<SignIn>>(strr);
                    string nom = json[0].QuizName;
                    ComboResultFileName.Items.Add(nom);
                    foreach (var j in json)
                    {
                            if(nom!=j.QuizName) ComboResultFileName.Items.Add(j.QuizName);

                    }

                }
            }
        }

        public string ComboSelctFileName;
        private void ComboResultFileName_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboSelctFileName = ComboResultFileName.Text;

        }

        private void btnKorish(object sender, EventArgs e)
        {
            dataGridResult.Rows.Clear();
            try
            {

                string[] str = Directory.GetFiles(Paths.StudentResults);
                foreach (string str2 in str)
                {
                    FileInfo fileInfo = new FileInfo(str2);
                    string st = fileInfo.Name;
                    if (st.Contains(".json"))
                    {
                        string strr = File.ReadAllText(str2);
                        var json = JsonConvert.DeserializeObject<List<SignIn>>(strr);
                        foreach (var j in json)
                        {
                            if (j.QuizName == ComboSelctFileName)
                            {
                                dataGridResult.Rows.Add(j.QuizName, j.Name, j.Email,j.Result);
                            }
                        }

                    }
                }

            }
            catch { }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void ComboResultFileName_MouseLeave(object sender, EventArgs e)
        {
            ComboResultFileName.Items.Clear();
        }
    }
}
