﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace simcard
{
    public partial class Form2: Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public Form2(string mobile, string firstName, string lastName, string sex,
                     string status, string birthdate, string location, Image profileImage)
        {
            InitializeComponent();

            lblMobileValue.Text = mobile;
            lblFirstNameValue.Text = firstName;
            lblLastNameValue.Text = lastName;
            lblSexValue.Text = sex;
            lblStatusValue.Text = status;
            lblBirthdateValue.Text = birthdate;
            lblLocationValue.Text = location;
            picProfile2.Image = profileImage;
        }
        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
