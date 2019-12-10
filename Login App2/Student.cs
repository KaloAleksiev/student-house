using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    public class Student
    {
        protected string firstName;
        private string secondName;
        protected string roomNumber;
        protected string email;
        private string password;

        public Student()
        {

        }
        public Student(string givenFirstName, string givenSecondName, string givenRoomNumber, string givenEmail, string givenPassword)
        {
            firstName = givenFirstName;
            secondName = givenSecondName;
            roomNumber = givenRoomNumber;
            email = givenEmail;
            password = givenPassword;
        }

        public string GetRoomNumber()
        {
            return roomNumber;
        }
        public string GetName()
        {
            return email;
        }
        public string GetPassword()
        {
            return password;
        }
        public string GetFirstName()
        {
            return firstName;
        }
        public string GetUsername()
        {
            return email;
        }
    }
}
