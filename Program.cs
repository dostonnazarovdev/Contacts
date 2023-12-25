using System;
using System.Security.Cryptography.X509Certificates;

namespace Dastur
{
    class Program
    {

        static void Main()
        {
            Contact contact = new Contact();
            bool b = true;
            

            while (b)
            {
                contact.Menu();
                int n = contact.getAction();
                switch (n)
                {
                    case 1:
                        contact.addContacts();
                        break;
                    case 2:
                        contact.deleteContacts();
                        break;
                    case 3:
                     contact.searchContacts();
                        break;
                    case 4:
                        contact.List();
                        break;
                    case 0:
                        b = false;
                        break;
                    default:
                        System.Console.WriteLine("wrong option!");
                        break;
                }

            }



        }
    }
}
