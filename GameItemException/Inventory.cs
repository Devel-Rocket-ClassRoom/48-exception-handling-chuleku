using System;
using System.Collections.Generic;
using System.Security.AccessControl;
using System.Text;
using System.Xml;

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
            throw new InventoryFullException($"[인벤토리 오류] 인벤토리가 가득 찼습니다. (용량: {_Count}, 아이템: {itemName})");
        }
        _inventory[_Count++] = itemName;
        Console.WriteLine($"아이템 '{itemName}' 추가됨");
        return;
    }
    public void RemoveItem(string itemName)
    {
        string[] temp2 = _inventory;
        string search = temp2[0];
        for (int i = 0; i < _inventory.Length; i++)
        {
            if (_inventory[i] == itemName)
            {
                search = _inventory[i];               
            }
        }
        int tempcount = 0;
        if(search!=itemName)
        {
            throw new ItemNotFoundException($"[인벤토리 오류] 아이템을 찾을수 없습니다: {itemName}");
        }
        foreach (string item in _inventory)
        {
            _inventory[tempcount++] = item;
        }
        _inventory[_Count - 1] = null;
        _Count--;
        Console.WriteLine($"아이템 '{itemName}' 제거됨");
        return;
    }
    public void ShowItems()
    {
        Console.Write("현재 인벤토리: ");
        Console.Write(string.Join(", ", _inventory));
        Console.WriteLine();
    }
}