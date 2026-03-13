using System;
using System.Collections.Generic;
using System.Security.AccessControl;
using System.Text;

class Inventory
{
    public string[] _inventory {  get; set; }
    public int _Count {  get; set; }
    public Inventory(int capacity)
    {
        _inventory = new string[capacity]; 
    }
    public void AaddItem(string itemName)
    {
        if(_Count>=_inventory.Length)
        {
            throw new InventoryFullException($"용량: {_Count}, 아이템: {itemName}");
        }
        _inventory[_Count++] = itemName;
        Console.WriteLine($"아이템 '{itemName}' 추가됨");
        return;
    }
    public void RemoveItem(string itemName)
    {

    }

}