//
//Programmer: Franklin Towett
//Project: Simple form application assignment module 3
//Instructor: R Ray
//
using System;
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
            lblHeader.Text = "SIMPLE ADD APPLICATION TO 2 DECIMAL PLACES";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //calcuting the input and displaying in the label
            decimal a, b, total;
            a = Convert.ToDecimal(txtNum1.Text);
            b = Convert.ToDecimal(txtNum2.Text);
            total = Convert.ToDecimal(a + b);
            //formatting the output to display upto 4 decimal places
            lblAns.Text = total.ToString(" 0,0.00");
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            //closes the application
            this.Close();
        }

        //Ensuring the input for the textboxes is only numeric digits
        //Remeber to reference on the events for the other textbox
        //It can be used for any textbox, just remember to reference on keyPress Events
        //on the proterties window
        private void txtNum1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            //key 8 is key enumeration for backspace and 46 for delete
            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                //MessageBox to prompt the user to enter only numeric values
                //when they accidentally type non-numeric values
                MessageBox.Show("Enter Numeric Values Only", "Add Form",
                    MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                e.Handled = true;
            }

        }
    }
}
