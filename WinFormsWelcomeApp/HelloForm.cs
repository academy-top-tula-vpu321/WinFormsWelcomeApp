﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsWelcomeApp
{
    public partial class HelloForm : Form
    {
        public HelloForm(string name = "")
        {
            InitializeComponent();

            Label lblHelloLabel = new Label();
            lblHelloLabel.Text = $"Hello {name}";
            lblHelloLabel.Location = new Point(50, 50);
            lblHelloLabel.Font = new Font("Arial", 30);
            lblHelloLabel.Size = new Size(300, 100);

            this.Controls.Add(lblHelloLabel);
        }
    }
}
