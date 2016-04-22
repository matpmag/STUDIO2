using System;

namespace Studio2RotaControl
{
    public static class classSessionStorage
    {
        #region Fields

        public static int PermLevel = 0;
        public static string Username = "default";

        #endregion Fields
    }

    public class userInMemory
    {
        #region Fields

        public bool UserSet = false;

        #endregion Fields

        #region Constructors

        public userInMemory(string[] valueArray)
        {
            StaffID = int.Parse(valueArray[0]);
            Password = valueArray[1];
            PermLevel = int.Parse(valueArray[2]);
            Forename = valueArray[3];
            Surname = valueArray[4];
            Title = valueArray[5];
            Gender = valueArray[6].ToCharArray()[0];
            DOB = DateTime.Parse(valueArray[7]);
            Role = valueArray[8];
            EmploymentBasis = valueArray[9];
            Address1 = valueArray[10];
            Address2 = valueArray[11];
            City = valueArray[12];
            Postcode = valueArray[13];
            ContactNumber = valueArray[14];
            Email = valueArray[15];
            UserSet = true;
        }

        #endregion Constructors

        #region Properties

        public string Address1 { get; private set; }
        public string Address2 { get; private set; }
        public string City { get; private set; }
        public string ContactNumber { get; private set; }
        public DateTime DOB { get; private set; }
        public string Email { get; private set; }
        public string EmploymentBasis { get; private set; }
        public string Forename { get; private set; }
        public char Gender { get; private set; }
        public int PermLevel { get; private set; }
        public string Postcode { get; private set; }
        public string Role { get; private set; }
        public int StaffID { get; private set; }
        public string Surname { get; private set; }
        public string Title { get; private set; }
        private string Password { get; set; }

        #endregion Properties
    }
}