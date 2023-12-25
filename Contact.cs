using System;

class Contact
{

    public string name;
    public string surname;
    public string phone;



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

    public Contact addContacts()
    {
        System.Console.Write("Enter name: ");
        string name = Console.ReadLine();

        System.Console.Write("Enter name: ");
        string surname = Console.ReadLine();

        System.Console.Write("Enter name: ");
        string phone = Console.ReadLine();

        Contact contact = new Contact();
        contact.name = name;
        contact.surname = surname;
        contact.phone = phone;


        return contact;
    }

    public Contact deleteContacts()
    {


        return null;
    }

    public Contact searchContacts()
    {
        return null;
    }

    public Contact contactsLists()
    {
        return null;
    }
}