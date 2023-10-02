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

namespace WindowsFormsApp5.Forms
{
    public partial class UserType : Form
    {
        public static string a;
        public UserType()
        {
            InitializeComponent();
        }

        private void UserType_Load(object sender, EventArgs e)
        {

        }
        
        public bool selectt = false;
        private void comboSelectUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            string page;
            page = comboSelectUser.SelectedItem.ToString();
            string BasePath = Paths.UserTypePath;
            string path = Path.Combine(BasePath, "User.txt");
            File.WriteAllText(path, page);
            selectt= true;
            this.Close();
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
