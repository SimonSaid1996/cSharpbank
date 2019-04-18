using System;
using System.Collections.Generic;

namespace bankApp{
	//account class to store the user name, balance info, u can deposite, withdraw and see the transcation history
    public class BankAccount{
        public string Number {get;}
        public string Owner{get;set;}
        public decimal Balance {
            get{
                decimal balance = 0;
                foreach(var item in allTransaction){
                    balance +=item.Amount;
                }
                return balance;
            }
        }
        private static int accountNumberSeed = 123456;
        private List<Transaction> allTransaction = new List<Transaction>();
        public void MakeDeposit(decimal amount, DateTime date, string note){
           if(amount <=0){
              throw new ArgumentOutOfRangeException(nameof(amount),"amount must be positive");
           }   
           else{
               var deposit = new Transaction(amount, date, note);
               allTransaction.Add(deposit);
           }   
        }
        public void makeWithdraw(decimal amount, DateTime date, string note){
            if(amount <=0){
              throw new ArgumentOutOfRangeException(nameof(amount),"amount must be positive");
           } 
           else if(Balance - amount <0){
               throw new InvalidOperationException("don't have enough money to withdraw"); 
           }  
           else{
               var deposit = new Transaction(-amount, date, note);
               allTransaction.Add(deposit);
           }   
        }
        public BankAccount(string name, decimal balance){
            this.Owner = name;
            MakeDeposit(balance, DateTime.Now,"initial deposite made");
            this.Number = accountNumberSeed.ToString();
            accountNumberSeed++;
        }

        public string GetHistory(){
            var report = new System.Text.StringBuilder();   //use stringbuilder to infinitaly add strings
            report.AppendLine("format/ name/ time/ balance/ note");
            foreach(var trans in allTransaction){                        
                report.Append($"{this.Owner}\t{trans.Date.ToShortDateString()}\t{trans.Amount}\t{trans.Notes}\n");    
            }
            return report.ToString();
        }

    }

}