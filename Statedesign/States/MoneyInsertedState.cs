using Statedesign.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using Statedesign.Context;

namespace Statedesign.States
{
    internal class MoneyInsertedState : IVendingMachineState
    {
        public void InsertMoney(VendingMachine machine)
        {
            Console.WriteLine("Money already inserted...." +
                "Plese Proceed for product selection");
        }
        public void SelectProduct(VendingMachine machine)
        {
            Console.WriteLine("Product selected successfully...." +
                "Please collect your product");
            machine.SetState(new ProductDispensedState());
        }
    }
}
