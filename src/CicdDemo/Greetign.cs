namespace CICDDemo
{
    public static class Greeting
    {
        public static string Create(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException(
                    "Name cannot be empty.",
                    nameof(name));
            }

            return $"Hello, {name}! The CI/CD project is running.";
        }
    }
}