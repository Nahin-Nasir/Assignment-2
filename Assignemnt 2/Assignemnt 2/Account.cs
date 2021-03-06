using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignemnt_2
{
    class Account
    {
        private int accountNumber = 1;
        private static int myaccountnumber;
        private string accountName;
        private double balance;
        private Address address;
        private Birthday birthday;
        private string accounttype;
        private int numberoftransection;
        public Account(string accountName, double balance, Address address, Birthday birthday, string accounttype, int numberoftransection)
        {
            accountNumber = ++myaccountnumber;
            this.accountName = accountName;
            this.balance = balance;
            this.address = address;
            this.birthday = birthday;
            this.accounttype = accounttype;
            this.numberoftransection = numberoftransection;


        }

        public int AccountNumber
        {
            set { this.accountNumber = value; }
            get { return this.accountNumber; }
        }

        public string AccountName
        {
            set { this.accountName = value; }
            get { return this.accountName; }

        }

        public double Balance
        {
            set { this.balance = value; }
            get { return this.balance; }

        }


        public Address Address
        {
            set { this.address = value; }
            get { return this.address; }

        }

        public Birthday Birthday
        {
            set { this.birthday = value; }
            get { return this.birthday; }

        }
        public string Accounttype
        {
            set { this.accounttype = value; }
            get { return this.accounttype; }

        }

        public int Numberoftransection
        {
            set { this.numberoftransection = value; }
            get { return this.numberoftransection; }
        }

        public void Withdraw(double amount)
        {
            if (this.Balance - amount >= 500)
            {
                this.Balance = Balance - amount;
            }
            else
                Console.WriteLine("your balance is not sufficient");
        }
        public void Deposit(double amount)
        {
            this.Balance = this.Balance + amount;

        }
        public void Transfer(double amount, Account receiver)
        {
            receiver.Deposit(amount);
            this.Withdraw(amount);

        }
        public void ShowAccountInformation()
        {
            Console.WriteLine("Account Informations: AccountNo-{0},AccountName-{1},Balance-{2}", this.accountNumber, this.AccountName, this.Balance, this.address.GetAddress(), this.birthday.GetBirthday());

        }

    }
}
