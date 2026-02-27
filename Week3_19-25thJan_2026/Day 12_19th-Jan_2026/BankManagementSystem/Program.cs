namespace BankManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CheckingAccount obj1 = new CheckingAccount();
            obj1.Name = "Parth";
            obj1.Balance = 70000;
            obj1.Withdraw(45000);
            obj1.Deposit(25000);
            obj1.Summary();

            Console.WriteLine();

            SavingsAccount obj2 = new SavingsAccount();
            obj2.Name = "Abhishek";
            obj2.Balance = 70000;
            obj2.Withdraw(45000);
            obj2.Deposit(75000);
            obj2.Interest();
            obj2.Summary();     
        }
    }
}
