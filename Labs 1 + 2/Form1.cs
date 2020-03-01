using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labs_1___2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnHello_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello World");
        }

        private void BtnItalian_Click(object sender, EventArgs e)
        {
            lblGoodMorning.Text = "Buongiorno";
        }

        private void BtnSpanish_Click(object sender, EventArgs e)
        {
            lblGoodMorning.Text = "Buenos Dias";
        }

        private void BtnGerman_Click(object sender, EventArgs e)
        {
            lblGoodMorning.Text = "Guten Morgen";
        }

        private void BtnCalculateGrossPay_Click(object sender, EventArgs e)
        {
            //Declare Variables
            int hoursWorked;
            double payRate, GrossPay;
            try
            {
                //Get input by the user
                hoursWorked = int.Parse(txtBoxHoursWorked.Text);
                payRate = double.Parse(txtBoxPayRate.Text);

                //Calculate Gross Pay
                GrossPay = (hoursWorked * payRate);

                //Display gross pay message box
                MessageBox.Show("The gross pay is " + GrossPay.ToString("c"));

            } catch
            {
                MessageBox.Show("Please only enter numeric values");
            }

            
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            //Close Form
            this.Close();
        }

        private void BtnAverageExam_Click(object sender, EventArgs e)
        {
            //Delcare Variables
            int examResult1 = 0;
            int examResult2 = 0;
            int examResult3 = 0;
            double examAverage;

            //Store User Input
            try
            {
               examResult1 = int.Parse(txtBoxExam1.Text);
               examResult2 = int.Parse(txtBoxExam2.Text);
               examResult3 = int.Parse(txtBoxExam3.Text);
            }
            catch {
                MessageBox.Show("Please only enter Integer Exam Results");

            }
            //Calculate Average
            examAverage = (examResult1 + examResult2 + examResult3) / 3;

            //Output Average
            lblAverageOutput.Text = examAverage.ToString();

        }

        private void BtnGoToForm2_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();
            this.Hide();

        }

        private void BtnExitApplication1_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }
    }
}
