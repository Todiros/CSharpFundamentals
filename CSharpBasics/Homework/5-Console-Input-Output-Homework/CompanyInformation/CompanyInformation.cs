// 02. A company has name, address, phone number, fax number, web site and manager.
// The manager has first name, last name, age and a phone number.
// Write a program that reads the information about a company and its manager and prints it back on the console.

using System;
// CLASS MANAGER
class Manager
{
    public Manager() // Default parameterless constructor with default values
    {
        this.firstName = "Svetlin";
        this.lastName = "Nakov";
        this.age = 26;
        this.managerPhoneNum = "+359 314 159 265";
    }
    public Manager(string firstName, string lastName, byte age, string managerPhoneNum) // Second constructor with parameters (if you want to add the values yourself)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.age = age;
        this.managerPhoneNum = managerPhoneNum;
    }
    public void Show()
    {
        Console.WriteLine("Manager's first name: {0}", this.firstName);
        Console.WriteLine("Manager's last name: {0}", this.lastName);
        Console.WriteLine("Manager's age: {0}", this.age);
        Console.WriteLine("Manager's phone number: {0}", this.managerPhoneNum);
        Console.WriteLine();
    }

    // The definition of the properties/fields of the class
    string firstName;
    string lastName;
    byte age;
    string managerPhoneNum;
}
// CLASS MANAGER
class Company
{
    public Company() // The default constructor of class Company
    {
        this.companyName = "Software University";
        this.companyAddress = "15-18 Tintyava, Sofia";
        this.companyPhoneNum = "+359 112 358 132";
        this.companyFax = "no fax";
        this.webSite = "http://softuni.bg";
        this.companyManager = new Manager(); // It will call the default constructor of class Manager
    }

    public Company(string companyName, string companyAddress, string companyPhoneNum, string companyFax, string webSite, Manager companyManager) // Using an object of class Manager as a field of Company class and parameter of its constructor
    {
        this.companyName = companyName; 
        this.companyAddress = companyAddress;
        this.companyPhoneNum = companyPhoneNum;
        this.companyFax = companyFax;
        this.webSite = webSite;
        this.companyManager = companyManager;
    }

    public void Show()
    {
        Console.WriteLine("Company's name: {0}", this.companyName);
        Console.WriteLine("Company's address: {0}", this.companyAddress);
        Console.WriteLine("Company's phone number: {0}", this.companyPhoneNum);
        Console.WriteLine("Company's fax number: {0}", this.companyFax);
        Console.WriteLine("Company's web site: {0}", this.webSite);
        Console.WriteLine();
        companyManager.Show(); // Calling Manager's Show() method from Company's Show() method so I call it only once in Main() method
    }

    string companyName;
    string companyAddress;
    string companyPhoneNum;
    string companyFax;
    string webSite;
    Manager companyManager; // companyManager is an object/instance of class Manager
}
class CompanyInformation
{
    static void Main()
    {
        //IF YOU WANT TO ADD THE INFORMATION YOURSELF

        /*
        Console.Write("Company Name: ");
        string companyName = Console.ReadLine();

        Console.Write("Company Address: ");
        string companyAddress = Console.ReadLine();

        Console.Write("Company Phone Number: ");
        string phoneNumber = Console.ReadLine();

        Console.Write("Company Fax Number: ");
        string faxNumber = Console.ReadLine();

        Console.Write("Company Web Site: ");
        string companyWebsite = Console.ReadLine();

        Console.Write("Manager's First Name: ");
        string managerFirstName = Console.ReadLine();

        Console.Write("Manager's Last Name: ");
        string managerLastName = Console.ReadLine();

        Console.Write("Manager's Age: ");
        byte managerAge = byte.Parse(Console.ReadLine());

        Console.Write("Manager's Phone Number: ");
        string managerPhone = Console.ReadLine();

        Manager companyManager = new Manager(managerFirstName, managerLastName, managerAge, managerPhone);
        Company SoftUni = new Company(companyName, companyAddress, phoneNumber, faxNumber, companyWebsite, companyManager);
        */

        //OTHERWISE, USE THE DEFAULT VALUES

        Company SoftUni = new Company(); // Creating object of class Company using the default constructor which will automatically call Manager's default constructor
        SoftUni.Show(); // This will call the Show() method from both classes
    }
}

