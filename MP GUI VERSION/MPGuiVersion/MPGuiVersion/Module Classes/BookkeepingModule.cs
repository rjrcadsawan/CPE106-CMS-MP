using System;
using System.Collections.Generic;
using System.Text;

namespace MPGuiVersion
{
    class BookkeepingModule
    {
        public float totalCredit = 0;
        public float totalDebit = 0;
        public void addTransaction(Transaction T)
        {

        }

        public void deleteTransaction()
        {

        }

        public void modifyTransaction()
        {

        }

        public void calculateTotal()
        {

        }

        public void TotalValues(out float TC, out float TD)
        {
            TC = this.totalCredit;
            TD = this.totalDebit;
        }
    }
}