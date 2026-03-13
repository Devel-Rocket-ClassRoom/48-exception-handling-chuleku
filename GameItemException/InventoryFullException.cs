using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Channels;

class InventoryFullException
{
    public InventoryFullException(string mesage)
    {
        Console.WriteLine($"[인벤토리 오류] 인벤토리가 가득 찼습니다. ({mesage})");
    }
}