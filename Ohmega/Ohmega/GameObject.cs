using System;

namespace Ohmega
{
  public abstract class GameObject
  {
    protected string name = "";
    protected string description = "";
    protected int id = 0;
    protected int location = 0;

    public GameObject(string name, int id, int location, string description)
    {
      this.name = name;
      this.id = id;
      this.location = location;
      this.description = description;
    }

    public virtual void loadText(string totalText)
    {
    }
  }
}
