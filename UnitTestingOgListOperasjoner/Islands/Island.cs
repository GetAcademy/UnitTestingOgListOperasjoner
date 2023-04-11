namespace UnitTestingOgListOperasjoner.Islands
{
    internal class Island
    {
        private int _rank;
        private string _name;
        private int _area;
        private string[] _countries;

        public Island(int rank, string name, int area, string countries)
        {
            _countries = countries.Split(',', ' ');
            _area = area;
            _name = name;
            _rank = rank;
        }
    }
}
