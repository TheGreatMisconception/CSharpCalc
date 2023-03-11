using SharpCalculating.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SharpCalculating
{
    public partial class SharpCalc : Form
    {
        private Meth Meth = new Meth();
        private About About = new About();
        public SharpCalc()
        {
            InitializeComponent();
        }

        private void SharpCalc_Load(object sender, EventArgs e)
        {
        }

        private void MenuItem_view_Click(object sender, EventArgs e)
        {

        }

        // update calc display
        private void update_TextBox_display() {
            this.textBox_display.Text = this.Meth.returnEquation();
        }

        private void button_basic_arithmetic_Click(object sender, EventArgs e)
        {
            string value = (sender as Button).Text;
            string current_equation = this.Meth.returnEquation();
            if (Convert.ToString(current_equation[current_equation.Length]) == "*" || Convert.ToString(current_equation[current_equation.Length]) == "/") {
                return;
            }
            this.Meth.addNumeralItem(value);
            update_TextBox_display();
        }


        private void debug(string debugstring) {
            MessageBox.Show(debugstring);        
        }

        // Add the corresponding number to the meth object
        private void number_Click(object sender, EventArgs e)
        {
            /*
             * would only make sense if you want to translate the buttons
             * 
            // Get name of pressed button
            string value = (sender as Button).Name;
            debug(value);
            this.meth.addNumeralItem(value);
            debug(this.meth.returnEquation());
            */

            // Use the Text of the button as value 
            string value = (sender as Button).Text;
            this.Meth.addNumeralItem(value);
            update_TextBox_display();
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            this.Meth.setEquation("");
            update_TextBox_display();
        }

        private void button_remove_Click(object sender, EventArgs e)
        {
            string equation = this.Meth.returnEquation();
            if (equation.Length > 0)
            {
                this.Meth.setEquation(this.Meth.returnEquation().Substring(0, equation.Length-1));
                update_TextBox_display();
            }
        }

        private void button_solve_Click(object sender, EventArgs e)
        {
            this.Meth.solve();
            update_TextBox_display();
        }


        // Exit the application
        private void Hambuger_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        // Show the About dialog in another window
        private void Hamburger_About_Click(object sender, EventArgs e)
        {
            About.Show();
        }

        // some spicy source - Get the help dialog
        private void Hamburger_Help_Clicked(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://shattereddisk.github.io/rickroll/rickroll.mp4");
        }

        private void view_standard_Click(object sender, EventArgs e)
        {
            // Hide all the buttons from the scientific view



            // Show all the Buttons for the basic view
            this.button_clear.Show();
            this.button_remove.Show();
            this.button_one.Show();
            this.button_two.Show();
            this.button_three.Show();
            this.button_four.Show();
            this.button_five.Show();
            this.button_six.Show();
            this.button_seven.Show();
            this.button_eight.Show();
            this.button_nine.Show();
            this.button_zero.Show();
            this.button_plus.Show();
            this.button_minus.Show();
            this.button_multiplication.Show();
            this.button_division.Show();
            this.button_solve.Show();
            // set the right size
            this.Size = this.MinimumSize;

        }

        private void view_scientific_Click(object sender, EventArgs e)
        {
            // enlarge the window for more buttons

            // Hide all the Buttons from the scientific view
            this.button_clear.Hide();
            this.button_remove.Hide();
            this.button_one.Hide();
            this.button_two.Hide();
            this.button_three.Hide();
            this.button_four.Hide();
            this.button_five.Hide();
            this.button_six.Hide();
            this.button_seven.Hide();
            this.button_eight.Hide();
            this.button_nine.Hide();
            this.button_zero.Hide();
            this.button_plus.Hide();
            this.button_minus.Hide();
            this.button_multiplication.Hide();
            this.button_division.Hide();
            this.button_solve.Hide();
            this.button_root.Hide();
        }
    }
}
