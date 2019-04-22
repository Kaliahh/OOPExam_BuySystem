using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExam_BuySystem
{
    class User : IComparable<User>
    {
        int ID { get; }
        string FirstName { get; }
        string LastName { get; }
        string Username { get; }
        string Email { get; }
        double Balance { get; set; }

        public User(int id, string firstName, string lastName, string username, string email, double balance)
        {
            ID = id;
            FirstName = firstName;
            LastName = lastName;

            if (CheckUsername(username))
            {
                Username = username;
            }

            else
            {
                throw new UserNameException("Username not valid, can only contain the numbers 0-9, small letters and underscore _");
            }

            if (CheckEmail(email))
            {
                Email = email;
            }

            else
            {
                throw new EmailException("Email not valid");
            }

            Balance = balance;
        }

        // TODO: Implement CheckEmail
        private bool CheckEmail(string email)
        {
            return true;
        }

        // TODO: Implement CheckUsername
        private bool CheckUsername(string username)
        {
            return true;
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
        //public override bool Equals(object obj)
        //{
        //    //       
        //    // See the full list of guidelines at
        //    //   http://go.microsoft.com/fwlink/?LinkID=85237  
        //    // and also the guidance for operator== at
        //    //   http://go.microsoft.com/fwlink/?LinkId=85238
        //    //

        //    if (obj == null || GetType() != obj.GetType())
        //    {
        //        return false;
        //    }

        //    // TODO: write your implementation of Equals() here
        //    throw new NotImplementedException();
        //    //return base.Equals(obj);
        //}

        //// override object.GetHashCode
        //public override int GetHashCode()
        //{
        //    // TODO: write your implementation of GetHashCode() here
        //    throw new NotImplementedException();
        //    //return base.GetHashCode();
        //}
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
}
