using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeddingOutfitLibrary.Models
{
    /// <summary>
    /// Has the customer create their own account with basic information
    /// </summary>
    public class CustomerAccountProfileModel
    {
        /// <summary>
        /// The unique identifier for the customer
        /// </summary>

        public int CustomerID { get; set; }

        /// <summary>
        /// The given first name
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// The given last name
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// The given contact number
        /// </summary>
        public string ContactNumber { get; set; }

        /// <summary>
        /// The given customer email address
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// The given age
        /// </summary>
        public int Age { get; set; }

        /// <summary>
        /// The given gender
        /// </summary>
        public string Gender { get; set; }

        public CustomerAccountProfileModel()
        {

        }
    
        public CustomerAccountProfileModel(string firstName, string lastName, string contactNumber, string email, string age, string gender)
        {
            FirstName = firstName;

            LastName = lastName;

            ContactNumber = contactNumber;

            Email = email;

            int ageValue = 0;
            int.TryParse(age, out ageValue);
            Age = ageValue;

            Gender = gender;

        }
    }
}
