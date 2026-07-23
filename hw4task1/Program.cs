namespace hw4task1
{
    internal class Account
    {
        public string Username { get; set; }
        private string Password { get; set; }

        public Account(string username, string password)
        {
            Username = username;
            SetPassword(password);
        }

        public void SetPassword(string newPassword)
        {
            if (!IsPasswordValid(newPassword))
            {
                throw new ArgumentException(
                    "Password must contain at least 8 characters, one uppercase letter, one lowercase letter, and one digit.");
            }

            Password = newPassword;
        }

        private bool IsPasswordValid(string password)
        {
            if (string.IsNullOrWhiteSpace(password) || password.Length < 8)
            {
                return false;
            }

            bool hasUpper = false;
            bool hasLower = false;
            bool hasDigit = false;

            foreach (char c in password)
            {
                if (char.IsUpper(c))
                {
                    hasUpper = true;
                }

                if (char.IsLower(c))
                {
                    hasLower = true;
                }

                if (char.IsDigit(c))
                {
                    hasDigit = true;
                }
            }

            return hasUpper && hasLower && hasDigit;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Username: {Username}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter username: ");
                string username = Console.ReadLine() ?? string.Empty;

                Console.Write("Enter password: ");
                string password = Console.ReadLine() ?? string.Empty;

                Account account = new Account(username, password);

                Console.WriteLine("Account created successfully.");
                account.ShowInfo();

                Console.Write("\nEnter a new password: ");
                string newPassword = Console.ReadLine() ?? string.Empty;

                account.SetPassword(newPassword);

                Console.WriteLine("Password changed successfully.");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            Console.ReadKey();
        }
    }
}
