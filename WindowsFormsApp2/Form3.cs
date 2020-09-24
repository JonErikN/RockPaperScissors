using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        int start, end, sum;
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try //Avoid crash if user do not input two whole numbers into textboxes.
            {
                start = Convert.ToInt32(txtStart.Text);
                end = Convert.ToInt32(txtEnd.Text);
                sum = 0;// Convert.ToInt32(txtStart.Text); //resets the sum of this is not the first calculation
  
                for (int i = start; i <= end; i++) //calculates the sum using a loop of the two numbers.
                {

                    sum = sum + i;
                    
                }
                txtSum.Text = Convert.ToString(sum); //shows the result in txtSum
            }
            catch
            {
                MessageBox.Show("Please input whole numbers only."); //if an error accures a textbox will show
            }
        }
    }
}
