namespace Lab8
{
    partial class DateForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.monthBtn = new System.Windows.Forms.Button();
            this.dayBtn = new System.Windows.Forms.Button();
            this.yearBtn = new System.Windows.Forms.Button();
            this.monthTxt = new System.Windows.Forms.TextBox();
            this.dayTxt = new System.Windows.Forms.TextBox();
            this.yearTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dateLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Month:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Day:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Year:";
            // 
            // monthBtn
            // 
            this.monthBtn.Location = new System.Drawing.Point(162, 44);
            this.monthBtn.Name = "monthBtn";
            this.monthBtn.Size = new System.Drawing.Size(90, 23);
            this.monthBtn.TabIndex = 3;
            this.monthBtn.Text = "Update Month";
            this.monthBtn.UseVisualStyleBackColor = true;
            this.monthBtn.Click += new System.EventHandler(this.monthBtn_Click);
            // 
            // dayBtn
            // 
            this.dayBtn.Location = new System.Drawing.Point(162, 70);
            this.dayBtn.Name = "dayBtn";
            this.dayBtn.Size = new System.Drawing.Size(90, 23);
            this.dayBtn.TabIndex = 4;
            this.dayBtn.Text = "Update Day";
            this.dayBtn.UseVisualStyleBackColor = true;
            this.dayBtn.Click += new System.EventHandler(this.dayBtn_Click);
            // 
            // yearBtn
            // 
            this.yearBtn.Location = new System.Drawing.Point(162, 96);
            this.yearBtn.Name = "yearBtn";
            this.yearBtn.Size = new System.Drawing.Size(90, 23);
            this.yearBtn.TabIndex = 5;
            this.yearBtn.Text = "Update Year";
            this.yearBtn.UseVisualStyleBackColor = true;
            this.yearBtn.Click += new System.EventHandler(this.yearBtn_Click);
            // 
            // monthTxt
            // 
            this.monthTxt.Location = new System.Drawing.Point(56, 46);
            this.monthTxt.Name = "monthTxt";
            this.monthTxt.Size = new System.Drawing.Size(100, 20);
            this.monthTxt.TabIndex = 6;
            // 
            // dayTxt
            // 
            this.dayTxt.Location = new System.Drawing.Point(56, 72);
            this.dayTxt.Name = "dayTxt";
            this.dayTxt.Size = new System.Drawing.Size(100, 20);
            this.dayTxt.TabIndex = 7;
            // 
            // yearTxt
            // 
            this.yearTxt.Location = new System.Drawing.Point(56, 98);
            this.yearTxt.Name = "yearTxt";
            this.yearTxt.Size = new System.Drawing.Size(100, 20);
            this.yearTxt.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Date:";
            // 
            // dateLbl
            // 
            this.dateLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dateLbl.Location = new System.Drawing.Point(103, 9);
            this.dateLbl.Name = "dateLbl";
            this.dateLbl.Size = new System.Drawing.Size(100, 23);
            this.dateLbl.TabIndex = 10;
            // 
            // DateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 130);
            this.Controls.Add(this.dateLbl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.yearTxt);
            this.Controls.Add(this.dayTxt);
            this.Controls.Add(this.monthTxt);
            this.Controls.Add(this.yearBtn);
            this.Controls.Add(this.dayBtn);
            this.Controls.Add(this.monthBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DateForm";
            this.Text = "Date Changer";
            this.Load += new System.EventHandler(this.DateForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button monthBtn;
        private System.Windows.Forms.Button dayBtn;
        private System.Windows.Forms.Button yearBtn;
        private System.Windows.Forms.TextBox monthTxt;
        private System.Windows.Forms.TextBox dayTxt;
        private System.Windows.Forms.TextBox yearTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label dateLbl;
    }
}

