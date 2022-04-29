using System;
using System.Collections.Generic;
using System.Text;

namespace MPGuiVersion
{
    public class Transaction
    {
        private string fullName;
        private string Description;
        private bool isCredit = true;
        private bool isDebit = false;
        private float amount;


        public string Name { get => fullName; set => fullName = value; }
        public string Summary { get => Description; set => Description = value; }
        public bool TransactionC { get => isCredit; set => isCredit = value; }
        public bool TransactionD { get => isDebit; set => isDebit = value; }
        public float Amount { get => amount; set => amount = value; }
    }
}