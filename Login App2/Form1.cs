using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using GraphQL.Client;
using GraphQL.Common.Request;


namespace Project1
{
    public partial class Form1 : Form
    {
        Student newStudent;
        StudentHouse studentHouse = new StudentHouse();
        private GraphQLClient graphQLClient;
        Student currentStudent = null;
        int count = 0;
        public Form1()
        {
            InitializeComponent();
            graphQLClient = new GraphQLClient("http://ap-2.herokuapp.com/v1/graphql");
        }

        async Task<bool> findStudent(string email, string password)
        {

            var heroRequest = new GraphQLRequest
            {
                Query = @"
                    query GetUser($email: String, $password: String) {
                        users(where: {_and: {password: {_eq: $password}}, email: {_eq: $email}}) {
                            id
                            email
                            firstName
                            lastName
                            roomId
                        }
                    }
                ",
                Variables = new {
                    email = email,
                    password = password
                }
            };

            var graphQLResponse = await graphQLClient.PostAsync(heroRequest);
            var users = graphQLResponse.Data.users;

            if (users.Count == 0) {
                return false;
            }

            currentStudent = new Student(
                (int)users.First.id.Value,
                users.First.firstName.Value,
                users.First.lastName.Value,
                users.First.roomId.Value,
                users.First.email.Value
            );
            return true;
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        void openNewForm()
        {
            var newForm = new Form2(studentHouse,  currentStudent); //I pass to the next form the studentHouse class and the index of the logged in student
            newForm.Show();
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            string username = tbName.Text;
            string password = tbPassword.Text;
            currentStudent = null;
            if (await findStudent(username, password))
            {
                openNewForm();
                this.Hide();
            }
            else
            {
                MessageBox.Show("The credentials did not match");
            }
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
        }
    }
}
