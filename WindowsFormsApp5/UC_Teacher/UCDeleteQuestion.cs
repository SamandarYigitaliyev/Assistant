using Newtonsoft.Json;
using System;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;
using WindowsFormsApp5.DataPath;
using WindowsFormsApp5.Questions;

namespace WindowsFormsApp5.UC_Teacher
{
    public partial class UCDeleteQuestion : UserControl
    {
        public UCDeleteQuestion()
        {
            InitializeComponent();
        }

        private void UCDeleteQuestion_Load(object sender, EventArgs e)
        {

        }

        public string DeleteFileNameSelect;
        private void ComboDeleteFileName_SelectedIndexChanged(object sender, EventArgs e)
        {
            DeleteFileNameSelect = ComboFileDeleteSelect.Text;

        }

        private void ComboFileDeleteSelect_MouseEnter(object sender, EventArgs e)
        {
            try {
                string[] files = Directory.GetFiles(Paths.QuizFilePath);

                foreach (var file in files)
                {
                    FileInfo fileInfo1 = new FileInfo(file);
                    string name = fileInfo1.Name;
                    name = name.Remove(name.Length - 5);
                    ComboFileDeleteSelect.Items.Add(name);

                }
            }
            catch { }


            }


        private void ComboFileDeleteSelect_MouseLeave(object sender, EventArgs e)
        {
            ComboFileDeleteSelect.Items.Clear();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnUdalit_Click(object sender, EventArgs e)
        {
            try
            {
                string[] files = Directory.GetFiles(Paths.QuizFilePath);
                foreach (var file in files)
                {
                    FileInfo fileInfo = new FileInfo(file);

                    if (fileInfo.Name.Remove(fileInfo.Name.Length - 5) == DeleteFileNameSelect)
                    {

                        string jsonContent = File.ReadAllText(file);
                        var data = JsonConvert.DeserializeObject<BindingList<SaveData>>(jsonContent);
                        dataGridDelete.DataSource = data;
                    }

                }
            }
            catch { }
            }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {


                int rowIndex = -1;
                rowIndex = dataGridDelete.CurrentCell.RowIndex;
                dataGridDelete.Rows.RemoveAt(rowIndex);

                string[] files = Directory.GetFiles(Paths.QuizFilePath);
                foreach (var file in files)
                {
                    FileInfo fileInfo = new FileInfo(file);

                    if (fileInfo.Name.Remove(fileInfo.Name.Length - 5) == DeleteFileNameSelect)
                    {

                        string jsonContent = File.ReadAllText(file);
                        var data = JsonConvert.DeserializeObject<BindingList<SaveData>>(jsonContent);
                        if (rowIndex == -1) dataGridDelete.DataSource = data;
                        else
                        {
                            data.RemoveAt(rowIndex);
                            dataGridDelete.DataSource = data;
                            rowIndex = -1;
                        }

                        jsonContent = JsonConvert.SerializeObject(data, Formatting.Indented);
                        File.WriteAllText(file, jsonContent);
                    }
                }
            }
            catch { }

        }

    }
}