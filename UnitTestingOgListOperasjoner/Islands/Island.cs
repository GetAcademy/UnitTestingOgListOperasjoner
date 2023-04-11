namespace UnitTestingOgListOperasjoner.Islands
{
    public class Island
    {
        public int Rank { get; }
        public string Name { get; }
        public int Area { get; }
        public string[] Countries { get; }

        public Island(int rank, string name, int area, string countries)
        {
            Countries = countries.Split(',');
            Area = area;
            Name = name;
            Rank = rank;
        }
    }
}
