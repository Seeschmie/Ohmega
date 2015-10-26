using System;
using System.Collections.Generic;

namespace Ohmega
{
  public class Inventar : GameObject
  {
    private Dictionary<int, Item> itemList = null;
    private bool isFull = false;
    private bool isEmpty = false;
    private int itemCount = 0;

    public Inventar(string name, int id, int location, string description) : base(name, id, location, description)
    {

    }

    public override void loadText(string totalText)
    {
    }

    public bool save(Item item)
    {
      itemList.Add(item.Id, item);
      return false;
    }

    public void delete(Item item)
    {
      itemList.Remove(item.Id);
    }

    public void open()
    {
      foreach (var item in itemList)
      {
        Console.WriteLine(item.Value.Name);
        Console.ReadKey();
      }
    }

    public void close()
    {

    }
  }
}
