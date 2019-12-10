using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    public class Grocery : Student
    {
        private double sum;
        public Grocery(string givenFirstName, string givenUsername, string givenRoomNumber,double givenSum)
        {
            firstName = givenFirstName;
            email = givenUsername;
            roomNumber = givenRoomNumber;
            sum = givenSum;
        }
        public double GetBalance
        {
            get
            {
                return sum;
            }
        }
        public void AddToBalance(double givenSum)
        {
            sum += givenSum;
        }
        public void SubstractFromBalance(double givenSum)
        {
            sum -= givenSum;
        }
        public string GetInfo()
        {
            return roomNumber + " " + sum.ToString();
        }
    


    }
}
