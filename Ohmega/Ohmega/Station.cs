using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ohmega
{
  public class Station
  {
    private int stationId = 0;
    private int choice = 0;

    private string description = null;
    private List<string> answers = null;
    private Item item = null;
    private Character character = null;

    public Station(int stationId)
    {
      this.stationId = stationId;
    }

    public void create(string description, List<string> answers, Item item, Character character)
    {
      this.description = description;
      this.answers = answers;
      this.item = item;
      this.character = character;
    }

    public void action(int choice)
    {
      Console.WriteLine(answers[choice]);
    }

    public int play()
    {
      int choiceCount = description.Split('(').Length - 1;
      Console.WriteLine(description);
      choice = Convert.ToChar(Console.ReadLine());

      for (int i = 0; i < choiceCount; ++i)
      {
        if (choice == i)
        {
          action(choice);
        }
        else if (choice == -1)
        {
          break;
        }
      } 

      int nextStationId = 0;
      return nextStationId;
    }
  }
}
