using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddingMachine
{
    public partial class AddingMachine : Form
    {
        //creates the array
        
        double[] AddingMachineArray = new double[10];

        public AddingMachine()
        {
            InitializeComponent();
        }


        
        int i = 0;
        //this variable handles the placement of elements within the array
        string PreviousNumbers = "";
        //setting the previous numbers string as a variable helps things along smoothly when you reset the array
        double total = 0;
        //setting the running total as a variable helps things along smoothly when you reset the array

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            textBoxAddNumber.Focus();
            //sets the focus immediately to the text box when the form loads
            try
            {            
                if (Double.Parse(textBoxAddNumber.Text) > 0)
                {                
                    AddingMachineArray[i] = Double.Parse(textBoxAddNumber.Text);
                    //sets the value of the first element in the array to whatever is in the input box
                    total = total + AddingMachineArray[i];
                    //puts the sum of the array into a variable
                    PreviousNumbers = PreviousNumbers + "+ " + AddingMachineArray[i].ToString() + ", " + System.Environment.NewLine;
                    //adds the current number to the list of previous numbers                    
                    labelAddedNumbers.Text = PreviousNumbers;
                    //prints the list
                    labelRunningTotal.Text = total.ToString();    
                    //prints the total to the textbox
                    textBoxAddNumber.Text = "";
                    //blanks out the text box once you hit the button
                    i++;
                    //shifts the position of the array foreward by one. 
                }
                else
                {
                    //error handling if the number is not positive
                    MessageBox.Show("Please only use positive numbers!");
                    textBoxAddNumber.Text = "";
                }

                if (i > (AddingMachineArray.Length - 1))
                {
                    //when you reach the end of the array, it resets it and starts from the beginning 
                    //all while mantaining your total
                    total = AddingMachineArray.Sum();
                    Array.Clear(AddingMachineArray, 0, AddingMachineArray.Length);
                    i = 0;

                }
            }
            catch (Exception)
            {
                //error handling for everything else
                MessageBox.Show("Numbers only, please.");
                textBoxAddNumber.Text = "";
            }
        }
        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxAddNumber.Focus();
            //sets the focus immediately to the text box 

            //this resets everything
            total = 0;
            i = 0;
            PreviousNumbers = "";
            labelAddedNumbers.Text = "";
            labelRunningTotal.Text = "";
            Array.Clear(AddingMachineArray, 0, AddingMachineArray.Length);
            textBoxAddNumber.Text = "";
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            textBoxAddNumber.Focus();
            //sets the focus immediately to the text box 
            try
            {

            if (Double.Parse(textBoxAddNumber.Text) > 0)
            {

                AddingMachineArray[i] = Double.Parse(textBoxAddNumber.Text);
                //sets the value of the first element in the array to whatever is in the input box
                total = total * AddingMachineArray[i];
                //multiplies the running total by the value within the input box
                PreviousNumbers = PreviousNumbers + "✕ " + AddingMachineArray[i].ToString() + ", " + System.Environment.NewLine;
                //adds the current number to the list of previous numbers                    
                labelAddedNumbers.Text = PreviousNumbers;
                //prints the list
                labelRunningTotal.Text = total.ToString();
                //prints the total to the textbox
                textBoxAddNumber.Text = "";
                //blanks out the text box once you hit the button
                i++;
                //shifts the position of the array foreward by one. 
            }
            else
            {
                //error handling if the number is not positive
                MessageBox.Show("Please only use positive numbers!");
                textBoxAddNumber.Text = "";
            }

            }
            catch
            {
                //error handling for everything else
                MessageBox.Show("Numbers only, please.");
                textBoxAddNumber.Text = "";
            }
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            textBoxAddNumber.Focus();
            //sets the focus immediately to the text box 
            try
            {

                if (Double.Parse(textBoxAddNumber.Text) > 0)
                {

                    AddingMachineArray[i] = Double.Parse(textBoxAddNumber.Text);
                    //sets the value of the first element in the array to whatever is in the input box
                    total = total / AddingMachineArray[i];
                    //multiplies the running total by the value within the input box
                    PreviousNumbers = PreviousNumbers + "÷ " + AddingMachineArray[i].ToString() + ", " + System.Environment.NewLine;
                    //adds the current number to the list of previous numbers                    
                    labelAddedNumbers.Text = PreviousNumbers;
                    //prints the list
                    labelRunningTotal.Text = total.ToString();
                    //prints the total to the textbox
                    textBoxAddNumber.Text = "";
                    //blanks out the text box once you hit the button
                    i++;
                    //shifts the position of the array foreward by one. 
                }
                else
                {
                    //error handling if the number is not positive
                    MessageBox.Show("Please only use positive numbers!");
                    textBoxAddNumber.Text = "";
                }

            }
            catch
            {
                //error handling for everything else
                MessageBox.Show("Numbers only, please.");
                textBoxAddNumber.Text = "";
            }
        }

        private void buttonSubtract_Click(object sender, EventArgs e)
        {
            
                textBoxAddNumber.Focus();
                //sets the focus immediately to the text box 
                try
                {

                    if (Double.Parse(textBoxAddNumber.Text) > 0)
                    {

                        AddingMachineArray[i] = Double.Parse(textBoxAddNumber.Text);
                        //sets the value of the first element in the array to whatever is in the input box
                        total = total - AddingMachineArray[i];
                        //subtracts the value from the running total
                        PreviousNumbers = PreviousNumbers + "- " + AddingMachineArray[i].ToString() + ", " + System.Environment.NewLine;
                        //adds the current number to the list of previous numbers                    
                        labelAddedNumbers.Text = PreviousNumbers;
                        //prints the list
                        labelRunningTotal.Text = total.ToString();
                        //prints the total to the textbox
                        textBoxAddNumber.Text = "";
                        //blanks out the text box once you hit the button
                        i++;
                        //shifts the position of the array foreward by one. 
                    }
                    else
                    {
                        //error handling if the number is not positive
                        MessageBox.Show("Please only use positive numbers!");
                        textBoxAddNumber.Text = "";
                    }

                }
                catch
                {
                    //error handling for everything else
                    MessageBox.Show("Numbers only, please.");
                    textBoxAddNumber.Text = "";
                }
            }
    }
}
