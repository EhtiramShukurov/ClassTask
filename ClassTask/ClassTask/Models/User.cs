using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTask.Models
{
    internal class User
    {
        string _username;
        string _password;
        bool _isSignedIn;
        Product[] _products = new Product[0];
        public string UserName
        {
            get { return _username; }
            set {
                value = value.Trim();
                if (value.Length >=6 && value.Length <=25)
                {
                    _username = value;
                }
            }
        }
        public string Password
        {
            get { return _password; }
            set {
                while (true)
                {
                    var isValid = CheckPassword(value);
                    if (value.Length >= 8 && value.Length <= 25)
                    {
                        if (isValid.HasUpper==true && isValid.HasLower==true && isValid.HasDigit==true)
                        {
                            _password = value;
                            break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid password,enter again");
                        value = Console.ReadLine();
                    }
                }
            }
        }
        public bool IsSignedIn
        {
            get { return _isSignedIn; }
            set { _isSignedIn = value; }
        }
        public Product[] Products
        {
            get { return _products; }
            set
            {
                _products = value;
            }
        }
        public (bool HasUpper,bool HasLower,bool HasDigit) CheckPassword(string password)
        {
            bool Upper = false;
            bool Lower = false;
            bool Digit = false;
            for (int i = 0; i < password.Length; i++)
            {
                if (Char.IsDigit(password,i))
                {
                    Digit = true;
                }
                if (Char.IsLower(password,i))
                {
                    Lower = true;
                }
                if (char.IsUpper(password,i))
                {
                    Upper = true;
                }
            }
            return (Upper, Lower, Digit);
        }
        public void Login()
        {
            Console.WriteLine("Enter username");
            UserName = Console.ReadLine();
            Console.WriteLine("Enter password");
            Password = Console.ReadLine();
            IsSignedIn=true;
        }
        public void Add(Product product)
        {
            if (IsSignedIn == true)
            {
                Array.Resize(ref _products, _products.Length+1);
                _products[_products.Length-1] = product;
                Console.WriteLine(product.Name +" added succesfully ");
            }
            else
            {
                Login();
            }
        }

    }
}
