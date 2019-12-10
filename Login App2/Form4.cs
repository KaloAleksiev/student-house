using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project1
{
    public partial class Groceries : Form
    {
        int keepIndex;
        StudentHouse studentHouse;
        GroceryList groceryList;
        public Groceries(StudentHouse studentHouse, int index, GroceryList groceryList)
        {
            InitializeComponent();
            this.studentHouse = studentHouse;
            lblStudentHouse.Text = "Hello, " + studentHouse.GetStudent(index).GetFirstName();
            lblPage.Text = "You are currently on the Groceries page.";

            keepIndex = index;
            this.groceryList = groceryList;
            initiateListBox();
        }
        void initiateListBox()
        {
            foreach (Grocery grocery in groceryList.GetGroceries())
            {
                clbGroceries.Items.Add(grocery.GetFirstName() + " (Room: " + grocery.GetRoomNumber() + ") owes you: " + grocery.GetBalance);
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string items = rtbItems.Text;
            double sum = -1;
            if (Double.TryParse(tbPrice.Text, out sum))
            {
                sum /= studentHouse.CountStudents;
                int count = -1;
                foreach (Grocery grocery in groceryList.GetGroceries())
                {
                    count++;
                    grocery.AddToBalance(sum);
                    clbGroceries.Items.RemoveAt(count);
                    clbGroceries.Items.Insert(count, grocery.GetFirstName() + " (Room: " + grocery.GetRoomNumber() + ") owes you: " + grocery.GetBalance);
                }
            }
            else
            {
                MessageBox.Show("Introduce a number as for price");
            }

        }

        private void btnSubstract_Click(object sender, EventArgs e)
        { 
            double amount = -1;
            if (clbGroceries.SelectedItem != null)
            {
                if (Double.TryParse(tbSubstractAmount.Text, out amount))
                {
                    if (amount > 0)
                    {
                        int index = clbGroceries.SelectedIndex;
                        if (groceryList.GetGrocery(index).GetBalance > 0)
                        {
                            if (groceryList.GetGrocery(index).GetBalance - amount >= 0)
                            {
                                groceryList.GetGrocery(index).SubstractFromBalance(amount);
                                clbGroceries.Items.RemoveAt(index);
                                clbGroceries.Items.Insert(index, groceryList.GetGrocery(index).GetFirstName() + " (Room: " + groceryList.GetGrocery(index).GetRoomNumber() + ") owes you: " + groceryList.GetGrocery(index).GetBalance);
                            }
                            else
                            {
                                MessageBox.Show("Balance can't be negative");
                            }
                        }
                        else
                        {
                            MessageBox.Show("The selected house mate owes you nothing");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Input a positive number");
                    }
                }
                else
                {
                    MessageBox.Show("Introduce a number as for price");
                }
            }else
            {
                MessageBox.Show("Select a person");
            }

        }
    }
}
