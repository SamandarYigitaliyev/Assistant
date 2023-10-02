namespace WindowsFormsApp5.UC_Teacher
{
    partial class UC_Result
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.ComboResultFileName = new System.Windows.Forms.ComboBox();
            this.dataGridResult = new System.Windows.Forms.DataGridView();
            this.QuizName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Result = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.btnUdalit = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridResult)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("JetBrains Mono SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.label1.Location = new System.Drawing.Point(22, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 26);
            this.label1.TabIndex = 64;
            this.label1.Text = "Viktorina nomini tanlang";
            // 
            // ComboResultFileName
            // 
            this.ComboResultFileName.Font = new System.Drawing.Font("JetBrains Mono Medium", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboResultFileName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.ComboResultFileName.FormattingEnabled = true;
            this.ComboResultFileName.Location = new System.Drawing.Point(27, 143);
            this.ComboResultFileName.Name = "ComboResultFileName";
            this.ComboResultFileName.Size = new System.Drawing.Size(180, 38);
            this.ComboResultFileName.TabIndex = 61;
            this.ComboResultFileName.SelectedIndexChanged += new System.EventHandler(this.ComboResultFileName_SelectedIndexChanged);
            this.ComboResultFileName.MouseEnter += new System.EventHandler(this.ComboResultFileName_MouseEnter);
            this.ComboResultFileName.MouseLeave += new System.EventHandler(this.ComboResultFileName_MouseLeave);
            // 
            // dataGridResult
            // 
            this.dataGridResult.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGridResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridResult.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.QuizName,
            this.Name,
            this.Email,
            this.Result});
            this.dataGridResult.GridColor = System.Drawing.Color.White;
            this.dataGridResult.Location = new System.Drawing.Point(27, 210);
            this.dataGridResult.Name = "dataGridResult";
            this.dataGridResult.RowHeadersWidth = 51;
            this.dataGridResult.RowTemplate.Height = 24;
            this.dataGridResult.Size = new System.Drawing.Size(960, 232);
            this.dataGridResult.TabIndex = 65;
            // 
            // QuizName
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("JetBrains Mono SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Cyan;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.QuizName.DefaultCellStyle = dataGridViewCellStyle1;
            this.QuizName.FillWeight = 200F;
            this.QuizName.HeaderText = "Viktorina nomi";
            this.QuizName.MaxInputLength = 454;
            this.QuizName.MinimumWidth = 6;
            this.QuizName.Name = "QuizName";
            this.QuizName.ReadOnly = true;
            this.QuizName.Width = 200;
            // 
            // Name
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("JetBrains Mono SemiBold", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Cyan;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Name.DefaultCellStyle = dataGridViewCellStyle2;
            this.Name.FillWeight = 15F;
            this.Name.HeaderText = "Ism";
            this.Name.MaxInputLength = 15;
            this.Name.MinimumWidth = 6;
            this.Name.Name = "Name";
            this.Name.ReadOnly = true;
            this.Name.Width = 200;
            // 
            // Email
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("JetBrains Mono SemiBold", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Cyan;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Email.DefaultCellStyle = dataGridViewCellStyle3;
            this.Email.HeaderText = "Email";
            this.Email.MaxInputLength = 20;
            this.Email.MinimumWidth = 6;
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.Width = 200;
            // 
            // Result
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("JetBrains Mono SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Aqua;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Result.DefaultCellStyle = dataGridViewCellStyle4;
            this.Result.HeaderText = "Natija";
            this.Result.MaxInputLength = 4;
            this.Result.MinimumWidth = 6;
            this.Result.Name = "Result";
            this.Result.ReadOnly = true;
            this.Result.Width = 125;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // btnUdalit
            // 
            this.btnUdalit.BorderRadius = 5;
            this.btnUdalit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUdalit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUdalit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUdalit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUdalit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnUdalit.Font = new System.Drawing.Font("JetBrains Mono SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnUdalit.ForeColor = System.Drawing.Color.White;
            this.btnUdalit.Image = global::WindowsFormsApp5.Properties.Resources.icons8_view_64;
            this.btnUdalit.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnUdalit.Location = new System.Drawing.Point(807, 461);
            this.btnUdalit.Name = "btnUdalit";
            this.btnUdalit.Size = new System.Drawing.Size(180, 45);
            this.btnUdalit.TabIndex = 60;
            this.btnUdalit.Text = "Korsatish";
            this.btnUdalit.Click += new System.EventHandler(this.btnKorish);
            // 
            // UC_Result
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridResult);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ComboResultFileName);
            this.Controls.Add(this.btnUdalit);
           // this.Name = "UC_Result";
            this.Size = new System.Drawing.Size(1021, 767);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ComboResultFileName;
        private Guna.UI2.WinForms.Guna2Button btnUdalit;
        private System.Windows.Forms.DataGridView dataGridResult;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuizName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Result;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
    }
}
