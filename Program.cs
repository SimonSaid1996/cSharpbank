using System;
namespace bankApp
{
    
    class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount("AK47", 10000);
            Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance} initial balance.");
            account.makeWithdraw(500,DateTime.Now,"withdraw money");
            Console.WriteLine($"cur balance is {account.Balance}");
            account.MakeDeposit(200, DateTime.Now, "depositing money");
            Console.WriteLine($"cur balance is {account.Balance}");

            //make a negative account balance
            /*try{
                account.makeWithdraw(20000,DateTime.Now,"tryin g to make oversa");
            }catch(InvalidOperationException m){
                Console.WriteLine(m.ToString());
                Console.WriteLine("overdraw");
            }*/
            var test = account.GetHistory();
            Console.WriteLine($"{test}");       

        }
    }
}
