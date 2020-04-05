using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;

namespace MonolithicArchitecture.Core.Transaction
{
    public class TransactionOperations
    {
        public static bool Invoke(Action action)
        {
            using (var transaction = new TransactionScope())
            {
                try
                {
                    action.Invoke();

                    transaction.Complete();
                    return true;
                }
                catch
                {
                    transaction.Dispose();
                    return false;
                }
            }
        }
    }
}
