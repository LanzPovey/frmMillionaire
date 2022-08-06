//NAME: Lanz Povey
//DATE: May 27th 2016
//TEACHER: Mr. Wachs
//ASSIGNEMENT: Computer Science 20S, Unit 5: Looping. Question 1.
//PURPOSE: This program is used to help people find out wether or not they'll become a 
millionaire and if so, how long it will take to become based on the interest being
applied to the money in their bank account.
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace _5thUnit02Question1
{
    public partial class frmMillionaire : Form
    {
        public frmMillionaire()
        {
            InitializeComponent();
        }
        private void btnYearsGap_Click_1(object sender, EventArgs e)
        {
            const int million = 1000000;
            double balance = Convert.ToDouble(txbAccountBalance.Text), year = 0;
            // This needs to convert to a Double, since the user could put in 0.01 as 
            their account balance.
        const double INTEREST = 0.07;
            // The INTEREST variable doesn't need to be Global, since it's only being 
            used in this code.
        if (txbAccountBalance.Text == "") lblYear.Text = "Please type a number value 
       into the textbox!";
 else if (balance >= million) lblYear.Text = "WOAH! You're already a 
       millionaire!";
 else if (balance <= 0) lblYear.Text = "You will NEVER be a millionaire!";
            else
            {
                while (balance < million)
                {
                    balance += (balance * INTEREST);
                    year += 1;
                }
                lblYear.Text = "In " + Convert.ToString(year) + " years you will be a 
           MILLIONAIRE!";
            }
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            if (txbAccountBalance.Text != "") txbAccountBalance.Text = "";
            if (lblYear.Text != "") lblYear.Text = "";
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application
           .Exit();

        }

    }
}