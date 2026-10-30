using System;
using System.Collections.Generic;
using System.Text;
using Statedesign.Context;

namespace Statedesign.Interface
{
    internal interface IVendingMachineState
    {
        void InsertMoney(VendingMachine machine);
        void SelectProduct(VendingMachine machine);
    }
}
