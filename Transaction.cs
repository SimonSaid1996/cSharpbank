using System;
namespace bankApp{
    public class Transaction{
		//transaction class to record all the banking transactions
        public decimal Amount {get;}
        public DateTime Date {get;}
        public string Notes {get;}

        public Transaction(decimal amount, DateTime date, string note){
            this.Amount = amount;
            this.Date = date;
            this.Notes = note;
        }


    }
}