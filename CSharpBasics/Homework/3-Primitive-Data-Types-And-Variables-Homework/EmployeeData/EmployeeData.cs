//10. A marketing company wants to keep record of its employees. Each record would have the following characteristics:
//•	First name
//•	Last name
//•	Age (0...100)
//•	Gender (m or f)
//•	Personal ID number (e.g. 8306112507)
//•	Unique employee number (27560000…27569999)
//Declare the variables needed to keep the information for a single employee using appropriate primitive data types. 
//Use descriptive names. Print the data at the console.
//Sorry, if you don't undestand the new code. I've tried my best to explain it briefly. Look at Nakov's book - Programming with C# for more information.  
using System;

namespace EmployeeData
{
    class Employee // This is custom class, an abstraction of employee's record with the required characteristics and functions 
    {
        public Employee(string firstName, string lastName, byte employeeAge, char gender, long personalIdNum, int uniqueEmployeeNum) // class constructor - method that allows objects (instances) of a class with certain characteristics to be created and its fields initialized    
        {
            this.firstName = firstName; // "this" pointer allows a method to be used on any object from the same class, accessing its other methods and fields
            this.lastName = lastName;
            this.employeeAge = employeeAge;
            this.gender = gender;
            this.personalIdNum = personalIdNum;
            this.uniqueEmployeeNum = uniqueEmployeeNum;
        }

        public void Show() // this method can be applied to any object of this class, printing its fields
        {
            Console.WriteLine("First Name: {0}\nLast Name: {1}\nEmployee Age: {2}\nGender: {3}\nPersonal ID: {4}\nUnique Employee Number: {5}\n", firstName, lastName, employeeAge, gender, personalIdNum, uniqueEmployeeNum);
        }

        string firstName; // these are all the variables (fields) used in the class and initialized by the constructor 
        string lastName; 
        byte employeeAge;
        char gender;
        long personalIdNum;
        int uniqueEmployeeNum;
    }
    class EmployeeData
    {
        static void Main()
        {
            Employee newEmployee = new Employee("Zdravko", "Jelqzkov", 25, 'M', 8306112507, 27569999); // creating an object from class Employee, calling its constructor and initializing its parameters 
            newEmployee.Show(); // the print method of the class, applied on the newly created object
        }
    }
}
