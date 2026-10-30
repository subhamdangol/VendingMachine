using System;
using System.Collections.Generic;
using System.Text;
using Statedesign.Interface;
using Statedesign.Context;

namespace Statedesign.States
{
    internal class IdelState : IVendingMachineState
    {
        public void InsertMoney(VendingMachine machine)
        {
            Console.WriteLine("Money inserted Successfully...."+
                "Plese Proceed for product selection");
            machine.SetState(new MoneyInsertedState());

        }
        public void SelectProduct(VendingMachine machine)
        {
            Console.WriteLine("Please insert money first");
        }
        
    }
}
