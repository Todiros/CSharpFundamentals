//11. A bank account has a holder name 
//first name, middle name and last name 
//available amount of money (balance) 
//bank name
//IBAN
//3 credit card numbers associated with the account. 
//Declare the variables needed to keep the information for a single bank account using the appropriate data types and descriptive names.
//If you have trouble understanding the code, look at problem 10.
using System;

namespace BankAccount
{
    class Account
    {
        // In one object/instance(bank account) of the class we have holder's information plus three credit cards associated with this account
        // That is the reason why the last parameter of the constructor is an array
        public Account(string firstName, string middleName, string lastName, decimal balance, string bankName, long IBAN, int[] creditCardNum)
        {
            this.firstName = firstName;
            this.middleName = middleName;
            this.lastName = lastName;
            this.balance = balance;
            this.bankName = bankName;
            this.IBAN = IBAN;

            for (int i = 0; i < creditCardNum.Length; i++) // the loop that initializes the array
            {
                this.creditCardNum[i] = creditCardNum[i];
            }

        }

        public void Show()
        {
            Console.WriteLine("First Name: {0}\nMiddle Name: {1}\nLast Name: {2}\nBalance: {3}\nBank Name: {4}\nIBAN: {5}", firstName, middleName, lastName, balance, bankName, IBAN);

            for (int i = 0; i < creditCardNum.Length; i++) // the loop that prints the array
            {
                Console.WriteLine("{0} credit card number is {1}", i + 1, this.creditCardNum[i]);
            }

            Console.WriteLine();
        }

        string firstName;
        string middleName;
        string lastName;
        decimal balance;
        string bankName;
        long IBAN;
        int[] creditCardNum = new int[3]; // the array declaration as field of the class
    }
    class BankAccount
    {
        static void Main()
        {
            int[] cardNumArr = new int[3] { 745621334, 454897621, 687986237 }; // creating and initializing another temporary array for the credit card numbers

            Account newAccount = new Account("Zdravko", "Peshev", "Jelqzkov", 66000000001, "SoftUni", 458963213571, cardNumArr); // creating and initializing the object using the credit card numbers from the previous array

            newAccount.Show();
        }
    }
}
