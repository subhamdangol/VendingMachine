using System;
using System.Collections.Generic;
using System.Text;
using Statedesign.Interface;
using Statedesign.States;

namespace Statedesign.Context
{
    internal class VendingMachine
    {
        private IVendingMachineState _currentState;

        public VendingMachine()
        {
            _currentState = new IdelState();
        }
        public void SetState(IVendingMachineState state)
        {
            _currentState = state;
        }
        public void InsertMoney()
        {
            _currentState.InsertMoney(this);
        }
        public void SelectProduct()
        {
            _currentState.SelectProduct(this);
        }
        public void Reset()
        {
            Console.WriteLine("Machine Reset Successful");
            _currentState = new IdelState();
        }
    }
}
