using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Channels;

class InventoryFullException : Exception
{
    public InventoryFullException(string mesage) : base(mesage)
    { }
}