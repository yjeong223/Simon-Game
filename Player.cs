using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simon_Part_1
{
    public class Player
    {

        public Player()
        {
            Level = 0;
            Wins = 0; 
        }
        
        public Player(string fN, string lN, string loginN, string pw, 
            int level, int wins)
        {
            FirstName = fN;
            LastName = lN;
            LoginName = loginN;
            Password = pw;
            Level = level;
            Wins = wins;
        }
        public string FirstName { get; set;}
        public string LastName { get; set;}
        public string LoginName { get; set; }
        public string Password { get; set; }
        public int Level { get; set; }
        public int Wins { get; set; }

        //FN & LN check gates//
        public bool fNHasDigit(string s)
        {
            bool fNhasNum = false;
            int i = 0;

            while (fNhasNum == false && i < s.Length)
            {
                if (char.IsDigit(s[i]))
                {
                    fNhasNum = true;
                }
                i++;
            }

            if (fNhasNum)
            {
                ErrorForm errorform = new ErrorForm();
                errorform.showErrorType("First name cannot have numbers");
                errorform.ShowDialog();

            }
            return fNhasNum;
        }
        public bool lNameHasDigit(string s)
        {
            bool lNhasNum = false;
            int i = 0;

            while (lNhasNum == false && i < s.Length)
            {
                if (char.IsDigit(s[i]))
                {
                    lNhasNum = true;
                }
                i++;
            }

            if (lNhasNum)
            {
                ErrorForm errorform = new ErrorForm();
                errorform.showErrorType("Last name cannot have numbers");
                errorform.ShowDialog();
            }

            return lNhasNum;
        }

        // Login name check gates. //
        public bool hasWhiteSpace(string s)
        {
            int i = 0; 
            bool hasWhiteSpace = false;
            while (hasWhiteSpace == false && i < s.Length)
            {
                if (s.Contains(" "))
                {
                    hasWhiteSpace = true;
                }
                i++;
            }
            if (hasWhiteSpace)
            {
                ErrorForm errorForm = new ErrorForm();
                errorForm.showErrorType("Error: Login contains a space.");
                errorForm.ShowDialog();
            }

            return hasWhiteSpace;
        }

        public bool loginExists(string s)
        {
            bool loginExists = false;
            if (s == LoginName)
            {
                loginExists = true;
            }
            if (loginExists)
            {
                ErrorForm errorForm = new ErrorForm();
                errorForm.showErrorType("Error: Login name already exists");
                errorForm.ShowDialog();
            }

            return loginExists;
        }

        //Password check gates//

        public bool isInvalidPW(string s)
        {
            bool isInvalidPW = true;
            
            //checking the length of the pw
            bool has5Char = false;
            if (s.Length >= 5)
            {
                has5Char = true;
            }

            if (has5Char == false)
            {
                ErrorForm errorForm = new ErrorForm();
                errorForm.showErrorType("Password is too short.");
                errorForm.ShowDialog();
            }

            //checking if there at least 1 uppercase
            bool hasUpperCase = false;
            int i = 0;

            while (hasUpperCase == false && i < s.Length)
            {
                if (char.IsUpper(s[i]))
                {
                    hasUpperCase = true;
                }
                i++;
            }

            if (hasUpperCase == false)
            {
                ErrorForm errorForm = new ErrorForm();
                errorForm.showErrorType("Password must contain at least 1 uppercase letter");
                errorForm.ShowDialog();
            }

            //checking to see at least 1 lower case
            bool hasLowerCase = false;
            i = 0; 
            while (hasLowerCase == false && i < s.Length)
            {
                if (char.IsLower(s[i]))
                {
                    hasLowerCase = true;
                }
                i++;
            }

            if (hasLowerCase == false)
            {
                ErrorForm errorForm = new ErrorForm();
                errorForm.showErrorType("Password must contain at least 1 lowercase letter.");
                errorForm.ShowDialog();
            }

            //checking if it at least holds 1 #
            bool hasNum = false;
            i = 0; 
            while (hasNum == false && i < s.Length)
            {
                if (char.IsDigit(s[i]))
                {
                    hasNum = true;
                }
                i++;
            }

            if (hasNum == false)
            {
                ErrorForm errorForm = new ErrorForm();
                errorForm.showErrorType("Password must contain at least 1 number.");
                errorForm.ShowDialog();
            }

            if (has5Char == true || hasUpperCase ==true || hasLowerCase == true || hasNum == true)
            {
                isInvalidPW = false;
            }
            return isInvalidPW;
        }

    }
}
