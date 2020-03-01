namespace Labs_1___2
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
            this.btnHello = new System.Windows.Forms.Button();
            this.lblSelectLanguage = new System.Windows.Forms.Label();
            this.lblGoodMorning = new System.Windows.Forms.Label();
            this.btnItalian = new System.Windows.Forms.Button();
            this.btnSpanish = new System.Windows.Forms.Button();
            this.btnGerman = new System.Windows.Forms.Button();
            this.txtBoxPayRate = new System.Windows.Forms.TextBox();
            this.txtBoxHoursWorked = new System.Windows.Forms.TextBox();
            this.lblHoursWorked = new System.Windows.Forms.Label();
            this.lblPayRate = new System.Windows.Forms.Label();
            this.btnCalculateGrossPay = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblExam1 = new System.Windows.Forms.Label();
            this.lblExam2 = new System.Windows.Forms.Label();
            this.lblExam3 = new System.Windows.Forms.Label();
            this.txtBoxExam1 = new System.Windows.Forms.TextBox();
            this.txtBoxExam3 = new System.Windows.Forms.TextBox();
            this.txtBoxExam2 = new System.Windows.Forms.TextBox();
            this.lblAverageOutput = new System.Windows.Forms.Label();
            this.btnAverageExam = new System.Windows.Forms.Button();
            this.lblLab1 = new System.Windows.Forms.Label();
            this.btnGoToForm2 = new System.Windows.Forms.Button();
            this.btnExitApplication1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnHello
            // 
            this.btnHello.Location = new System.Drawing.Point(128, 72);
            this.btnHello.Name = "btnHello";
            this.btnHello.Size = new System.Drawing.Size(126, 26);
            this.btnHello.TabIndex = 0;
            this.btnHello.Text = "Display Message";
            this.btnHello.UseVisualStyleBackColor = true;
            this.btnHello.Click += new System.EventHandler(this.BtnHello_Click);
            // 
            // lblSelectLanguage
            // 
            this.lblSelectLanguage.AutoSize = true;
            this.lblSelectLanguage.Location = new System.Drawing.Point(84, 141);
            this.lblSelectLanguage.Name = "lblSelectLanguage";
            this.lblSelectLanguage.Size = new System.Drawing.Size(235, 13);
            this.lblSelectLanguage.TabIndex = 1;
            this.lblSelectLanguage.Text = "Select a language and I will say Good Morning :)";
            // 
            // lblGoodMorning
            // 
            this.lblGoodMorning.BackColor = System.Drawing.Color.Transparent;
            this.lblGoodMorning.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblGoodMorning.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGoodMorning.Location = new System.Drawing.Point(115, 166);
            this.lblGoodMorning.Name = "lblGoodMorning";
            this.lblGoodMorning.Size = new System.Drawing.Size(167, 25);
            this.lblGoodMorning.TabIndex = 2;
            this.lblGoodMorning.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnItalian
            // 
            this.btnItalian.Location = new System.Drawing.Point(54, 211);
            this.btnItalian.Name = "btnItalian";
            this.btnItalian.Size = new System.Drawing.Size(75, 23);
            this.btnItalian.TabIndex = 3;
            this.btnItalian.Text = "Italian";
            this.btnItalian.UseVisualStyleBackColor = true;
            this.btnItalian.Click += new System.EventHandler(this.BtnItalian_Click);
            // 
            // btnSpanish
            // 
            this.btnSpanish.Location = new System.Drawing.Point(162, 211);
            this.btnSpanish.Name = "btnSpanish";
            this.btnSpanish.Size = new System.Drawing.Size(75, 23);
            this.btnSpanish.TabIndex = 4;
            this.btnSpanish.Text = "Spanish";
            this.btnSpanish.UseVisualStyleBackColor = true;
            this.btnSpanish.Click += new System.EventHandler(this.BtnSpanish_Click);
            // 
            // btnGerman
            // 
            this.btnGerman.Location = new System.Drawing.Point(264, 211);
            this.btnGerman.Name = "btnGerman";
            this.btnGerman.Size = new System.Drawing.Size(75, 23);
            this.btnGerman.TabIndex = 5;
            this.btnGerman.Text = "German";
            this.btnGerman.UseVisualStyleBackColor = true;
            this.btnGerman.Click += new System.EventHandler(this.BtnGerman_Click);
            // 
            // txtBoxPayRate
            // 
            this.txtBoxPayRate.Location = new System.Drawing.Point(213, 316);
            this.txtBoxPayRate.Name = "txtBoxPayRate";
            this.txtBoxPayRate.Size = new System.Drawing.Size(100, 20);
            this.txtBoxPayRate.TabIndex = 6;
            // 
            // txtBoxHoursWorked
            // 
            this.txtBoxHoursWorked.Location = new System.Drawing.Point(213, 290);
            this.txtBoxHoursWorked.Name = "txtBoxHoursWorked";
            this.txtBoxHoursWorked.Size = new System.Drawing.Size(100, 20);
            this.txtBoxHoursWorked.TabIndex = 7;
            // 
            // lblHoursWorked
            // 
            this.lblHoursWorked.AutoSize = true;
            this.lblHoursWorked.Location = new System.Drawing.Point(70, 293);
            this.lblHoursWorked.Name = "lblHoursWorked";
            this.lblHoursWorked.Size = new System.Drawing.Size(128, 13);
            this.lblHoursWorked.TabIndex = 8;
            this.lblHoursWorked.Text = "Number of Hours Worked";
            // 
            // lblPayRate
            // 
            this.lblPayRate.AutoSize = true;
            this.lblPayRate.Location = new System.Drawing.Point(114, 319);
            this.lblPayRate.Name = "lblPayRate";
            this.lblPayRate.Size = new System.Drawing.Size(84, 13);
            this.lblPayRate.TabIndex = 9;
            this.lblPayRate.Text = "Hourly Pay Rate";
            // 
            // btnCalculateGrossPay
            // 
            this.btnCalculateGrossPay.Location = new System.Drawing.Point(117, 351);
            this.btnCalculateGrossPay.Name = "btnCalculateGrossPay";
            this.btnCalculateGrossPay.Size = new System.Drawing.Size(75, 23);
            this.btnCalculateGrossPay.TabIndex = 10;
            this.btnCalculateGrossPay.Text = "Calculate ";
            this.btnCalculateGrossPay.UseVisualStyleBackColor = true;
            this.btnCalculateGrossPay.Click += new System.EventHandler(this.BtnCalculateGrossPay_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(213, 351);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "Exit Form";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // lblExam1
            // 
            this.lblExam1.AutoSize = true;
            this.lblExam1.Location = new System.Drawing.Point(109, 430);
            this.lblExam1.Name = "lblExam1";
            this.lblExam1.Size = new System.Drawing.Size(45, 13);
            this.lblExam1.TabIndex = 12;
            this.lblExam1.Text = "Exam 1:";
            // 
            // lblExam2
            // 
            this.lblExam2.AutoSize = true;
            this.lblExam2.Location = new System.Drawing.Point(109, 462);
            this.lblExam2.Name = "lblExam2";
            this.lblExam2.Size = new System.Drawing.Size(45, 13);
            this.lblExam2.TabIndex = 13;
            this.lblExam2.Text = "Exam 2:";
            // 
            // lblExam3
            // 
            this.lblExam3.AutoSize = true;
            this.lblExam3.Location = new System.Drawing.Point(109, 492);
            this.lblExam3.Name = "lblExam3";
            this.lblExam3.Size = new System.Drawing.Size(45, 13);
            this.lblExam3.TabIndex = 14;
            this.lblExam3.Text = "Exam 3:";
            // 
            // txtBoxExam1
            // 
            this.txtBoxExam1.Location = new System.Drawing.Point(188, 427);
            this.txtBoxExam1.Name = "txtBoxExam1";
            this.txtBoxExam1.Size = new System.Drawing.Size(100, 20);
            this.txtBoxExam1.TabIndex = 15;
            // 
            // txtBoxExam3
            // 
            this.txtBoxExam3.Location = new System.Drawing.Point(188, 489);
            this.txtBoxExam3.Name = "txtBoxExam3";
            this.txtBoxExam3.Size = new System.Drawing.Size(100, 20);
            this.txtBoxExam3.TabIndex = 16;
            // 
            // txtBoxExam2
            // 
            this.txtBoxExam2.Location = new System.Drawing.Point(188, 459);
            this.txtBoxExam2.Name = "txtBoxExam2";
            this.txtBoxExam2.Size = new System.Drawing.Size(100, 20);
            this.txtBoxExam2.TabIndex = 17;
            // 
            // lblAverageOutput
            // 
            this.lblAverageOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAverageOutput.Location = new System.Drawing.Point(202, 530);
            this.lblAverageOutput.Name = "lblAverageOutput";
            this.lblAverageOutput.Size = new System.Drawing.Size(86, 20);
            this.lblAverageOutput.TabIndex = 18;
            this.lblAverageOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAverageExam
            // 
            this.btnAverageExam.Location = new System.Drawing.Point(109, 530);
            this.btnAverageExam.Name = "btnAverageExam";
            this.btnAverageExam.Size = new System.Drawing.Size(75, 20);
            this.btnAverageExam.TabIndex = 19;
            this.btnAverageExam.Text = "Calculate";
            this.btnAverageExam.UseVisualStyleBackColor = true;
            this.btnAverageExam.Click += new System.EventHandler(this.BtnAverageExam_Click);
            // 
            // lblLab1
            // 
            this.lblLab1.AutoSize = true;
            this.lblLab1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLab1.Location = new System.Drawing.Point(157, 9);
            this.lblLab1.Name = "lblLab1";
            this.lblLab1.Size = new System.Drawing.Size(66, 25);
            this.lblLab1.TabIndex = 20;
            this.lblLab1.Text = "Lab 1";
            // 
            // btnGoToForm2
            // 
            this.btnGoToForm2.Location = new System.Drawing.Point(298, 597);
            this.btnGoToForm2.Name = "btnGoToForm2";
            this.btnGoToForm2.Size = new System.Drawing.Size(75, 23);
            this.btnGoToForm2.TabIndex = 21;
            this.btnGoToForm2.Text = "Next Lab";
            this.btnGoToForm2.UseVisualStyleBackColor = true;
            this.btnGoToForm2.Click += new System.EventHandler(this.BtnGoToForm2_Click);
            // 
            // btnExitApplication1
            // 
            this.btnExitApplication1.Location = new System.Drawing.Point(298, 9);
            this.btnExitApplication1.Name = "btnExitApplication1";
            this.btnExitApplication1.Size = new System.Drawing.Size(75, 23);
            this.btnExitApplication1.TabIndex = 22;
            this.btnExitApplication1.Text = "Exit";
            this.btnExitApplication1.UseVisualStyleBackColor = true;
            this.btnExitApplication1.Click += new System.EventHandler(this.BtnExitApplication1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 632);
            this.Controls.Add(this.btnExitApplication1);
            this.Controls.Add(this.btnGoToForm2);
            this.Controls.Add(this.lblLab1);
            this.Controls.Add(this.btnAverageExam);
            this.Controls.Add(this.lblAverageOutput);
            this.Controls.Add(this.txtBoxExam2);
            this.Controls.Add(this.txtBoxExam3);
            this.Controls.Add(this.txtBoxExam1);
            this.Controls.Add(this.lblExam3);
            this.Controls.Add(this.lblExam2);
            this.Controls.Add(this.lblExam1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalculateGrossPay);
            this.Controls.Add(this.lblPayRate);
            this.Controls.Add(this.lblHoursWorked);
            this.Controls.Add(this.txtBoxHoursWorked);
            this.Controls.Add(this.txtBoxPayRate);
            this.Controls.Add(this.btnGerman);
            this.Controls.Add(this.btnSpanish);
            this.Controls.Add(this.btnItalian);
            this.Controls.Add(this.lblGoodMorning);
            this.Controls.Add(this.lblSelectLanguage);
            this.Controls.Add(this.btnHello);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHello;
        private System.Windows.Forms.Label lblSelectLanguage;
        private System.Windows.Forms.Label lblGoodMorning;
        private System.Windows.Forms.Button btnItalian;
        private System.Windows.Forms.Button btnSpanish;
        private System.Windows.Forms.Button btnGerman;
        private System.Windows.Forms.TextBox txtBoxPayRate;
        private System.Windows.Forms.TextBox txtBoxHoursWorked;
        private System.Windows.Forms.Label lblHoursWorked;
        private System.Windows.Forms.Label lblPayRate;
        private System.Windows.Forms.Button btnCalculateGrossPay;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblExam1;
        private System.Windows.Forms.Label lblExam2;
        private System.Windows.Forms.Label lblExam3;
        private System.Windows.Forms.TextBox txtBoxExam1;
        private System.Windows.Forms.TextBox txtBoxExam3;
        private System.Windows.Forms.TextBox txtBoxExam2;
        private System.Windows.Forms.Label lblAverageOutput;
        private System.Windows.Forms.Button btnAverageExam;
        private System.Windows.Forms.Label lblLab1;
        private System.Windows.Forms.Button btnGoToForm2;
        private System.Windows.Forms.Button btnExitApplication1;
    }
}

