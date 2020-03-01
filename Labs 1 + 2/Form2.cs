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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)
        {

        }
        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();

        }

        private void BtnBackToLab1_Click(object sender, EventArgs e)
        {
            Application.OpenForms["Form1"].Show();
            this.Hide();
        }

        private void PicBoxJapan_Click(object sender, EventArgs e)
        {
            lblCountryName.Text = "Japan";
        }

        private void PicBoxPortugal_Click(object sender, EventArgs e)
        {
            lblCountryName.Text = "Portugal";
        }

        private void PicBoxItaly_Click(object sender, EventArgs e)
        {
            lblCountryName.Text = "Italy";
        }

        private void BtnSinister_Click(object sender, EventArgs e)
        {
            lblTranslationOutput.Text = "Left";
        }

        private void BtnMedium_Click(object sender, EventArgs e)
        {
            lblTranslationOutput.Text = "Centre";
        }

        private void BtnDexter_Click(object sender, EventArgs e)
        {
            lblTranslationOutput.Text = "Right";
        }

        private void PicBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("One");
        }

        private void PicBox2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Two");
        }

        private void PicBox3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Three");
        }

        private void PicBox4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Four");
        }

        private void PicBox5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Five");
        }

        private void PicBoxNineClubs_Click(object sender, EventArgs e)
        {
            lblCardName.Text = "Nine of Clubs";
        }

        private void PicBoxAceHearts_Click(object sender, EventArgs e)
        {
            lblCardName.Text = "Ace of Hearts";
        }

        private void PicBoxJackDiamonds_Click(object sender, EventArgs e)
        {
            lblCardName.Text = "Jack of Diamonds";
        }

        private void PicBoxTwoClubs_Click(object sender, EventArgs e)
        {
            lblCardName.Text = "Two of Clubs";
        }

        private void PicBoxSevenDiamonds_Click(object sender, EventArgs e)
        {
            lblCardName.Text = "Seven of Diamonds";
        }

        private void btnGoToForm3_Click(object sender, EventArgs e)
        {
            Form3 frm = new Form3();
            frm.Show();
            this.Hide();
        }
    }
}
