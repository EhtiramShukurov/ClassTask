using ClassTask.Models;

namespace ClassTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product("Clothes", 123);
            User user = new User();
            user.Login();
            user.Add(product);
            Console.WriteLine("Succesfully signed in");
        }
    }
}