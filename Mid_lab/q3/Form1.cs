using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q2CCMidlab
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Password generation logic
            string firstNameI = "Yusra";
            string lastNameI = "Arshad";

            string uppercaseChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string digits = "0123456789";
            string specialChars = "!@#$%^&*";

            Random random = new Random();
            StringBuilder password = new StringBuilder();

            // Ensure at least one uppercase character
            password.Append(uppercaseChars[random.Next(uppercaseChars.Length)]);

            
            password.Append("5"); 
            for (int i = 0; i < 2; i++)
            {
                password.Append(digits[random.Next(digits.Length)]);
            }
            password.Append("4"); 

            // Ensure at least 2 special characters
            for (int i = 0; i < 2; i++)
            {
                password.Append(specialChars[random.Next(specialChars.Length)]);
            }

            // Add initials of first and last name
            password.Append(firstNameI[0]);
            password.Append(lastNameI[0]);

            
            while (password.Length <= 16)
            {
                char randomChar = uppercaseChars[random.Next(uppercaseChars.Length)];
                password.Append(randomChar);
            }

            // Display the generated password in the text box
            textBox1.Text = password.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
