using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System.Threading.Tasks;

namespace OOPExam_BuySystem
{
    class User : IComparable<User>
    {
        public int ID { get; }
        public string FirstName { get; }
        public string LastName { get; }
        public string Username { get; }
        public string Email { get; }
        public double Balance { get; set; }

        public User(int id, string firstName, string lastName, string username, string email, double balance)
        {
            ID = id;
            Balance = balance;

            if (firstName != null)
            {
                FirstName = firstName;
            }

            else
            {
                throw new FirstNameException("User first name was null");
            }


            if (lastName != null)
            {
                LastName = lastName;
            }

            else
            {
                throw new LastNameException("User last name was null");
            }


            if (IsValidUsername(username))
            {
                Username = username;
            }

            else
            {
                throw new UserNameException("Username not valid, can only contain the numbers 0-9, small letters and underscore _");
            }


            if (IsValidEmail(email))
            {
                Email = email;
            }

            else
            {
                throw new EmailException("User email not valid");
            }
        }

        private bool IsValidEmail(string email)
        {
            // Består af local-part@domain

            // local-part må indeholde a-z, A-Z, 0-9 og . _ -

            // domain må indeholde a-z, A-Z, 0-9 og . - 
            // domain må ikke starte eller slutte med bindestreg/punktum. domain skal indeholde mindst et punktum

            // Eksempel på gyldig mail: eksempel@domain.dk
            // Eksempel på ugyldig mail: eksempel(2)@-mit_domain.dk


            return Regex.IsMatch(email, @"^([a-zA-Z0-9._-]+)@[^.-]([a-zA-Z0-9.-]+)[^.-]$") && email.Contains(".");
        }

        private bool IsValidUsername(string username)
        {
            // Må indeholde 0-9, a-z og _

            return Regex.IsMatch(username, @"^[a-z0-9_]+$");
        }

        public override string ToString()
        {
            return string.Format($"{FirstName} {LastName} ({Email})");
        }

        public int CompareTo(User other)
        {
            return ID.CompareTo(other.ID);
        }

        // override object.Equals
        public override bool Equals(object obj)
        {
            //       
            // See the full list of guidelines at
            //   http://go.microsoft.com/fwlink/?LinkID=85237  
            // and also the guidance for operator== at
            //   http://go.microsoft.com/fwlink/?LinkId=85238
            //

            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            // TODO: write your implementation of Equals() here
            throw new NotImplementedException();
            //return base.Equals(obj);
        }

        // override object.GetHashCode
        public override int GetHashCode()
        {
            // TODO: write your implementation of GetHashCode() here
            throw new NotImplementedException();
            //return base.GetHashCode();
        }
    }

    #region Exceptions
    [Serializable]
    internal class FirstNameException : Exception
    {
        public FirstNameException()
        {
        }

        public FirstNameException(string message) : base(message)
        {
        }

        public FirstNameException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected FirstNameException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }

    [Serializable]
    internal class LastNameException : Exception
    {
        public LastNameException()
        {
        }

        public LastNameException(string message) : base(message)
        {
        }

        public LastNameException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected LastNameException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }

    class EmailException : Exception
    {
        public EmailException() : base() { }
        public EmailException(string s) : base(s) { }
        public EmailException(string s, Exception ex) : base(s, ex) { }
    }

    class UserNameException : Exception
    {
        public UserNameException() : base() { }
        public UserNameException(string s) : base(s) { }
        public UserNameException(string s, Exception ex) : base(s, ex) { }
    }
    #endregion
}
