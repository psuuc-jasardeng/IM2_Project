using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace simcard
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFile = new OpenFileDialog())
            {
                openFile.Title = "Select a Profile Picture";
                openFile.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    picProfile.Image = Image.FromFile(openFile.FileName);
                    picProfile.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sex = rdoMale.Checked ? "Male" : (rdoFemale.Checked ? "Female" : "");

            Form2 f2 = new Form2(
                mtxtMobile.Text,
                txtFirstName.Text,
                txtLastName.Text,
                sex,
                txtStatus.Text,
                dtpBirthdate.Value.ToShortDateString(),
                txtLocation.Text,
                picProfile.Image
            );
            f2.Show();
            this.Hide();
        }
    }
}
