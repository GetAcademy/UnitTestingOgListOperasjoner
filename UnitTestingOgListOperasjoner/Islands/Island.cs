namespace UnitTestingOgListOperasjoner.Islands
{
    //public struct Island
    public class Island
    {
        public int Rank { get; }
        public string Name { get; }
        public int Area { get; set;  }
        public string[] Countries { get; }

        public Island(int rank, string name, int area, string countries)
        {
            Countries = countries.Split(',');
            Area = area;
            Name = name;
            Rank = rank;
        }

        public void Show()
        {
            Console.WriteLine($"{Rank} {Name} {string.Join(", ", Countries)}");
        }
    }
}
