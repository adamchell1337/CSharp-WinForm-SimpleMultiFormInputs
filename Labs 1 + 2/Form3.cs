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
    public partial class Form3 : Form
    {
        string firstName;
        string middleName;
        string lastName;
        string preferredTitle;
        string nameOutput;
        public Form3()
        {
            InitializeComponent();
        }

        private void btnBackToLab1_Click(object sender, EventArgs e)
        {
            Application.OpenForms["Form2"].Show();
            this.Hide();
        }

        private void btnExitApplication2_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void btnFormat1_Click(object sender, EventArgs e)
        {
            //string firstName;
           // string middleName;
            //string lastName;
            //string preferredTitle;
            //string nameOutput;

            firstName = txtBoxFirstName.Text;
            middleName = txtBoxMiddleName.Text;
            lastName = txtBoxLastName.Text;
            preferredTitle = txtBoxPreferredTitle.Text;

            nameOutput = preferredTitle + " " + firstName + " " + middleName + " " + lastName;
            lblNameOutput.Text = nameOutput;


        }

        private void btnFormat2_Click(object sender, EventArgs e)
        {
            nameOutput = firstName + " " + middleName + " " + lastName;
            lblNameOutput.Text = nameOutput;
        }

        private void btnFormat3_Click(object sender, EventArgs e)
        {
            nameOutput = firstName + " " + lastName;
            lblNameOutput.Text = nameOutput;
        }

        private void btnFormat4_Click(object sender, EventArgs e)
        {
            nameOutput = lastName + ", " + firstName + " " + middleName + ", " + preferredTitle;
            lblNameOutput.Text = nameOutput;
        }

        private void btnFormat5_Click(object sender, EventArgs e)
        {
            nameOutput = preferredTitle + " " + firstName + " " + lastName;
            lblNameOutput.Text = nameOutput;
        }

        private void btnFormat6_Click(object sender, EventArgs e)
        {
            nameOutput = preferredTitle + " " + lastName;
            lblNameOutput.Text = nameOutput;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double revenueA, revenueB, revenueC;

            try
            {
                revenueA = double.Parse(txtBoxASold.Text) * 15;
                lblA.Text = revenueA.ToString("c");

                revenueB = double.Parse(txtBoxBSold.Text) * 12;
                lblB.Text = revenueB.ToString("c");

                revenueC = double.Parse(txtBoxCSold.Text) * 9;
                lblC.Text = revenueC.ToString("c");

                double total = revenueA + revenueB + revenueC;
                lblTotal.Text = total.ToString("c");
            } catch
            {
                MessageBox.Show("Please only enter numeric values");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblA.Text = "";
            lblB.Text = "";
            lblC.Text = "";
            txtBoxASold.Text = "";
            txtBoxBSold.Text = "";
            txtBoxCSold.Text = "";
            lblTotal.Text = "";
        }

        int totalCalories;



        private void PictureBox1_Click(object sender, EventArgs e)
        {
            totalCalories = totalCalories + 6;
            lblTotalCalories.Text = totalCalories.ToString();
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            totalCalories = totalCalories + 452;
            lblTotalCalories.Text = totalCalories.ToString();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            totalCalories = totalCalories + 62;
            lblTotalCalories.Text = totalCalories.ToString();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            totalCalories = totalCalories + 95;
            lblTotalCalories.Text = totalCalories.ToString();
        }

        private void btnResetCalories_Click(object sender, EventArgs e)
        {
            totalCalories = 0;
            lblTotalCalories.Text = totalCalories.ToString();
        }
    }
}
