using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp5.Forms;

namespace WindowsFormsApp5
{
    public partial class TeacherForm : Form
    {
        public TeacherForm()
        {
            InitializeComponent();
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }

        private void btnSavolQoshish_CheckedChanged(object sender, EventArgs e)
        {
        
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void imageSlide_Click(object sender, EventArgs e)
        {
             
        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

    

        private void TeacherForm_Load(object sender, EventArgs e)
        {
            uC_AddNewQuestion1.Visible = false;
            uControlUbdateQuestion1.Visible = false;
            ucDeleteQuestion1.Visible = false;
            result1.Visible = true ;
            uC_Result1.Visible = false;
            
        }

        private void btnKirish_Click(object sender, EventArgs e)
        {
            uC_AddNewQuestion1.Visible = false;
            uControlUbdateQuestion1.Visible = false;
            ucDeleteQuestion1.Visible = false;
            result1.Visible = true;
            uC_Result1.Visible = false;
        }

        private void btnQoshish_Click(object sender, EventArgs e)
        {
            ucDeleteQuestion1.Visible = false;
            uControlUbdateQuestion1.Visible = false;
            uC_AddNewQuestion1.Visible = true;
            result1.Visible = false;
            uC_Result1.Visible = false;
        }

        private void btnYangilash_Click(object sender, EventArgs e)
        {
            uC_AddNewQuestion1.Visible = false;
            ucDeleteQuestion1.Visible = false;
            uControlUbdateQuestion1.Visible = true;
            result1.Visible = false;
            uC_Result1.Visible = false;
        }

        private void btnOchirish_Click(object sender, EventArgs e)
        {
            uC_AddNewQuestion1.Visible = false;
            uControlUbdateQuestion1.Visible = false;
            ucDeleteQuestion1.Visible = true;
            result1.Visible = false;
            uC_Result1.Visible = false;
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            uC_Result1.Visible = true; 
            uC_AddNewQuestion1.Visible = false;
            uControlUbdateQuestion1.Visible = false;
            ucDeleteQuestion1.Visible = false;
            result1.Visible = false;
            
        }

        public void MovieImage(object sender)
        {
            Guna2Button guna = (Guna2Button)sender;
            imageSlide.Location = new Point(guna.Location.X + 197, guna.Location.Y - 49);
            
        }
        private void btnKirish_CheckedChanged(object sender, EventArgs e)
        {
            MovieImage(sender);
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
          
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
            UserRegister user = new UserRegister();
            user.Show();

        }

        private void ucDeleteQuestion1_Load(object sender, EventArgs e)
        {

        }
    }
}
