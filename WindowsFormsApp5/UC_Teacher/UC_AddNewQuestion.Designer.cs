namespace WindowsFormsApp5.UC_Teacher
{
    partial class UC_AddNewQuestion
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelEmail = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboVariant = new System.Windows.Forms.ComboBox();
            this.txtQuizname = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtOption2 = new Guna.UI2.WinForms.Guna2TextBox();
            this.lQuizname = new System.Windows.Forms.Label();
            this.txtOption4 = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtOption3 = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtOption1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtQuestion = new Guna.UI2.WinForms.Guna2TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.lAddNumber = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.QuestionLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Option = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelNickName = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.btnFinish = new Guna.UI2.WinForms.Guna2Button();
            this.btnNext = new Guna.UI2.WinForms.Guna2Button();
            this.btnReset = new Guna.UI2.WinForms.Guna2Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.btnFinish);
            this.panel1.Controls.Add(this.btnNext);
            this.panel1.Controls.Add(this.btnReset);
            this.panel1.Controls.Add(this.labelEmail);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.labelName);
            this.panel1.Controls.Add(this.labelNickName);
            this.panel1.Controls.Add(this.labelLastName);
            this.panel1.Location = new System.Drawing.Point(45, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(898, 647);
            this.panel1.TabIndex = 1;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.BackColor = System.Drawing.Color.Transparent;
            this.labelEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelEmail.ForeColor = System.Drawing.Color.Gray;
            this.labelEmail.Location = new System.Drawing.Point(-74, 310);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(46, 16);
            this.labelEmail.TabIndex = 41;
            this.labelEmail.Text = "Email";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel2.Controls.Add(this.comboVariant);
            this.panel2.Controls.Add(this.txtQuizname);
            this.panel2.Controls.Add(this.txtOption2);
            this.panel2.Controls.Add(this.lQuizname);
            this.panel2.Controls.Add(this.txtOption4);
            this.panel2.Controls.Add(this.txtOption3);
            this.panel2.Controls.Add(this.txtOption1);
            this.panel2.Controls.Add(this.txtQuestion);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.lAddNumber);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.QuestionLabel);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.Option);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel2.Location = new System.Drawing.Point(25, 9);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(848, 555);
            this.panel2.TabIndex = 25;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // comboVariant
            // 
            this.comboVariant.Font = new System.Drawing.Font("JetBrains Mono", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboVariant.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.comboVariant.FormattingEnabled = true;
            this.comboVariant.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D"});
            this.comboVariant.Location = new System.Drawing.Point(712, 463);
            this.comboVariant.Name = "comboVariant";
            this.comboVariant.Size = new System.Drawing.Size(91, 31);
            this.comboVariant.TabIndex = 86;
            // 
            // txtQuizname
            // 
            this.txtQuizname.BorderRadius = 5;
            this.txtQuizname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtQuizname.DefaultText = "";
            this.txtQuizname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtQuizname.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtQuizname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtQuizname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtQuizname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtQuizname.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtQuizname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtQuizname.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtQuizname.Location = new System.Drawing.Point(633, 20);
            this.txtQuizname.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtQuizname.Name = "txtQuizname";
            this.txtQuizname.PasswordChar = '\0';
            this.txtQuizname.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtQuizname.PlaceholderText = "";
            this.txtQuizname.SelectedText = "";
            this.txtQuizname.Size = new System.Drawing.Size(170, 40);
            this.txtQuizname.TabIndex = 42;
            // 
            // txtOption2
            // 
            this.txtOption2.BorderRadius = 5;
            this.txtOption2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtOption2.DefaultText = "";
            this.txtOption2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtOption2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtOption2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtOption2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtOption2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtOption2.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtOption2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtOption2.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtOption2.Location = new System.Drawing.Point(494, 267);
            this.txtOption2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtOption2.Name = "txtOption2";
            this.txtOption2.PasswordChar = '\0';
            this.txtOption2.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtOption2.PlaceholderText = "";
            this.txtOption2.SelectedText = "";
            this.txtOption2.Size = new System.Drawing.Size(308, 62);
            this.txtOption2.TabIndex = 40;
            // 
            // lQuizname
            // 
            this.lQuizname.AutoSize = true;
            this.lQuizname.Font = new System.Drawing.Font("JetBrains Mono NL", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lQuizname.ForeColor = System.Drawing.Color.White;
            this.lQuizname.Location = new System.Drawing.Point(422, 20);
            this.lQuizname.Name = "lQuizname";
            this.lQuizname.Size = new System.Drawing.Size(192, 26);
            this.lQuizname.TabIndex = 32;
            this.lQuizname.Text = "Viktorina nomi:";
            // 
            // txtOption4
            // 
            this.txtOption4.BorderRadius = 5;
            this.txtOption4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtOption4.DefaultText = "";
            this.txtOption4.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtOption4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtOption4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtOption4.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtOption4.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtOption4.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtOption4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtOption4.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtOption4.Location = new System.Drawing.Point(494, 382);
            this.txtOption4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtOption4.Name = "txtOption4";
            this.txtOption4.PasswordChar = '\0';
            this.txtOption4.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtOption4.PlaceholderText = "";
            this.txtOption4.SelectedText = "";
            this.txtOption4.Size = new System.Drawing.Size(308, 62);
            this.txtOption4.TabIndex = 38;
            // 
            // txtOption3
            // 
            this.txtOption3.BorderRadius = 5;
            this.txtOption3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtOption3.DefaultText = "";
            this.txtOption3.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtOption3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtOption3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtOption3.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtOption3.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtOption3.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtOption3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtOption3.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtOption3.Location = new System.Drawing.Point(58, 382);
            this.txtOption3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtOption3.Name = "txtOption3";
            this.txtOption3.PasswordChar = '\0';
            this.txtOption3.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtOption3.PlaceholderText = "";
            this.txtOption3.SelectedText = "";
            this.txtOption3.Size = new System.Drawing.Size(305, 62);
            this.txtOption3.TabIndex = 39;
            this.txtOption3.TextChanged += new System.EventHandler(this.txtOption3_TextChanged);
            // 
            // txtOption1
            // 
            this.txtOption1.BorderRadius = 5;
            this.txtOption1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtOption1.DefaultText = "";
            this.txtOption1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtOption1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtOption1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtOption1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtOption1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtOption1.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtOption1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtOption1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtOption1.Location = new System.Drawing.Point(58, 267);
            this.txtOption1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtOption1.Name = "txtOption1";
            this.txtOption1.PasswordChar = '\0';
            this.txtOption1.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtOption1.PlaceholderText = "";
            this.txtOption1.SelectedText = "";
            this.txtOption1.Size = new System.Drawing.Size(305, 62);
            this.txtOption1.TabIndex = 35;
            this.txtOption1.TextChanged += new System.EventHandler(this.txtOption1_TextChanged_1);
            // 
            // txtQuestion
            // 
            this.txtQuestion.BorderRadius = 5;
            this.txtQuestion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtQuestion.DefaultText = "";
            this.txtQuestion.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtQuestion.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtQuestion.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtQuestion.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtQuestion.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtQuestion.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtQuestion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtQuestion.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtQuestion.Location = new System.Drawing.Point(58, 96);
            this.txtQuestion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtQuestion.Name = "txtQuestion";
            this.txtQuestion.PasswordChar = '\0';
            this.txtQuestion.PlaceholderForeColor = System.Drawing.Color.White;
            this.txtQuestion.PlaceholderText = "";
            this.txtQuestion.SelectedText = "";
            this.txtQuestion.Size = new System.Drawing.Size(745, 101);
            this.txtQuestion.TabIndex = 34;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(610, 463);
            this.label10.Name = "label10";
            this.label10.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label10.Size = new System.Drawing.Size(96, 26);
            this.label10.TabIndex = 30;
            this.label10.Text = "Javobi:";
            // 
            // lAddNumber
            // 
            this.lAddNumber.AutoSize = true;
            this.lAddNumber.BackColor = System.Drawing.Color.Transparent;
            this.lAddNumber.Font = new System.Drawing.Font("JetBrains Mono NL ExtraBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lAddNumber.ForeColor = System.Drawing.Color.Red;
            this.lAddNumber.Location = new System.Drawing.Point(228, 498);
            this.lAddNumber.Name = "lAddNumber";
            this.lAddNumber.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lAddNumber.Size = new System.Drawing.Size(27, 30);
            this.lAddNumber.TabIndex = 2;
            this.lAddNumber.Text = "1";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(492, 351);
            this.label9.Name = "label9";
            this.label9.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label9.Size = new System.Drawing.Size(120, 26);
            this.label9.TabIndex = 28;
            this.label9.Text = "Variant D";
            // 
            // QuestionLabel
            // 
            this.QuestionLabel.AutoSize = true;
            this.QuestionLabel.BackColor = System.Drawing.Color.Transparent;
            this.QuestionLabel.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.QuestionLabel.ForeColor = System.Drawing.Color.White;
            this.QuestionLabel.Location = new System.Drawing.Point(54, 501);
            this.QuestionLabel.Name = "QuestionLabel";
            this.QuestionLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.QuestionLabel.Size = new System.Drawing.Size(168, 26);
            this.QuestionLabel.TabIndex = 1;
            this.QuestionLabel.Text = "Savol no\'meri";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(54, 351);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label8.Size = new System.Drawing.Size(120, 26);
            this.label8.TabIndex = 26;
            this.label8.Text = "Variant C";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(494, 236);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label7.Size = new System.Drawing.Size(120, 26);
            this.label7.TabIndex = 24;
            this.label7.Text = "Variant B";
            // 
            // Option
            // 
            this.Option.AutoSize = true;
            this.Option.BackColor = System.Drawing.Color.Transparent;
            this.Option.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Option.ForeColor = System.Drawing.Color.White;
            this.Option.Location = new System.Drawing.Point(54, 236);
            this.Option.Name = "Option";
            this.Option.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Option.Size = new System.Drawing.Size(120, 26);
            this.Option.TabIndex = 22;
            this.Option.Text = "Variant A";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(54, 56);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label5.Size = new System.Drawing.Size(72, 26);
            this.label5.TabIndex = 20;
            this.label5.Text = "Savol";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.BackColor = System.Drawing.Color.Transparent;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName.ForeColor = System.Drawing.Color.Gray;
            this.labelName.Location = new System.Drawing.Point(-74, 15);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(31, 16);
            this.labelName.TabIndex = 36;
            this.labelName.Text = "Ism";
            // 
            // labelNickName
            // 
            this.labelNickName.AutoSize = true;
            this.labelNickName.BackColor = System.Drawing.Color.Transparent;
            this.labelNickName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNickName.ForeColor = System.Drawing.Color.Gray;
            this.labelNickName.Location = new System.Drawing.Point(-74, 215);
            this.labelNickName.Name = "labelNickName";
            this.labelNickName.Size = new System.Drawing.Size(66, 16);
            this.labelNickName.TabIndex = 40;
            this.labelNickName.Text = "Taxallus";
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.BackColor = System.Drawing.Color.Transparent;
            this.labelLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLastName.ForeColor = System.Drawing.Color.Gray;
            this.labelLastName.Location = new System.Drawing.Point(-74, 111);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(66, 16);
            this.labelLastName.TabIndex = 37;
            this.labelLastName.Text = "Familiya";
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // btnFinish
            // 
            this.btnFinish.BackColor = System.Drawing.Color.Transparent;
            this.btnFinish.BorderRadius = 5;
            this.btnFinish.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnFinish.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnFinish.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnFinish.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnFinish.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnFinish.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnFinish.ForeColor = System.Drawing.Color.White;
            this.btnFinish.Image = global::WindowsFormsApp5.Properties.Resources.flag;
            this.btnFinish.Location = new System.Drawing.Point(693, 581);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(180, 45);
            this.btnFinish.TabIndex = 42;
            this.btnFinish.Text = "Tugatish";
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click_1);
            this.btnFinish.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnFinish_MouseDown_1);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.Transparent;
            this.btnNext.BorderRadius = 5;
            this.btnNext.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNext.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNext.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNext.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNext.FillColor = System.Drawing.Color.MediumBlue;
            this.btnNext.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.Image = global::WindowsFormsApp5.Properties.Resources.next1;
            this.btnNext.Location = new System.Drawing.Point(25, 581);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(180, 45);
            this.btnNext.TabIndex = 9;
            this.btnNext.Text = "Keyingisi";
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click_2);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Transparent;
            this.btnReset.BorderRadius = 5;
            this.btnReset.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnReset.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnReset.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnReset.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnReset.FillColor = System.Drawing.Color.MediumBlue;
            this.btnReset.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Image = global::WindowsFormsApp5.Properties.Resources.arrow;
            this.btnReset.Location = new System.Drawing.Point(336, 581);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(243, 45);
            this.btnReset.TabIndex = 8;
            this.btnReset.Text = "Qayta yozish";
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click_1);
            // 
            // UC_AddNewQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UC_AddNewQuestion";
            this.Size = new System.Drawing.Size(1021, 767);
            this.Load += new System.EventHandler(this.UC_AddNewQuestion_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
      //  private ElipseControl elipseControl1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lAddNumber;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label QuestionLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label Option;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lQuizname;
        private Guna.UI2.WinForms.Guna2TextBox txtOption4;
        private Guna.UI2.WinForms.Guna2TextBox txtQuestion;
        private Guna.UI2.WinForms.Guna2TextBox txtOption1;
        private Guna.UI2.WinForms.Guna2TextBox txtOption3;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelNickName;
        private System.Windows.Forms.Label labelLastName;
        private Guna.UI2.WinForms.Guna2TextBox txtOption2;
        private Guna.UI2.WinForms.Guna2TextBox txtQuizname;
        private Guna.UI2.WinForms.Guna2Button btnFinish;
        private Guna.UI2.WinForms.Guna2Button btnNext;
        private Guna.UI2.WinForms.Guna2Button btnReset;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.ComboBox comboVariant;
    }
}
