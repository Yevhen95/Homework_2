using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_2
{
    class User_data
    {

        private string[] user_data = new string[8];
        public User_data()
        {
            
            Console.WriteLine("Enter Last Name : ");
            string LastName = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter First Name : ");
            string FirstName = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter Birth date  : ");
            string Birthdate = Convert.ToString(Console.ReadLine());

            string TimeAdded = DateTime.Now.ToLongTimeString().ToString();

            Console.WriteLine("Enter Address : ");
            string Address = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter Phone Number : ");
            string PhoneNumber = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter Gender : ");
            string Gender = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter Email : ");
            string Email = Convert.ToString(Console.ReadLine());
            Console.WriteLine("The form was filled. ");

            user_data[0] = LastName;
            user_data[1] = FirstName;
            user_data[2] = Birthdate;
            user_data[3] = TimeAdded;
            user_data[4] = Address;
            user_data[5] = PhoneNumber;
            user_data[6] = Gender;
            user_data[7] = Email;

        }


    }



    class AddressBook
    {

        public event EventHandler<CustomEventArgs> RaiseCustomEvent;
        public event EventHandler<CustomEventArgs> RaiseCustomEvent_2;
        List<User_data> book = new List<User_data>();
        public void Adduser()
        {
            
            User_data user_data = new User_data();
            book.Add(user_data);
            Console.WriteLine("User's number is {0}", book.LastIndexOf(user_data));
            
            Console.ReadKey();
            OnRaiseCustomEvent(new CustomEventArgs("User was added"));
        }
       
        public void RemoveUser()
        {
            Console.WriteLine("Enter a numner of user in the book you want to delete  : ");
            int number = Convert.ToInt32(Console.ReadLine());
            book.RemoveAt(number);
            Console.WriteLine("User with {0} number  was deleted ", number);
            OnRaiseCustomEvent(new CustomEventArgs("User was removed"));

        }
        protected virtual void OnRaiseCustomEvent(CustomEventArgs e)
        {
           
            EventHandler<CustomEventArgs> handler = RaiseCustomEvent;

          
            if (handler != null)
            {
                
             

           
                handler(this, e);
            }
        }
       

    }
}
