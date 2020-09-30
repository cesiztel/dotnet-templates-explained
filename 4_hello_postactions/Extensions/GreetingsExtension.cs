namespace MyConsoleProject.Extensions
{
    public static class GreetingsExtension
    {
        public static string SayGreetingsToDepartment(this string message)
        {
            return $"{message} Welcome to the guys of company_department!";
        }
    }
}