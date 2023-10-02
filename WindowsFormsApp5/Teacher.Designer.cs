namespace WindowsFormsApp5
{
    partial class TeacherForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeacherForm));
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.imageSlide = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnQoshish = new Guna.UI2.WinForms.Guna2Button();
            this.btnKirish = new Guna.UI2.WinForms.Guna2Button();
            this.btnYangilash = new Guna.UI2.WinForms.Guna2Button();
            this.btnOchirish = new Guna.UI2.WinForms.Guna2Button();
            this.btnResult = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.uC_Result1 = new WindowsFormsApp5.UC_Teacher.UC_Result();
            this.result1 = new WindowsFormsApp5.UC_Teacher.Result();
            this.guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.ucDeleteQuestion1 = new WindowsFormsApp5.UC_Teacher.UCDeleteQuestion();
            this.uControlUbdateQuestion1 = new WindowsFormsApp5.UC_Teacher.UControlUbdateQuestion();
            this.uC_AddNewQuestion1 = new WindowsFormsApp5.UC_Teacher.UC_AddNewQuestion();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageSlide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.guna2Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Controls.Add(this.imageSlide);
            this.guna2Panel1.Controls.Add(this.guna2PictureBox1);
            this.guna2Panel1.Controls.Add(this.btnQoshish);
            this.guna2Panel1.Controls.Add(this.btnKirish);
            this.guna2Panel1.Controls.Add(this.btnYangilash);
            this.guna2Panel1.Controls.Add(this.btnOchirish);
            this.guna2Panel1.Controls.Add(this.btnResult);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Padding = new System.Windows.Forms.Padding(0, 6, 6, 6);
            this.guna2Panel1.Size = new System.Drawing.Size(278, 767);
            this.guna2Panel1.TabIndex = 0;
            this.guna2Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("JetBrains Mono SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(85, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 26);
            this.label1.TabIndex = 4;
            this.label1.Text = "Teacher";
            // 
            // imageSlide
            // 
            this.imageSlide.BackColor = System.Drawing.Color.Transparent;
            this.imageSlide.Image = ((System.Drawing.Image)(resources.GetObject("imageSlide.Image")));
            this.imageSlide.ImageRotate = 0F;
            this.imageSlide.Location = new System.Drawing.Point(230, 197);
            this.imageSlide.Name = "imageSlide";
            this.imageSlide.Size = new System.Drawing.Size(48, 146);
            this.imageSlide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageSlide.TabIndex = 0;
            this.imageSlide.TabStop = false;
            this.imageSlide.UseTransparentBackground = true;
            this.imageSlide.Click += new System.EventHandler(this.imageSlide_Click);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.BorderRadius = 22;
            this.guna2PictureBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(57, 12);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(166, 129);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 0;
            this.guna2PictureBox1.TabStop = false;
            this.guna2PictureBox1.UseTransparentBackground = true;
            // 
            // btnQoshish
            // 
            this.btnQoshish.BorderRadius = 25;
            this.btnQoshish.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnQoshish.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnQoshish.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.btnQoshish.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnQoshish.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnQoshish.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnQoshish.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnQoshish.FillColor = System.Drawing.Color.Empty;
            this.btnQoshish.Font = new System.Drawing.Font("JetBrains Mono SemiBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnQoshish.ForeColor = System.Drawing.Color.White;
            this.btnQoshish.Image = global::WindowsFormsApp5.Properties.Resources.plus;
            this.btnQoshish.Location = new System.Drawing.Point(34, 346);
            this.btnQoshish.Name = "btnQoshish";
            this.btnQoshish.Size = new System.Drawing.Size(224, 49);
            this.btnQoshish.TabIndex = 2;
            this.btnQoshish.Text = "Savol qo\'shish";
            this.btnQoshish.CheckedChanged += new System.EventHandler(this.btnKirish_CheckedChanged);
            this.btnQoshish.Click += new System.EventHandler(this.btnQoshish_Click);
            // 
            // btnKirish
            // 
            this.btnKirish.BorderRadius = 25;
            this.btnKirish.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnKirish.Checked = true;
            this.btnKirish.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnKirish.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.btnKirish.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnKirish.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnKirish.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnKirish.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnKirish.FillColor = System.Drawing.Color.Empty;
            this.btnKirish.Font = new System.Drawing.Font("JetBrains Mono SemiBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnKirish.ForeColor = System.Drawing.Color.White;
            this.btnKirish.Location = new System.Drawing.Point(34, 246);
            this.btnKirish.Name = "btnKirish";
            this.btnKirish.Size = new System.Drawing.Size(224, 49);
            this.btnKirish.TabIndex = 1;
            this.btnKirish.Text = "Kirish";
            this.btnKirish.CheckedChanged += new System.EventHandler(this.btnKirish_CheckedChanged);
            this.btnKirish.Click += new System.EventHandler(this.btnKirish_Click);
            // 
            // btnYangilash
            // 
            this.btnYangilash.BorderRadius = 25;
            this.btnYangilash.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnYangilash.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnYangilash.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.btnYangilash.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnYangilash.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnYangilash.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnYangilash.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnYangilash.FillColor = System.Drawing.Color.Empty;
            this.btnYangilash.Font = new System.Drawing.Font("JetBrains Mono SemiBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnYangilash.ForeColor = System.Drawing.Color.White;
            this.btnYangilash.Image = global::WindowsFormsApp5.Properties.Resources.undo1;
            this.btnYangilash.Location = new System.Drawing.Point(34, 444);
            this.btnYangilash.Name = "btnYangilash";
            this.btnYangilash.Size = new System.Drawing.Size(224, 49);
            this.btnYangilash.TabIndex = 3;
            this.btnYangilash.Text = "Savol yangilash";
            this.btnYangilash.CheckedChanged += new System.EventHandler(this.btnKirish_CheckedChanged);
            this.btnYangilash.Click += new System.EventHandler(this.btnYangilash_Click);
            // 
            // btnOchirish
            // 
            this.btnOchirish.BorderRadius = 25;
            this.btnOchirish.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnOchirish.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnOchirish.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.btnOchirish.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnOchirish.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnOchirish.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnOchirish.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnOchirish.FillColor = System.Drawing.Color.Empty;
            this.btnOchirish.Font = new System.Drawing.Font("JetBrains Mono SemiBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnOchirish.ForeColor = System.Drawing.Color.White;
            this.btnOchirish.Image = global::WindowsFormsApp5.Properties.Resources.bin;
            this.btnOchirish.Location = new System.Drawing.Point(34, 542);
            this.btnOchirish.Name = "btnOchirish";
            this.btnOchirish.Size = new System.Drawing.Size(224, 49);
            this.btnOchirish.TabIndex = 5;
            this.btnOchirish.Text = "Savol o\'chirish";
            this.btnOchirish.CheckedChanged += new System.EventHandler(this.btnKirish_CheckedChanged);
            this.btnOchirish.Click += new System.EventHandler(this.btnOchirish_Click);
            // 
            // btnResult
            // 
            this.btnResult.BorderRadius = 25;
            this.btnResult.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnResult.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnResult.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.btnResult.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnResult.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnResult.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnResult.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnResult.FillColor = System.Drawing.Color.Empty;
            this.btnResult.Font = new System.Drawing.Font("JetBrains Mono SemiBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnResult.ForeColor = System.Drawing.Color.White;
            this.btnResult.Image = global::WindowsFormsApp5.Properties.Resources.mission1;
            this.btnResult.Location = new System.Drawing.Point(34, 638);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(224, 49);
            this.btnResult.TabIndex = 4;
            this.btnResult.Text = "Natijalar";
            this.btnResult.CheckedChanged += new System.EventHandler(this.btnKirish_CheckedChanged);
            this.btnResult.Click += new System.EventHandler(this.btnResult_Click);
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.White;
            this.guna2Panel2.Controls.Add(this.guna2ImageButton1);
            this.guna2Panel2.Controls.Add(this.uC_Result1);
            this.guna2Panel2.Controls.Add(this.result1);
            this.guna2Panel2.Controls.Add(this.ucDeleteQuestion1);
            this.guna2Panel2.Controls.Add(this.uControlUbdateQuestion1);
            this.guna2Panel2.Controls.Add(this.uC_AddNewQuestion1);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel2.Location = new System.Drawing.Point(278, 0);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(1035, 767);
            this.guna2Panel2.TabIndex = 1;
            // 
            // uC_Result1
            // 
            this.uC_Result1.Location = new System.Drawing.Point(0, 0);
            this.uC_Result1.Name = "uC_Result1";
            this.uC_Result1.Size = new System.Drawing.Size(1021, 767);
            this.uC_Result1.TabIndex = 5;
            // 
            // result1
            // 
            this.result1.BackColor = System.Drawing.Color.White;
            this.result1.Location = new System.Drawing.Point(0, 0);
            this.result1.Name = "result1";
            this.result1.Size = new System.Drawing.Size(1021, 767);
            this.result1.TabIndex = 4;
            // 
            // guna2ImageButton1
            // 
            this.guna2ImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ImageButton1.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageButton1.Image")));
            this.guna2ImageButton1.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton1.ImageRotate = 0F;
            this.guna2ImageButton1.IndicateFocus = true;
            this.guna2ImageButton1.Location = new System.Drawing.Point(929, 25);
            this.guna2ImageButton1.Name = "guna2ImageButton1";
            this.guna2ImageButton1.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.Size = new System.Drawing.Size(64, 54);
            this.guna2ImageButton1.TabIndex = 3;
            this.guna2ImageButton1.UseTransparentBackground = true;
            this.guna2ImageButton1.Click += new System.EventHandler(this.guna2ImageButton1_Click);
            // 
            // ucDeleteQuestion1
            // 
            this.ucDeleteQuestion1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ucDeleteQuestion1.Location = new System.Drawing.Point(0, 0);
            this.ucDeleteQuestion1.Name = "ucDeleteQuestion1";
            this.ucDeleteQuestion1.Size = new System.Drawing.Size(1021, 767);
            this.ucDeleteQuestion1.TabIndex = 2;
            this.ucDeleteQuestion1.Load += new System.EventHandler(this.ucDeleteQuestion1_Load);
            // 
            // uControlUbdateQuestion1
            // 
            this.uControlUbdateQuestion1.BackColor = System.Drawing.Color.White;
            this.uControlUbdateQuestion1.Location = new System.Drawing.Point(0, 0);
            this.uControlUbdateQuestion1.Name = "uControlUbdateQuestion1";
            this.uControlUbdateQuestion1.Size = new System.Drawing.Size(1021, 767);
            this.uControlUbdateQuestion1.TabIndex = 1;
            // 
            // uC_AddNewQuestion1
            // 
            this.uC_AddNewQuestion1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.uC_AddNewQuestion1.BackColor = System.Drawing.Color.White;
            this.uC_AddNewQuestion1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.uC_AddNewQuestion1.Location = new System.Drawing.Point(0, 0);
            this.uC_AddNewQuestion1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uC_AddNewQuestion1.Name = "uC_AddNewQuestion1";
            this.uC_AddNewQuestion1.Size = new System.Drawing.Size(1021, 767);
            this.uC_AddNewQuestion1.TabIndex = 0;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // TeacherForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.ClientSize = new System.Drawing.Size(1313, 767);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TeacherForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.TeacherForm_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageSlide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.guna2Panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2PictureBox imageSlide;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2Button btnKirish;
        private Guna.UI2.WinForms.Guna2Button btnOchirish;
        private Guna.UI2.WinForms.Guna2Button btnResult;
        private Guna.UI2.WinForms.Guna2Button btnYangilash;
        private Guna.UI2.WinForms.Guna2Button btnQoshish;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
        private System.Windows.Forms.Label label1;
        private UC_Teacher.UCDeleteQuestion ucDeleteQuestion1;
        private UC_Teacher.UControlUbdateQuestion uControlUbdateQuestion1;
        private UC_Teacher.UC_AddNewQuestion uC_AddNewQuestion1;
        private UC_Teacher.Result result1;
        private UC_Teacher.UC_Result uC_Result1;
    }
}