﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaxonScout
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            this.dateTimePicker1.Value = dt;
            this.dateTimePicker2.Value = dt;
        }
        
        private void button1_Click(object sender, EventArgs e)
        {   // Save button; send the data to parent form;
            Form1 parent = (Form1)this.Owner;
            /*
             * 
             *  code that returns data to main form.
             *  i have to decide in which form i will store it.
             *  
             *  i could pass it on as individual strings but a list
             *  seems more logical and easier to deal with.
             * 
             */
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {   // Cancel button
            this.Close();
        }
        
        private void dateTimePicker1_CloseUp(object sender, EventArgs e)
        {
            textBox2.Text = dateTimePicker1.Value.ToString("dd-MM-yyyy");
        }

        private void dateTimePicker2_CloseUp(object sender, EventArgs e)
        {
            textBox7.Text = dateTimePicker2.Value.ToString("dd-MM-yyyy");
        }
    }
}
