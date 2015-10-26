using System;

namespace Ohmega
{
  public class Item : GameObject
  {
    private string action = "";

    public string Action { get { return action; } }
    public int Id { get { return id; } }
    public string Name { get { return name; } }
    public string Description { get { return description; } }

    public Item(string name, int id, int location, string description) : base(name, id, location, description)
    {

    }

    public override void loadText(string totalText)
    {
    }
  }
}
