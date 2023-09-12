namespace SQLbuddy
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
            this.btnUpdate_stmnt = new System.Windows.Forms.Button();
            this.btnHeader = new System.Windows.Forms.Button();
            this.label23 = new System.Windows.Forms.Label();
            this.btnConvertSQL = new System.Windows.Forms.Button();
            this.Label22 = new System.Windows.Forms.Label();
            this.rtfList = new System.Windows.Forms.RichTextBox();
            this.Button3 = new System.Windows.Forms.Button();
            this.label21 = new System.Windows.Forms.Label();
            this.rtfOutputSQL = new System.Windows.Forms.RichTextBox();
            this.btnRowConvert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnUpdate_stmnt
            // 
            this.btnUpdate_stmnt.Location = new System.Drawing.Point(350, 465);
            this.btnUpdate_stmnt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUpdate_stmnt.Name = "btnUpdate_stmnt";
            this.btnUpdate_stmnt.Size = new System.Drawing.Size(146, 40);
            this.btnUpdate_stmnt.TabIndex = 41;
            this.btnUpdate_stmnt.Text = "Update row";
            this.btnUpdate_stmnt.UseVisualStyleBackColor = true;
            this.btnUpdate_stmnt.Click += new System.EventHandler(this.btnUpdate_stmnt_Click);
            // 
            // btnHeader
            // 
            this.btnHeader.Location = new System.Drawing.Point(203, 465);
            this.btnHeader.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnHeader.Name = "btnHeader";
            this.btnHeader.Size = new System.Drawing.Size(138, 40);
            this.btnHeader.TabIndex = 40;
            this.btnHeader.Text = "Whole Insert";
            this.btnHeader.UseVisualStyleBackColor = true;
            this.btnHeader.Click += new System.EventHandler(this.btnHeader_Click);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(18, 26);
            this.label23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(245, 20);
            this.label23.TabIndex = 39;
            this.label23.Text = "Transform list to IN SQL statment";
            // 
            // btnConvertSQL
            // 
            this.btnConvertSQL.Location = new System.Drawing.Point(24, 465);
            this.btnConvertSQL.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnConvertSQL.Name = "btnConvertSQL";
            this.btnConvertSQL.Size = new System.Drawing.Size(170, 40);
            this.btnConvertSQL.TabIndex = 38;
            this.btnConvertSQL.Text = "Column Convert";
            this.btnConvertSQL.UseVisualStyleBackColor = true;
            this.btnConvertSQL.Click += new System.EventHandler(this.btnConvertSQL_Click);
            // 
            // Label22
            // 
            this.Label22.AutoSize = true;
            this.Label22.Location = new System.Drawing.Point(18, 48);
            this.Label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label22.Name = "Label22";
            this.Label22.Size = new System.Drawing.Size(328, 20);
            this.Label22.TabIndex = 37;
            this.Label22.Text = "paste a column of items, click Convert to SQL";
            // 
            // rtfList
            // 
            this.rtfList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtfList.Location = new System.Drawing.Point(23, 85);
            this.rtfList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rtfList.Name = "rtfList";
            this.rtfList.Size = new System.Drawing.Size(473, 373);
            this.rtfList.TabIndex = 36;
            this.rtfList.Text = "";
            // 
            // Button3
            // 
            this.Button3.Location = new System.Drawing.Point(213, 962);
            this.Button3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Button3.Name = "Button3";
            this.Button3.Size = new System.Drawing.Size(166, 38);
            this.Button3.TabIndex = 44;
            this.Button3.Text = "Copy SQL Output";
            this.Button3.UseVisualStyleBackColor = true;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(276, 516);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(246, 47);
            this.label21.TabIndex = 43;
            this.label21.Text = "SQL Output";
            // 
            // rtfOutputSQL
            // 
            this.rtfOutputSQL.Location = new System.Drawing.Point(24, 568);
            this.rtfOutputSQL.Name = "rtfOutputSQL";
            this.rtfOutputSQL.Size = new System.Drawing.Size(722, 384);
            this.rtfOutputSQL.TabIndex = 42;
            this.rtfOutputSQL.Text = "";
            // 
            // btnRowConvert
            // 
            this.btnRowConvert.Location = new System.Drawing.Point(366, 20);
            this.btnRowConvert.Name = "btnRowConvert";
            this.btnRowConvert.Size = new System.Drawing.Size(130, 57);
            this.btnRowConvert.TabIndex = 45;
            this.btnRowConvert.Text = "Row Convert";
            this.btnRowConvert.UseVisualStyleBackColor = true;
            this.btnRowConvert.Visible = false;
            this.btnRowConvert.Click += new System.EventHandler(this.btnRowConvert_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(169)))), ((int)(((byte)(205)))));
            this.ClientSize = new System.Drawing.Size(806, 1015);
            this.Controls.Add(this.btnRowConvert);
            this.Controls.Add(this.Button3);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.rtfOutputSQL);
            this.Controls.Add(this.btnUpdate_stmnt);
            this.Controls.Add(this.btnHeader);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.btnConvertSQL);
            this.Controls.Add(this.Label22);
            this.Controls.Add(this.rtfList);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpdate_stmnt;
        private System.Windows.Forms.Button btnHeader;
        internal System.Windows.Forms.Label label23;
        internal System.Windows.Forms.Button btnConvertSQL;
        internal System.Windows.Forms.Label Label22;
        internal System.Windows.Forms.RichTextBox rtfList;
        internal System.Windows.Forms.Button Button3;
        internal System.Windows.Forms.Label label21;
        private System.Windows.Forms.RichTextBox rtfOutputSQL;
        private System.Windows.Forms.Button btnRowConvert;
    }
}

