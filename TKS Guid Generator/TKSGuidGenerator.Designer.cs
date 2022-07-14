namespace TKS_Guid_Generator
{
    partial class TKSGuidGenerator
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
            this.btnCopyGuids = new System.Windows.Forms.Button();
            this.btnGenerateGuids = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtGuidsCount = new TKS_Tools.TKSTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chkHyphens = new System.Windows.Forms.CheckBox();
            this.chkUppercase = new System.Windows.Forms.CheckBox();
            this.chkBraces = new System.Windows.Forms.CheckBox();
            this.gBoxGuids = new System.Windows.Forms.GroupBox();
            this.txtGuids = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBxFormIcon)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.gBoxGuids.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFormTitle
            // 
            this.lblFormTitle.Size = new System.Drawing.Size(173, 21);
            this.lblFormTitle.Text = "TKS Guid Generator";
            // 
            // btnCopyGuids
            // 
            this.btnCopyGuids.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnCopyGuids.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCopyGuids.Font = new System.Drawing.Font("Calibri", 12F);
            this.btnCopyGuids.ForeColor = System.Drawing.Color.White;
            this.btnCopyGuids.Location = new System.Drawing.Point(186, 509);
            this.btnCopyGuids.Name = "btnCopyGuids";
            this.btnCopyGuids.Size = new System.Drawing.Size(185, 36);
            this.btnCopyGuids.TabIndex = 20;
            this.btnCopyGuids.Text = "Copy GUID(s)";
            this.btnCopyGuids.UseVisualStyleBackColor = false;
            this.btnCopyGuids.Click += new System.EventHandler(this.btnCopyGuids_Click);
            // 
            // btnGenerateGuids
            // 
            this.btnGenerateGuids.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnGenerateGuids.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerateGuids.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold);
            this.btnGenerateGuids.ForeColor = System.Drawing.Color.White;
            this.btnGenerateGuids.Location = new System.Drawing.Point(186, 339);
            this.btnGenerateGuids.Name = "btnGenerateGuids";
            this.btnGenerateGuids.Size = new System.Drawing.Size(185, 46);
            this.btnGenerateGuids.TabIndex = 19;
            this.btnGenerateGuids.Text = "Generate GUID(s)";
            this.btnGenerateGuids.UseVisualStyleBackColor = false;
            this.btnGenerateGuids.Click += new System.EventHandler(this.btnGenerateGuids_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtGuidsCount);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(19, 257);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(352, 76);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "COUNT";
            // 
            // txtGuidsCount
            // 
            this.txtGuidsCount.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold);
            this.txtGuidsCount.Location = new System.Drawing.Point(236, 29);
            this.txtGuidsCount.Name = "txtGuidsCount";
            this.txtGuidsCount.Size = new System.Drawing.Size(91, 30);
            this.txtGuidsCount.TabIndex = 1;
            this.txtGuidsCount.Text = "5";
            this.txtGuidsCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtGuidsCount.TextBoxFormat = TKS_Tools.TextboxFormat.Number;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F);
            this.label1.Location = new System.Drawing.Point(18, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "How many GUIDs do you want?";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBox4);
            this.groupBox2.Controls.Add(this.checkBox5);
            this.groupBox2.Controls.Add(this.checkBox6);
            this.groupBox2.Enabled = false;
            this.groupBox2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(19, 172);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(352, 69);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ENCODING";
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(22, 31);
            this.checkBox4.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(75, 23);
            this.checkBox4.TabIndex = 8;
            this.checkBox4.Text = "Base64";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(126, 31);
            this.checkBox5.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(88, 23);
            this.checkBox5.TabIndex = 8;
            this.checkBox5.Text = "RFC 7515";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(226, 31);
            this.checkBox6.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(108, 23);
            this.checkBox6.TabIndex = 8;
            this.checkBox6.Text = "URL encode";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chkHyphens);
            this.groupBox3.Controls.Add(this.chkUppercase);
            this.groupBox3.Controls.Add(this.chkBraces);
            this.groupBox3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(19, 82);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(352, 69);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "FORMAT";
            // 
            // chkHyphens
            // 
            this.chkHyphens.AutoSize = true;
            this.chkHyphens.Checked = true;
            this.chkHyphens.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkHyphens.Location = new System.Drawing.Point(23, 31);
            this.chkHyphens.Margin = new System.Windows.Forms.Padding(4);
            this.chkHyphens.Name = "chkHyphens";
            this.chkHyphens.Size = new System.Drawing.Size(96, 23);
            this.chkHyphens.TabIndex = 8;
            this.chkHyphens.Text = "- Hyphens";
            this.chkHyphens.UseVisualStyleBackColor = true;
            // 
            // chkUppercase
            // 
            this.chkUppercase.AutoSize = true;
            this.chkUppercase.Location = new System.Drawing.Point(227, 31);
            this.chkUppercase.Margin = new System.Windows.Forms.Padding(4);
            this.chkUppercase.Name = "chkUppercase";
            this.chkUppercase.Size = new System.Drawing.Size(107, 23);
            this.chkUppercase.TabIndex = 8;
            this.chkUppercase.Text = "UPPERCASE";
            this.chkUppercase.UseVisualStyleBackColor = true;
            // 
            // chkBraces
            // 
            this.chkBraces.AutoSize = true;
            this.chkBraces.Location = new System.Drawing.Point(127, 31);
            this.chkBraces.Margin = new System.Windows.Forms.Padding(4);
            this.chkBraces.Name = "chkBraces";
            this.chkBraces.Size = new System.Drawing.Size(92, 23);
            this.chkBraces.TabIndex = 8;
            this.chkBraces.Text = "{ } Braces";
            this.chkBraces.UseVisualStyleBackColor = true;
            // 
            // gBoxGuids
            // 
            this.gBoxGuids.Controls.Add(this.txtGuids);
            this.gBoxGuids.Font = new System.Drawing.Font("Calibri", 12F);
            this.gBoxGuids.ForeColor = System.Drawing.Color.White;
            this.gBoxGuids.Location = new System.Drawing.Point(377, 82);
            this.gBoxGuids.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.gBoxGuids.Name = "gBoxGuids";
            this.gBoxGuids.Size = new System.Drawing.Size(365, 478);
            this.gBoxGuids.TabIndex = 21;
            this.gBoxGuids.TabStop = false;
            this.gBoxGuids.Text = "[0]";
            // 
            // txtGuids
            // 
            this.txtGuids.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGuids.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtGuids.Font = new System.Drawing.Font("Calibri", 12F);
            this.txtGuids.ForeColor = System.Drawing.Color.Black;
            this.txtGuids.Location = new System.Drawing.Point(17, 24);
            this.txtGuids.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.txtGuids.Multiline = true;
            this.txtGuids.Name = "txtGuids";
            this.txtGuids.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtGuids.Size = new System.Drawing.Size(331, 439);
            this.txtGuids.TabIndex = 19;
            this.txtGuids.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtGuids.TextChanged += new System.EventHandler(this.txtGuids_TextChanged);
            // 
            // TKSGuidGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 572);
            this.Controls.Add(this.gBoxGuids);
            this.Controls.Add(this.btnCopyGuids);
            this.Controls.Add(this.btnGenerateGuids);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Name = "TKSGuidGenerator";
            this.Text = "TKS Guid Generator";
            this.Controls.SetChildIndex(this.groupBox3, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.btnGenerateGuids, 0);
            this.Controls.SetChildIndex(this.btnCopyGuids, 0);
            this.Controls.SetChildIndex(this.gBoxGuids, 0);
            ((System.ComponentModel.ISupportInitialize)(this.picBxFormIcon)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.gBoxGuids.ResumeLayout(false);
            this.gBoxGuids.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCopyGuids;
        private System.Windows.Forms.Button btnGenerateGuids;
        private System.Windows.Forms.GroupBox groupBox1;
        private TKS_Tools.TKSTextBox txtGuidsCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox chkHyphens;
        private System.Windows.Forms.CheckBox chkUppercase;
        private System.Windows.Forms.CheckBox chkBraces;
        private System.Windows.Forms.GroupBox gBoxGuids;
        private System.Windows.Forms.TextBox txtGuids;
    }
}