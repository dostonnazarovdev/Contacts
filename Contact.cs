using System;
using Dastur;

class Contact
{
    Contact[] contactArray = new Contact[5];
    int index = 0;

    public string name;
    public string surname;
    public string phone;


    //Menu
    public void Menu()
    {
        System.Console.WriteLine("---- Menu ----");
        System.Console.WriteLine("1.add Contact");
        System.Console.WriteLine("2.Delete Contact");
        System.Console.WriteLine("3.Search Contact");
        System.Console.WriteLine("4.Contact List");
        System.Console.WriteLine("0.Exit");
    }

    public int getAction()
    {
        System.Console.Write("choose option: ");
        int num = int.Parse(Console.ReadLine());
        return num;
    }


    //Add contact
    public Contact addContacts()
    {
        System.Console.Write("Enter name: ");
        string name = Console.ReadLine();

        System.Console.Write("Enter suranme: ");
        string surname = Console.ReadLine();

        System.Console.Write("Enter phone: ");
        string phone = Console.ReadLine();

        Contact contact = new Contact();
        contact.name = name;
        contact.surname = surname;
        contact.phone = phone;


        contactArray[index++] = contact;
        System.Console.WriteLine("contact successfully added");
        return contact;
    }

    // Delete contact
    public void deleteContacts()
    {
        System.Console.Write("enter phone: ");
        string phone = Console.ReadLine();
        int deleteIndex = 0;
        for (int i = 0; i < contactArray.Length; i++)
        {
            Contact contact = contactArray[i];
            if (contact != null && contact.phone.Equals(phone))
            {
                deleteIndex = i;
            }
        }

        for (int i = deleteIndex; i < contactArray.Length - 1; i++)
        {
            contactArray[i] = contactArray[i + 1];
        }

        contactArray[contactArray.Length - 1] = null;
        index--;
        System.Console.WriteLine("contect successfully deleted ");
    }

   // Contact Search
    public Contact searchContacts()
    {
        System.Console.Write("enter phone: ");
        string phone = Console.ReadLine();

        for (int i = 0; i < contactArray.Length; i++)
        {
            Contact contact = contactArray[i];
            if (contact != null && contact.phone.Equals(phone))
            {
                Console.WriteLine("contact successfully found");
                Console.WriteLine(contact.name + "  " + contact.surname + "  " + contact.phone + "\n");
            }
        }
        return null;
    }


    // List contact
    public void List()
    {
        for (int i = 0; i < contactArray.Length; i++)
        {
            Contact contact = contactArray[i];
            if (contact != null)
            {
                System.Console.WriteLine("-----------  Contact List   -----------");
                System.Console.WriteLine(contact.name + "  " + contact.surname + "  " + contact.phone + "\n");
            }
        }

    }
}