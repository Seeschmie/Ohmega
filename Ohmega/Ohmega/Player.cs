using System;

namespace Ohmega
{
  public class Player : Character
  {
    private Inventar inventar = null;

    public Player(string name, int id, int location, string description) : base(name, id, location, description)
    {

    }

    public override void loadText(string totalText)
    {
    }

    public void walk(int location)
    {
      this.location = location;
    }

    public void look(Item item)
    {
      Console.WriteLine(item.Description);
      Console.ReadKey();
    }

    public void pick(Item item)
    {
      inventar.save(item);
    }

    public void openInventar()
    {
      inventar.open();
    }
  }
}
