namespace UnitTestingOgListOperasjoner.Islands
{
    internal class Country
    {
        public string Name { get; }
        private List<Island> _islands;

        public Country(string name)
        {
            Name = name;
            _islands = new List<Island>();
        }

        public void AddIsland(Island i)
        {
            _islands.Add(i);
        }

        public void Show()
        {
            Console.WriteLine(Name);
            foreach (var island in _islands)
            {
                Console.WriteLine("  " + island.Name);
            }
        }
    }
}
