using System;
namespace classes_5
{
    public class User
    {
        readonly DateTime completionDate;
        public DateTime CompletionDate { get; set; }

        string userLogin;
        public string UserLogin { get; }

        string userFirstName;
        public string UserFirstName { get; }

        string userLastName;
        public string UserLastName { get; }

        int userAge;
        public int UserAge { get; }

        public User(string userLogin, string userFirstName, string userLastName, int userAge)
        {
            completionDate = DateTime.Now;
            this.userLogin = userLogin;
            this.userFirstName = userFirstName;
            this.userLastName = userLastName;
            this.userAge = userAge;
        }

        public void Show()
        {
            Console.WriteLine($"Login: {userLogin}");
            Console.WriteLine($"First name: {userFirstName}");
            Console.WriteLine($"Last name: {userLastName}");
            Console.WriteLine($"Age: {userAge}");
            Console.WriteLine($"Date of completion: {completionDate}");
        }
    }
}
