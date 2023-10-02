namespace WindowsFormsApp5.UC_Teacher
{
    partial class UCDeleteQuestion
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
            this.ComboFileDeleteSelect = new System.Windows.Forms.ComboBox();
            this.dataGridDelete = new System.Windows.Forms.DataGridView();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.btnDelete = new Guna.UI2.WinForms.Guna2Button();
            this.btnUdalit = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDelete)).BeginInit();
            this.SuspendLayout();
            // 
            // ComboFileDeleteSelect
            // 
            this.ComboFileDeleteSelect.Font = new System.Drawing.Font("JetBrains Mono Medium", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboFileDeleteSelect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.ComboFileDeleteSelect.FormattingEnabled = true;
            this.ComboFileDeleteSelect.Location = new System.Drawing.Point(33, 129);
            this.ComboFileDeleteSelect.Name = "ComboFileDeleteSelect";
            this.ComboFileDeleteSelect.Size = new System.Drawing.Size(180, 38);
            this.ComboFileDeleteSelect.TabIndex = 9;
            this.ComboFileDeleteSelect.SelectedIndexChanged += new System.EventHandler(this.ComboDeleteFileName_SelectedIndexChanged);
            this.ComboFileDeleteSelect.MouseEnter += new System.EventHandler(this.ComboFileDeleteSelect_MouseEnter);
            this.ComboFileDeleteSelect.MouseLeave += new System.EventHandler(this.ComboFileDeleteSelect_MouseLeave);
            // 
            // dataGridDelete
            // 
            this.dataGridDelete.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.dataGridDelete.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridDelete.Location = new System.Drawing.Point(33, 192);
            this.dataGridDelete.Name = "dataGridDelete";
            this.dataGridDelete.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("JetBrains Mono", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.MenuText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridDelete.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridDelete.RowHeadersWidth = 51;
            this.dataGridDelete.RowTemplate.Height = 24;
            this.dataGridDelete.Size = new System.Drawing.Size(962, 183);
            this.dataGridDelete.TabIndex = 13;
            this.dataGridDelete.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("JetBrains Mono SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.label1.Location = new System.Drawing.Point(28, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 26);
            this.label1.TabIndex = 59;
            this.label1.Text = "Viktorina nomini tanlang";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.BorderRadius = 5;
            this.btnDelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDelete.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDelete.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Image = global::WindowsFormsApp5.Properties.Resources.bin;
            this.btnDelete.Location = new System.Drawing.Point(815, 449);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(180, 45);
            this.btnDelete.TabIndex = 58;
            this.btnDelete.Text = "O\'chirish";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
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
            this.btnUdalit.Image = global::WindowsFormsApp5.Properties.Resources.eye;
            this.btnUdalit.Location = new System.Drawing.Point(33, 449);
            this.btnUdalit.Name = "btnUdalit";
            this.btnUdalit.Size = new System.Drawing.Size(180, 45);
            this.btnUdalit.TabIndex = 7;
            this.btnUdalit.Text = "Korsatish";
            this.btnUdalit.Click += new System.EventHandler(this.btnUdalit_Click);
            // 
            // UCDeleteQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dataGridDelete);
            this.Controls.Add(this.ComboFileDeleteSelect);
            this.Controls.Add(this.btnUdalit);
            this.Name = "UCDeleteQuestion";
            this.Size = new System.Drawing.Size(1021, 767);
            this.Load += new System.EventHandler(this.UCDeleteQuestion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDelete)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button btnUdalit;
        private System.Windows.Forms.ComboBox ComboFileDeleteSelect;
        private System.Windows.Forms.DataGridView dataGridDelete;
        private Guna.UI2.WinForms.Guna2Button btnDelete;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Label label1;
    }
}
