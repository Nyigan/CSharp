//
//Programmer: Franklin Towett
//Project: Simple form application assignment module 3
//Instructor: R Ray
//
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_Application
{
    public partial class Form1 : Form
    {
        private readonly object Me;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //form load event to display the header of the form
            //It can be done throu code or through properties window
            lblHeader.Text = "SIMPLE ADD APPLICATION";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //calcuting the input and displaying in the label
            int a, b, total;
            a = Convert.ToInt32(txtNum1.Text);
            b = Convert.ToInt32(txtNum2.Text);
            total = Convert.ToInt32(a + b);
            lblAns.Text = total.ToString();
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            //closes the application
            this.Close();
        }
    }
}
