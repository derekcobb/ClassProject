using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeddingOutfitLibrary;
using WeddingOutfitLibrary.Models;

namespace WeddingUI
{
    public partial class CreateCustomerAccountForm : Form
    {
        public CreateCustomerAccountForm()
        {
            InitializeComponent();
        }

        private void PlaceNumberLabel_Click(object sender, EventArgs e)
        {

        }

        private void CreateCustomerAccountButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                CustomerAccountProfileModel model = new CustomerAccountProfileModel(
                    firstNameValue.Text,
                    lastNameValue.Text,
                    contactNumberValue.Text,
                    emailValue.Text,
                    ageValue.Text,
                    genderValue.Text);

                foreach (IDataConnection db in GlobalConfig.Connections)
                {
                    db.CreateAccount(model);
                }

                firstNameValue.Text = "";
                lastNameValue.Text = "";
                contactNumberValue.Text = "";
                emailValue.Text = "";
                ageValue.Text = "0";
                genderValue.Text = "";
            }

            else
            {
                MessageBox.Show("This form has invalid information. Please check it and try again.");
            }

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void PhoneNumberLabel_Click(object sender, EventArgs e)
        {

        }

        private bool ValidateForm()
        {
            bool output = true;

            if (firstNameValue.Text.Length == 0)
            {
                output = false;
            }

            if (lastNameValue.Text.Length == 0)
            {
                output = false;
            }

            if (contactNumberValue.Text.Length == 0)
            {
                output = false;
            }

            if (emailValue.Text.Length == 0)
            {
                output = false;
            }

            int age = 0;
            bool ageValidNumber = int.TryParse(ageValue.Text, out age);

            if (ageValidNumber == false)
            {
                output = false;
            }

            if (age < 1)
            {
                output = false;
            }

            if (ageValue.Text.Length == 0)
            {
                output = false;
            }

            if (genderValue.Text.Length == 0)
            {
                output = false;
            }

            return output;
        }
    }
}
