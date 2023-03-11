using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SharpCalculating.Resources
{

    // Who doesn't like meth?
    internal class Meth
    {
        private string equation = "";

        // Constructor method
        public Meth() { }

        // Add a numeral item to the equation
        public void addNumeralItem(string item) 
        {
            if (equation.Length < 22) {
                this.equation += item;
            }
            

            /*
             * 
             * only makes sense if you want to translate the text on the buttons
             * 
            // Array for converting the string into a number
            string[] conversion = {"button_zero", "button_one", "button_two", "button_three", "button_four", "button_five", "button_eight", "button_nine" };
            for (int index  = 0; index < conversion.Length; index++) { 
                if (conversion[index] == item) {
                    this.equation += index + 1;
                    break;
                }
            }
            */

        }

        public void addArithmeticItem(string item) 
        {
            if (equation.Length < 22)
            {
                this.equation += item;
            }
        }

        // Get the full equation
        public string returnEquation() {
            return this.equation;
        }

        // Overwrite the saved equation
        public void setEquation(string equation)
        {
            this.equation = equation;
        }


        private int count_occurences(char c, char[] c_array) {
            int count;
            count = 0;
            for (int i = 0; i < c_array.Length; i++) {
                if (c_array[i] == c) {
                    count++;
                }
            }
            return count;
        }
        
        // solves the saved equation
        public string solve() {
            bool solved;
            int run;
            int multiplication;
            int division;
            int addition;
            int substraction;
            char[] equation_array = this.equation.ToCharArray();
            multiplication = count_occurences(Convert.ToChar("*"),equation_array);
            division = count_occurences(Convert.ToChar("/"), equation_array);
            addition = count_occurences(Convert.ToChar("+"), equation_array);
            substraction = count_occurences(Convert.ToChar("-"), equation_array);;
            int[] punkt = new int[multiplication+division];
            int[] strich = new int[addition+substraction];
            solved = false;
            run = 0;
            while (!solved) {
                if (run == 0) {
                    int punkt_index = 0;
                    int strich_index = 0;
                    for (int n = 0; n < equation_array.Length; n++) {
                        if (equation_array[n] == Convert.ToChar("*") || equation_array[n] == Convert.ToChar("/"))
                        {
                            punkt[punkt_index] = n;
                        }
                        else if (equation_array[n] == Convert.ToChar("+") || equation_array[n] == Convert.ToChar("-")) {
                            strich[strich_index] = n;
                        }

                    }
                
                }
                for (int n = 0; n < punkt.Length; n++) { 
                    
                
                }



            }


            return this.equation;
        }
    }
}
