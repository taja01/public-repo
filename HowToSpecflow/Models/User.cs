namespace HowToSpecflow.Models
{
    internal class User
    {
        public string Name { get; set; }
        public string Email { get; set; }

        public static User User1 => new User { Name = "User1", Email = "user1@test.com" };
        public static User User2 => new User { Name = "User2", Email = "user2@test.com" };
    }
}
