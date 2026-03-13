using System;
using System.Collections.Generic;

Console.WriteLine("=== 인벤토리 테스트 ===");
Inventory inventory = new Inventory(3);
try
{
    inventory.AaddItem("검");
    inventory.AaddItem("방패");
    inventory.AaddItem("포션");
    inventory.AaddItem("활");
}
catch(InventoryFullException ex)
{
    Console.WriteLine(ex.Message);
}
Console.WriteLine();
inventory.ShowItems();
try
{
    inventory.RemoveItem("포션");
    inventory.RemoveItem("도끼");
}
catch(ItemNotFoundException ex)
{
    Console.WriteLine(ex.Message);
}
Console.WriteLine();
inventory.ShowItems();
