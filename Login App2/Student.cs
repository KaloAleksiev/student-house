using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    public class Student
    {
        protected int id;
        protected string firstName;
        private string secondName;
        protected string roomNumber;
        protected string email;

        public Student() {
        
        }
        public Student(int givenId, string givenFirstName, string givenSecondName, string givenRoomNumber, string givenEmail)
        {
            id = givenId;
            firstName = givenFirstName;
            secondName = givenSecondName;
            roomNumber = givenRoomNumber;
            email = givenEmail;
        }

        public int GetId()
        {
            return id;
        }
        public string GetRoomNumber()
        {
            return roomNumber;
        }
        public string GetName()
        {
            return email;
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
