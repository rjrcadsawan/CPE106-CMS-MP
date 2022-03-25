using System;
using System.Collections.Generic;
using System.Text;

namespace MPGuiVersion
{
    class BookkeepingModule
    {
        public float totalCredit = 0;
        public float totalDebit = 0;
        public void addTransaction(string name, string description, bool creditChecked, float amount)
        {
            Transaction T = new Transaction();
            T.Name = name;
            T.Summary = description;
            T.Amount = amount;

            if (creditChecked)
            {
                T.TransactionC = true;
                T.TransactionD = false;
                this.totalCredit += amount;
            } else
            {
                T.TransactionC = false;
                T.TransactionD = true;
                this.totalDebit += amount;
            }
        }

        public void TotalValues(out float TC, out float TD)
        {
            TC = this.totalCredit;
            TD = this.totalDebit;
        }
    }
}