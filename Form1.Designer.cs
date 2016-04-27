namespace c_labs
{
    partial class Form1
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
            this.Label1 = new System.Windows.Forms.Label();
            this.InsuranceDisabled = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.readButton = new System.Windows.Forms.Button();
            this.file = new System.Windows.Forms.TextBox();
            this.BrowseFileButton = new System.Windows.Forms.Button();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.radio2 = new System.Windows.Forms.RadioButton();
            this.check = new System.Windows.Forms.CheckBox();
            this.radio1 = new System.Windows.Forms.RadioButton();
            this.select = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.value2 = new System.Windows.Forms.TextBox();
            this.value1 = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.TextBox();
            this.InsuranceDisabled.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // Label1
            // 
            this.Label1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Verdana", 18F);
            this.Label1.Location = new System.Drawing.Point(253, 9);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(107, 36);
            this.Label1.TabIndex = 22;
            this.Label1.Text = "c-labs";
            // 
            // InsuranceDisabled
            // 
            this.InsuranceDisabled.Controls.Add(this.tabPage1);
            this.InsuranceDisabled.Controls.Add(this.tabPage5);
            this.InsuranceDisabled.Controls.Add(this.tabPage4);
            this.InsuranceDisabled.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InsuranceDisabled.Location = new System.Drawing.Point(35, 66);
            this.InsuranceDisabled.Name = "InsuranceDisabled";
            this.InsuranceDisabled.SelectedIndex = 0;
            this.InsuranceDisabled.Size = new System.Drawing.Size(569, 277);
            this.InsuranceDisabled.TabIndex = 38;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tabPage1.Controls.Add(this.readButton);
            this.tabPage1.Controls.Add(this.file);
            this.tabPage1.Controls.Add(this.BrowseFileButton);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(561, 248);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Excel";
            // 
            // readButton
            // 
            this.readButton.Font = new System.Drawing.Font("Verdana", 14.2F, System.Drawing.FontStyle.Bold);
            this.readButton.Location = new System.Drawing.Point(6, 96);
            this.readButton.Name = "readButton";
            this.readButton.Size = new System.Drawing.Size(548, 37);
            this.readButton.TabIndex = 41;
            this.readButton.Text = "read excel";
            this.readButton.UseVisualStyleBackColor = true;
            this.readButton.Click += new System.EventHandler(this.readButton_Click);
            // 
            // file
            // 
            this.file.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.file.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.file.Enabled = false;
            this.file.HideSelection = false;
            this.file.Location = new System.Drawing.Point(5, 56);
            this.file.Name = "file";
            this.file.Size = new System.Drawing.Size(500, 23);
            this.file.TabIndex = 37;
            // 
            // BrowseFileButton
            // 
            this.BrowseFileButton.Location = new System.Drawing.Point(511, 55);
            this.BrowseFileButton.Name = "BrowseFileButton";
            this.BrowseFileButton.Size = new System.Drawing.Size(43, 23);
            this.BrowseFileButton.TabIndex = 2;
            this.BrowseFileButton.Text = "...";
            this.BrowseFileButton.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tabPage5.Controls.Add(this.radio2);
            this.tabPage5.Controls.Add(this.check);
            this.tabPage5.Controls.Add(this.radio1);
            this.tabPage5.Controls.Add(this.select);
            this.tabPage5.Controls.Add(this.label11);
            this.tabPage5.Controls.Add(this.label9);
            this.tabPage5.Controls.Add(this.label10);
            this.tabPage5.Controls.Add(this.value2);
            this.tabPage5.Controls.Add(this.value1);
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(561, 248);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Form";
            // 
            // radio2
            // 
            this.radio2.AutoSize = true;
            this.radio2.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio2.Location = new System.Drawing.Point(9, 127);
            this.radio2.Name = "radio2";
            this.radio2.Size = new System.Drawing.Size(133, 24);
            this.radio2.TabIndex = 58;
            this.radio2.Text = "Radio - Op2";
            this.radio2.UseVisualStyleBackColor = true;
            // 
            // check
            // 
            this.check.AutoSize = true;
            this.check.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check.Location = new System.Drawing.Point(9, 157);
            this.check.Name = "check";
            this.check.Size = new System.Drawing.Size(83, 24);
            this.check.TabIndex = 57;
            this.check.Text = "Check";
            this.check.UseVisualStyleBackColor = true;
            // 
            // radio1
            // 
            this.radio1.AutoSize = true;
            this.radio1.Checked = true;
            this.radio1.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio1.Location = new System.Drawing.Point(9, 97);
            this.radio1.Name = "radio1";
            this.radio1.Size = new System.Drawing.Size(133, 24);
            this.radio1.TabIndex = 56;
            this.radio1.TabStop = true;
            this.radio1.Text = "Radio - Op1";
            this.radio1.UseVisualStyleBackColor = true;
            // 
            // select
            // 
            this.select.DisplayMember = "desc";
            this.select.FormattingEnabled = true;
            this.select.Location = new System.Drawing.Point(9, 67);
            this.select.Name = "select";
            this.select.Size = new System.Drawing.Size(306, 24);
            this.select.TabIndex = 9;
            this.select.ValueMember = "id";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(321, 67);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(117, 20);
            this.label11.TabIndex = 51;
            this.label11.Text = "Combobox 1";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(88, 38);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 20);
            this.label9.TabIndex = 49;
            this.label9.Text = "Value 2";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(88, 11);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 20);
            this.label10.TabIndex = 48;
            this.label10.Text = "Value 1";
            // 
            // value2
            // 
            this.value2.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.value2.Location = new System.Drawing.Point(9, 38);
            this.value2.Name = "value2";
            this.value2.Size = new System.Drawing.Size(73, 23);
            this.value2.TabIndex = 8;
            // 
            // value1
            // 
            this.value1.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.value1.Location = new System.Drawing.Point(9, 11);
            this.value1.Name = "value1";
            this.value1.Size = new System.Drawing.Size(73, 23);
            this.value1.TabIndex = 7;
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tabPage4.Controls.Add(this.label6);
            this.tabPage4.Controls.Add(this.id);
            this.tabPage4.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabPage4.ForeColor = System.Drawing.Color.Black;
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tabPage4.Size = new System.Drawing.Size(561, 248);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "tab4";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(87, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 20);
            this.label6.TabIndex = 59;
            this.label6.Text = "Valor";
            // 
            // id
            // 
            this.id.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id.Location = new System.Drawing.Point(8, 12);
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Size = new System.Drawing.Size(73, 23);
            this.id.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 409);
            this.Controls.Add(this.InsuranceDisabled);
            this.Controls.Add(this.Label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.InsuranceDisabled.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label Label1;
        private System.Windows.Forms.TabControl InsuranceDisabled;
        private System.Windows.Forms.TabPage tabPage1;
        internal System.Windows.Forms.TextBox file;
        internal System.Windows.Forms.Button BrowseFileButton;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.ComboBox select;
        internal System.Windows.Forms.Label label11;
        internal System.Windows.Forms.Label label9;
        internal System.Windows.Forms.Label label10;
        internal System.Windows.Forms.TextBox value2;
        internal System.Windows.Forms.TextBox value1;
        private System.Windows.Forms.TabPage tabPage4;
        internal System.Windows.Forms.Label label6;
        internal System.Windows.Forms.TextBox id;
        internal System.Windows.Forms.RadioButton radio2;
        private System.Windows.Forms.CheckBox check;
        internal System.Windows.Forms.RadioButton radio1;
        internal System.Windows.Forms.Button readButton;
    }
}

