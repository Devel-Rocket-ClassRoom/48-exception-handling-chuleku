using System;
using System.Collections.Generic;
using System.Text;

class ItemNotFoundException : Exception
{
    public ItemNotFoundException(string mesage) : base(mesage) { }

}