using System;

namespace Ohmega
{
  public class Character : GameObject
  {
    private string dialog = "";

    public Character(string name, int id, int location, string description) : base(name, id, location, description)
    {

    }

    public override void loadText(string totalText)
    {
    }

    public void talk(Character character)
    {
      Console.WriteLine(character.dialog);
      Console.WriteLine(dialog);
      Console.ReadKey();
    }

    public void use(Item item)
    {
      Console.WriteLine(item.Action);
      Console.ReadKey();
    }
  }
}
