using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GraphQL.Client;
using GraphQL.Common.Request;

namespace Project1
{
    public class Database
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
        public async Task<string> GetRoomNumber(int id)
        {

            var heroRequest = new GraphQLRequest
            {
                Query = @"
                   query MyQuery3($id: Int) {
                      __typename
                      users(where: {id: {_eq: $id}}) {
                        roomId
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

            
            return users.First.roomId.Value;
        }

        public async Task<int> GetTotalStudents()
        {
            var heroRequest = new GraphQLRequest
            {
                Query = @"
                    query GetUser {
                    __typename
                      users {
                        id
                      }
                    }
                "
            };

            var graphQLResponse = await graphQLClient.PostAsync(heroRequest);
            var users = graphQLResponse.Data.users;



            if (users.Count == 0)
            {
                return -1;
            }
            return users.Count;
        }




        public async Task<int> InsertNewAnnouncement(string time, string author, string title, string message)
        {
            var heroRequest = new GraphQLRequest
            {
                Query = @"
                 mutation InsertAnnouncment($author: String, $message: String, $time: String, $title: String) {
                  __typename
                  insert_announcements(objects: {author: $author, message: $message, time: $time, title: $title}) {
                    returning {
                      id
                    }
                  }
                }",
                Variables = new
                {
                    time = time,
                    author = author,
                    title = title,
                    message = message
                }
            };

            
            var graphQLResponse = await graphQLClient.PostAsync(heroRequest);
            var announcements = graphQLResponse.Data.announcements;



            return announcements.First.id.Value;
        }

        public async Task<AnnouncementList> GetAllAnnouncements()
        {
            var heroRequest = new GraphQLRequest
            {
                Query = @"
                    query MyQuery {
                  __typename
                  announcements {
                    author
                    message
                    time
                    title
                  }
                } "
            };

            var graphQLResponse = await graphQLClient.PostAsync(heroRequest);
            var announcements = graphQLResponse.Data.announcements;



            if (announcements.Count == 0)
            {
                return null;
            }
            else
            {
                AnnouncementList announcementList = new AnnouncementList();
                Announcement anno;
                for (int i = 0; i < announcements.Count; i++)
                {
                    anno = new Announcement(announcements[i].time.Value, announcements[i].author.Value, announcements[i].title.Value, announcements[i].message.Value);
                    announcementList.AddAnnouncement(anno);
                }
                return announcementList;
            }
            
        }

        public async Task<int> InsertNewComplaint(string time, string author, string title, string message, int id, bool isOpen)
        {
            var heroRequest = new GraphQLRequest
            {
                Query = @"
                 mutation InsertComplaint($authorName: String, $complaintText: String, $date: String, $title: String, $authorId: Int, $isOpen: Boolean) {
                  __typename
                  insert_Complaints(objects: {authorName: $authorName, complaintText: $complaintText, date: $date, title: $title, authorId: $authorId, isOpen: $isOpen}) {
                    returning {
                      complaintId
                    }
                  }
                }",
                Variables = new
                {
                    date = time,
                    authorName = author,
                    authorId = id,
                    title = title,
                    complaintText = message,
                    isOpen = isOpen
                }
            };


            var graphQLResponse = await graphQLClient.PostAsync(heroRequest);
            var complaints = graphQLResponse.Data.Complaints;



            return complaints.First.id.Value;
        }

        public async Task<AnnouncementList> GetAllComplaintsByStudentId(int id)
        {
            var heroRequest = new GraphQLRequest
            {
                Query = @"
                 query MyQuery5($id: Int) {
                      __typename
                      Complaints(where: {authorId: {_eq: $id}}) {
                        complaintId
                        complaintText
                        date
                        title
                        authorName
                        isOpen
                      }
                    }",
                Variables = new
                {
                    id = id
                }
            };

            var graphQLResponse = await graphQLClient.PostAsync(heroRequest);
            var complaints = graphQLResponse.Data.Complaints;



            if (complaints.Count == 0)
            {
                return null;
            }
            else
            {
                AnnouncementList complaintList = new AnnouncementList();
                Announcement complaint;
                for (int i = 0; i < complaints.Count; i++)
                {
                   
                    complaint = new Announcement(complaints[i].date.Value, complaints[i].authorName.Value, complaints[i].title.Value, (int)complaints[i].complaintId.Value, complaints[i].complaintText.Value, complaints[i].isOpen.Value);
                    complaintList.AddAnnouncement(complaint);
                }
                return complaintList;
            }

        }

        public async Task<int> InsertNewStudent(string firstName, string lastName, string email, string password, string roomId)
        {
            var heroRequest = new GraphQLRequest
            {
                Query = @"
                    mutation MyMutation2($firstName: String, $lastName: String, $email: String, $password: String, $roomId: String) {
                      __typename
                      insert_users(objects: {email: $email, firstName: $firstName, lastName: $lastName, password: $password, roomId: $roomId}) {
                        returning {
                          id
                        }
                      }
                    }",
                Variables = new
                {
                    firstName=firstName,
                    lastName=lastName,
                    email=email,
                    password=password,
                    roomId=roomId
                }
            };


            var graphQLResponse = await graphQLClient.PostAsync(heroRequest);
            var users = graphQLResponse.Data.Users;



            return Convert.ToInt32(users.First.id.Value);
        }

        public async Task<AnnouncementList> GetAllComplaints()
        {
            var heroRequest = new GraphQLRequest
            {
                Query = @"
                 query MyQuery6 {
                      __typename
                      Complaints(where: {isOpen: {_eq: true}}) {
                        authorId
                        authorName
                        complaintId
                        complaintText
                        date
                        title
                      }
                    }",
    
            };

            var graphQLResponse = await graphQLClient.PostAsync(heroRequest);
            var complaints = graphQLResponse.Data.Complaints;



            if (complaints.Count == 0)
            {
                return null;
            }
            else
            {
                AnnouncementList complaintList = new AnnouncementList();
                Announcement complaint;
                for (int i = 0; i < complaints.Count; i++)
                {

                    complaint = new Announcement(complaints[i].date.Value, complaints[i].authorName.Value, complaints[i].title.Value, (int)complaints[i].complaintId.Value, complaints[i].complaintText.Value, true, (int)complaints[i].authorId.Value);
                    complaintList.AddAnnouncement(complaint);
                }
                return complaintList;
            }

        }

        public async Task<int> InsertNewAnswer(string answer, int complaintId)
        {
            var heroRequest = new GraphQLRequest
            {
                Query = @"
                    mutation MyMutation3($answer: String, $complaintId: Int) {
                      __typename
                      insert_complaintAnswer(objects: {answer: $answer, complaintId: $complaintId}) {
                        returning {
                          id
                        }
                      }
                    }",
                Variables = new
                {
                    answer=answer,
                    complaintId=complaintId
                }
            };


            var graphQLResponse = await graphQLClient.PostAsync(heroRequest);
            var complaintAnswer = graphQLResponse.Data.complaintAnswer;



            return Convert.ToInt32(complaintAnswer.First.id.Value);
        }

        public async Task<int> CloseComplaint(int complaintId)
        {
            var heroRequest = new GraphQLRequest
            {
                Query = @"
                    mutation MyMutation4($complaintId: Int) {
                      __typename
                      update_Complaints(where: {complaintId: {_eq: $complaintId}}, _set: {isOpen: false}) {
                        affected_rows
                        returning {
                          complaintId
                        }
                      }
                    }
                    ",
                Variables = new
                {
                    complaintId = complaintId
                }
            };


            var graphQLResponse = await graphQLClient.PostAsync(heroRequest);
            var complaint = graphQLResponse.Data.Complaint;



            return Convert.ToInt32(complaint.First.complaintId.Value);
        }


        public async Task<string> GetAdminAnswer(int complaintId)
        {
            var heroRequest = new GraphQLRequest
            {
                Query = @"
                 query MyQuery6($complaintId: Int) {
                      __typename
                      complaintAnswer(where: {complaintId: {_eq: $complaintId}}) {
                        answer
                      }
                    }",

                Variables = new
                {
                    complaintId = complaintId
                }

            };

            var graphQLResponse = await graphQLClient.PostAsync(heroRequest);
            var complaintAnswer = graphQLResponse.Data.complaintAnswer;



            if (complaintAnswer.Count == 0)
            {
                return null;
            }
            else
            {
                
                return complaintAnswer.First.answer.Value;
            }

        }

        public async Task<AnnouncementList> GetAllClosedComplaints()
        {
            var heroRequest = new GraphQLRequest
            {
                Query = @"
                 query MyQuery6 {
                      __typename
                      Complaints(where: {isOpen: {_eq: false}}) {
                        authorId
                        authorName
                        complaintId
                        complaintText
                        date
                        title
                      }
                    }",

            };

            var graphQLResponse = await graphQLClient.PostAsync(heroRequest);
            var complaints = graphQLResponse.Data.Complaints;



            if (complaints.Count == 0)
            {
                return null;
            }
            else
            {
                AnnouncementList complaintList = new AnnouncementList();
                Announcement complaint;
                for (int i = 0; i < complaints.Count; i++)
                {

                    complaint = new Announcement(complaints[i].date.Value, complaints[i].authorName.Value, complaints[i].title.Value, (int)complaints[i].complaintId.Value, complaints[i].complaintText.Value, false, (int)complaints[i].authorId.Value);
                    complaintList.AddAnnouncement(complaint);
                }
                return complaintList;
            }

        }
    }
}
