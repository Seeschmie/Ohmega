using System;
using System.Collections.Generic;
using System.IO;

namespace Ohmega
{
  public class Game
  {
    private bool isRunning = true;

    private int nextStationId = 0;

    private Dictionary<int, Station> stationList = null;

    private Station station0 = new Station(0);
    private Station station1 = new Station(1);
    private Station station2 = new Station(2);
    private Station station3 = new Station(3);
    private Station station4 = new Station(4);

    private List<string> answers0 = new List<string>();
    private List<string> answers1 = new List<string>();
    private List<string> answers2 = new List<string>();
    private List<string> answers3 = new List<string>();
    private List<string> answers4 = new List<string>();

    private Character player = new Character("James", 0, 0, "");
    private Character character1 = new Character("Bob", 1, 1, "");
    private Character character2 = new Character("Prof. Brown", 2, 4, "");

    private Item item1 = new Item("book", 101, 0, "");
    private Item item2 = new Item("paper", 102, 1, "");
    private Item item3 = new Item("key", 103, 3, "");

    public Game()
    {
      answers0.Add("");
      answers0.Add("");
      answers0.Add("");
      answers0.Add("");

      answers1.Add("");
      answers1.Add("");
      answers1.Add("");
      answers1.Add("");

      answers2.Add("");
      answers2.Add("");
      answers2.Add("");
      answers2.Add("");

      answers3.Add("");
      answers3.Add("");
      answers3.Add("");
      answers3.Add("");

      station0.create("", answers0, item1, player);
      station1.create("", answers1, item2, character1);
      station2.create("", answers2, null, null);
      station3.create("", answers3, item3, null);
      station4.create("", answers4, null, character2);
    }

    public void init()
    {
      stationList.Add(0, station0);
      stationList.Add(1, station1);
      stationList.Add(2, station2);
      stationList.Add(3, station3);
      stationList.Add(4, station4);
    }

    public void run()
    {
      while (isRunning)
      {
        Station tempStation = null;
        stationList.TryGetValue(nextStationId, out tempStation);
        nextStationId = tempStation.play();

        if (nextStationId == -1)
        {
          isRunning = false;
        }
      }
    }
  }
}
