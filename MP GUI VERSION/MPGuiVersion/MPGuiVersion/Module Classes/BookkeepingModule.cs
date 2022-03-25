using System;
using System.Collections.Generic;
using System.Text;

namespace MPGuiVersion
{
    static class BookkeepingModule
    {
        static void addTransaction()
        {
            string value = "";
            new = transaction;
            name.text;
            description.text;

            bool isChecked = credit.Checked;
            if (isChecked)
                value = credit.Text;
            else
                value = debit.Text;

            amount.text;
            totalCredit.text;
            totalDebit.text;

        }
        static void clearFields()
        {
            name.text = "";
            description.text = "";
            credit.Checked = false;
            debit.Checked = false;
            amount.text = "";
            totalCredit.text = "";
            totalDebit.text = "";
        }

    }
}