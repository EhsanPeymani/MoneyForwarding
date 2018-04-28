using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MoneyForwarding
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private bool ValidateInput(string s, out double d)
        {
            if (Double.TryParse(s, out d))
            {
                return true;
            }

            return false;
        }

        private void ValidationFailed(string textBoxName, Label label)
        {
            var message = $"Invalid input for {textBoxName}";
            label.Text = message;
        }

        protected void calculateButton_Click(object sender, EventArgs e)
        {
            var bCurrentValue = ValidateInput(currentValueTextBox.Text, out double currentValue);
            if (!bCurrentValue)
            {
                ValidationFailed("current money value", ResultLabel);
                return;
            }

            var bInterest = ValidateInput(interestTextBox.Text, out double interest);
            if (!bInterest)
            {
                ValidationFailed("retun earned (interest)", ResultLabel);
                return;
            }

            var bYearNumber = ValidateInput(nYearsTextBox.Text, out double nYears);
            if (!bYearNumber)
            {
                ValidationFailed("number of years", ResultLabel);
                return;
            }

            var forwardValue = currentValue * Math.Pow((1 + interest / 100), nYears);
            var year = nYears > 1 ? "years" : "year";

            ResultLabel.Text = $"The future value of {currentValue} after {nYears} " +
                               $"{year} is equal to {forwardValue}";

        }
    }
}