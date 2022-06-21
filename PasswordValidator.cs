using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace PasswordValidator
{
    public partial class PasswordValidator : UserControl
    {
        private int Length;
        private string SpecialCharsValue;
        public bool Valid { get; set; }

        public PasswordValidator()
        {
            InitializeComponent();
            Valid = false;
            Length = 12;
            TextChanged += PasswordValidator_TextChanged;
        }

        public string SpecialChars
        {
            get => SpecialCharsValue;
            set
            {
                SpecialCharsValue = value;
                Valid = ValidatePassword();
            }
        }

        
        private void PasswordValidator_TextChanged(object sender, EventArgs e)
        {
            Valid = ValidatePassword();
        }

        public int PasswordLength
        {
            get => Length;
            set
            {
                PasswordLengthLabel.Text = $"at least {value} characters";
                Length = value;
                Valid = ValidatePassword();
            }
        }

        private bool ValidatePassword()
        {
            if (Text.Length >= PasswordLength)
            {
                PasswordLengthLabel.BackColor = Color.LightGreen;
            }
            else
            {
                PasswordLengthLabel.BackColor = Color.Red;
            }

            if (Text.Any(ch => SpecialCharsValue.Contains(ch)))
            {
                PasswordSpecialCharLabel.BackColor = Color.LightGreen;
            }
            else
            {
                PasswordSpecialCharLabel.BackColor = Color.Red;
            }

            if(Text.Any(ch => char.IsUpper(ch)))
            {
                PasswordCapitalCharLabel.BackColor = Color.LightGreen;
            }
            else
            {
                PasswordCapitalCharLabel.BackColor = Color.Red;
            }

            if(Text.Any(ch => char.IsDigit(ch)))
            {
                PasswordDigitLabel.BackColor = Color.LightGreen ;
            }
            else
            {
                PasswordDigitLabel.BackColor = Color.Red;
            }
            if(Text.Any(ch => char.IsDigit(ch)))
            {
                PasswordDigitLabel.BackColor = Color.LightGreen;
            }
            else
            {
                PasswordDigitLabel.BackColor = Color.Red;
            }

            return PasswordLengthLabel.BackColor == Color.LightGreen &&
                    PasswordSpecialCharLabel.BackColor == Color.LightGreen &&
                    PasswordCapitalCharLabel.BackColor == Color.LightGreen &&
                    PasswordDigitLabel.BackColor == Color.LightGreen;
        }
    }
}
