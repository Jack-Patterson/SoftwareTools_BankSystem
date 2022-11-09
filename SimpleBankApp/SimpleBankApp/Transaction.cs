using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleBankApp
{
    public class Transaction
    {
        private int TransId { get; set; }
        private DateTime TransDate { get; set; }
        private float Amount { get; set; }
        private int SenderAccountID { get; set; }
        private int ReceiverAccountID { get; set; }

        public Transaction(int TransId, DateTime TransDate, float Amount, int SenderAccountID, int ReceiverAccountID)
        {
            this.TransId = TransId;
            this.TransDate = TransDate;
            this.Amount = Amount;
            this.SenderAccountID = SenderAccountID;
            this.ReceiverAccountID = ReceiverAccountID;
        }

        public override string ToString()
        {
            return "€" + this.Amount + "\t\t" + this.TransDate + "\t\t" + this.TransId + "\t\t" + this.SenderAccountID + "\t\t" + this.ReceiverAccountID;
        }
    }
}
