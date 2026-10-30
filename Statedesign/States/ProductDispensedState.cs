using Statedesign.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using Statedesign.Context;

namespace Statedesign.States
{
    internal class ProductDispensedState : IVendingMachineState
    {
        public void InsertMoney(VendingMachine machine)
        {
            Console.WriteLine("Please reset the machine first");
        }
        public void SelectProduct(VendingMachine machine)
        {
            Console.WriteLine("Product has already been dispensed." +
                " Please reset the machine first.");
        }
    }
}
