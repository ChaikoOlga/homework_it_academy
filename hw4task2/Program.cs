namespace hw4task2
{
    namespace AuditExample
    {
        public class UserProfile
        {
            public string Name { get; private set; }

            public DateTime? LastNameChangedAt { get; private set; }
            public DateTime? LastProfileChangedAt { get; private set; }

            public UserProfile(string name)
            {
                Name = name;
            }

            public void ChangeName(string newName)
            {
                if (string.IsNullOrWhiteSpace(newName))
                {
                    throw new ArgumentException("Name cannot be empty.");
                }

                if (Name != newName)
                {
                    Name = newName;
                    LastNameChangedAt = DateTime.Now;
                }
            }

            public void UpdateProfile()
            {
                LastProfileChangedAt = DateTime.Now;
            }

            public void ShowAuditInfo()
            {
                Console.WriteLine($"Current name: {Name}");

                Console.WriteLine(
                    $"Last name change: {LastNameChangedAt?.ToString("yyyy-MM-dd HH:mm:ss") ?? "Never"}");

                Console.WriteLine(
                    $"Last profile change: {LastProfileChangedAt?.ToString("yyyy-MM-dd HH:mm:ss") ?? "Never"}");
            }
        }

        class Program
        {
            static void Main()
            {
                UserProfile user = new UserProfile("Ivan");

                user.ChangeName("Ola");
                user.UpdateProfile();
                user.ShowAuditInfo();
            }
        }
    }
}
