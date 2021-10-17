using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // This code run when the Calculate button is clicked
        private void Calculate_Click(object sender, EventArgs e)
        {
            double carbs; // A double variable that will contain the amount of carbohydrates in grams entered by the user
            double fat; // A double variable that will contain the amount of fat in grams entered by the user
            double totalCalories; // A double variable that will contain the total calories in the carbohydrates and fat

            if(double.TryParse(CarbohydratesTextBox.Text, out carbs) && double.TryParse(FatTextBox.Text, out fat)) // The following code runs if the data entered in the CarbohydratesTextBox and the FatTextBox can be parsed into a numeric data type
            {
                totalCalories = FatCalories(fat) + CarbCalories(carbs); // Sets the value of the totalCalories variable to the sum of the calories in the amounts of fat and carbohydrates entered
                TotalCaloriesTextBox.Text = totalCalories.ToString(); // Sets the text of the TotalCaloriesTextBox to the totalCalories variable
            } 
            else // If the data entered in the TextBoxes cannot be parsed into a numeric data type, a MessageBox is displayed requesting that the user enter new information
            {
                MessageBox.Show("Please only enter numbers in the TextBoxes");
            }
        }

        // This method takes in an amount of fat in grams as a double and returns the number of calories in that amount. Made with help from the textbook (Gaddis, 393).
        private double FatCalories(double grams)
        {
            return grams * 9;
        }

        // This method takes in an amount of carbohydrates in grams as a double and returns the number of calories in that amount. Made with help from the textbook (Gaddis, 393).
        private double CarbCalories(double grams)
        {
            return grams * 4;
        }
    }
}

// References:
// Gaddis, T. (2020). Starting Out With Visual C#. Pearson.