using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PrimeNumberDemo
{
    public partial class PrimeNumberForm : Form
    {
        public PrimeNumberForm()
        {
            InitializeComponent();
        }

        private void CheckButton_Click(object sender, EventArgs e)
        {
            int result = 0;
            bool isNumber = Int32.TryParse(PrimeNumberTextBox.Text, out result);
            if(isNumber)
            {
                bool isPrime = true;
                for(int  i = 2; i <= result / 2; i++)
                {
                    if (result % i == 0)
                        isPrime = false;
                }
                if (isPrime)
                {
                    this.BackColor = Color.Green;
                }
                else
                {
                    this.BackColor = Color.Red;
                }
            }
            else
            {
                this.BackColor = Color.Yellow;
                MessageBox.Show("Nu s-a introdus un numar intreg!");
            }
        }

        private void PrimeNumberTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
