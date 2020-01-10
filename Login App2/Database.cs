using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GraphQL.Client;
using GraphQL.Common.Request;

namespace Project1
{
    class Database
    {
        private GraphQLClient graphQLClient;
        Student currentStudent = new Student();
        public Database()
        {
            graphQLClient = new GraphQLClient("http://ap-2.herokuapp.com/v1/graphql");
        }

        public async Task<Student> FindStudent(string email, string password, Student currentStudent)
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
                Variables = new
                {
                    email = email,
                    password = password
                }
            };

            var graphQLResponse = await graphQLClient.PostAsync(heroRequest);
            var users = graphQLResponse.Data.users;



            if (users.Count == 0)
            {
                return null;
            }

            currentStudent = new Student(
                (int)users.First.id.Value,
                users.First.firstName.Value,
                users.First.lastName.Value,
                users.First.roomId.Value,
                users.First.email.Value
            );
            return currentStudent;
        }

        public async Task<string>GetFirstName(int id)
        {

            var heroRequest = new GraphQLRequest
            {
                Query = @"
                    query MyQuery($id: Int) {
                    __typename
                        users(where: {id: {_eq: $id}})
                        {
                            firstName
                        }
                    }

                ",
                Variables = new
                {
                    id = id
                }
            };

            var graphQLResponse = await graphQLClient.PostAsync(heroRequest);
            var users = graphQLResponse.Data.users;



            if (users.Count == 0)
            {
                return "-1";
            }

            
            return users.First.firstName;
        }
        public async Task<int> GetRoomNumber(int id)
        {

            var heroRequest = new GraphQLRequest
            {
                Query = @"
                    query MyQuery($id: Int) {
                    __typename
                        users(where: {id: {_eq: $id}})
                        {
                            roomId;
                        }
                    }

                ",
                Variables = new
                {
                    id = id
                }
            };

            var graphQLResponse = await graphQLClient.PostAsync(heroRequest);
            var users = graphQLResponse.Data.users;



            if (users.Count == 0)
            {
                return -1;
            }

            
            return Convert.ToInt32(users.First.roomNumber.Value);
        }

        public async Task<int> GetTotalStudents()
        {

            var heroRequest = new GraphQLRequest
            {
                Query = @"
                    query GetUser() {
                        users(where: {id: { _is_null: false}}) {
                            firstName
                        }
                    }
                ",
              
            };

            var graphQLResponse = await graphQLClient.PostAsync(heroRequest);
            var users = graphQLResponse.Data.users;



            if (users.Count == 0)
            {
                return -1;
            }
            return users.Count;
        }
    }
}
