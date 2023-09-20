using System.Text.RegularExpressions;

namespace WinFormsAppIDValidator
{
    public partial class IDValidatorForm : Form
    {
        public IDValidatorForm()
        {
            InitializeComponent();
        }

        public static bool ValidateSAID(string idNumber)
        {
            idNumber = idNumber.Replace(" ", "").Replace("-", "");

            if (idNumber.Length != 13)
                return false;

            if (!Regex.IsMatch(idNumber, @"^\d+$"))
                return false;

            string birthdateStr = idNumber.Substring(0, 6);
            if (!DateTime.TryParseExact(birthdateStr, "yyMMdd", null, System.Globalization.DateTimeStyles.None, out _))
                return false;

            // Calculate the checksum
            int sum = 0;
            for (int i = 0; i < 12; i++)
            {
                int digit = int.Parse(idNumber[i].ToString());
                if (i % 2 == 0)
                    sum += digit;
                else
                    sum += digit * 2 >= 10 ? digit * 2 - 9 : digit * 2;
            }

            int checksum = (10 - (sum % 10)) % 10;

            int lastDigit = int.Parse(idNumber[12].ToString());
            return checksum == lastDigit;
        }

        private void btnValidate_Click_1(object sender, EventArgs e)
        {
            string userIDNumber = txtIDNumber.Text;
            if(!string.IsNullOrEmpty(userIDNumber) && userIDNumber.Length == 13)
            {
                if(ValidateSAID(userIDNumber))
                    MessageBox.Show($"ID Number is valid {userIDNumber}");
                else
                    MessageBox.Show($"Invalid ID Number {userIDNumber}");
               
            }
            else
            {
                MessageBox.Show($"Invalid ID Number {userIDNumber}");
            }
        }
    }
}