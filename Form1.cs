using Microsoft.VisualBasic;
using System.Windows.Forms;

namespace Flags.cs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void PhilippinesRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (PhilippinesRadioButton.Checked)
                
            {
                pictureBox1.Image = Properties.Resources.Philippine_Flag;
                CountryNameLabel.Text = "Philippines";
            }
        }

        private void ColombiaRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (ColombiaRadioButton.Checked)
            {
                pictureBox1.Image = Properties.Resources.ColombiaFlag_png;
                CountryNameLabel.Text = "Colombia";
            }
        }

        private void USARadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (USARadioButton.Checked)
            {
                pictureBox1.Image = Properties.Resources.Usa_Flag;
                CountryNameLabel.Text = "USA";
            }
        }

        private void TitleCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (TitleCheckBox.Checked)
            {
                ProgrammerLabel.Text = "Title";
                
            }
            
            


        }

        private void CountryNameCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (CountryNameCheckBox.Checked)
            {
                ProgrammerLabel.Text = CountryNameLabel.Text;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
          
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void ProgrammerCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if(ProgrammerCheckBox.Checked)
            {
                ProgrammerLabel.Text = " The Programmer: John Dale";
            }
        }

        private void RadioButtonFrance_CheckedChanged(object sender, EventArgs e)
        {
            if(RadioButtonFrance.Checked)
            {
                pictureBox1.Image = Properties.Resources.France;
                CountryNameLabel.Text = "France";
            }
        }
    }
}