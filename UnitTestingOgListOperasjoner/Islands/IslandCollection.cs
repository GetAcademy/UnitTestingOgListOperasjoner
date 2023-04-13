using System.Collections;

namespace UnitTestingOgListOperasjoner.Islands
{
    public class IslandCollection
    {
        // hentet fra https://no.wikipedia.org/wiki/Liste_over_%C3%B8yer_etter_st%C3%B8rrelse
        private Island[] _islands;

        public IslandCollection()
        {
            _islands = CreateIslands();
        }

        //public Island GetIslandWithLongestName()
        //{
        //    var theIsland = _islands[0];
        //    foreach (var island in _islands)
        //    {
        //        if (island.Name.Length > theIsland.Name.Length)
        //        {
        //            theIsland = island;
        //        }
        //    }
        //    return theIsland;
        //}
        public Island GetIslandWithLongestName()
        {
            return _islands.OrderByDescending(i => i.Name.Length).First();
        }


        //public List<Island> GetIslandsAboveMinimum(int minimumArea)
        //{
        //    return _islands.Where(i => i.Area > minimumArea).ToList();
        //}

        public List<Island> GetIslandsAboveMinimum(int minimumArea)
        {
            var islands = new List<Island>();
            foreach (var island in _islands)
            {
                if (island.Area > minimumArea)
                {
                    islands.Add(island);
                }
                else
                {
                    break;
                }
            }
            return islands;
        }

        public List<Island> GetIslandsByCountryCount(int minimumCountryCount)
        {
            var islands = new List<Island>();
            foreach (var island in _islands)
            {
                if (island.Countries.Length >= minimumCountryCount )
                {
                    islands.Add(island);
                }
            }
            return islands;
        }

        private static Island[] CreateIslands()
        {
            return new[]
            {
                new Island(1, "Grønland", 2130800, "Grønland, Danmark"),
                new Island(2, "Ny-Guinea", 785753, "Indonesia, Papua Ny-Guinea"),
                new Island(3, "Borneo", 748168, "Brunei, Indonesia, Malaysia"),
                new Island(4, "Madagaskar", 587713, "Madagaskar"),
                new Island(5, "Baffinøya", 507451, "Canada"),
                new Island(6, "Sumatra", 443066, "Indonesia"),
                new Island(7, "Honshu", 225800, "Japan"),
                new Island(8, "Victoriaøya", 217291, "Canada"),
                new Island(9, "Øya Storbritannia", 209331, "Storbritannia"),
                new Island(10, "Ellesmereøya", 196236, "Canada"),
                new Island(11, "Sulawesi", 180681, "Indonesia"),
                new Island(12, "Sørøya (New Zealand)", 145836, "New Zealand"),
                new Island(13, "Java", 138794, "Indonesia"),
                new Island(14, "Nordøya (New Zealand)", 111583, "New Zealand"),
                new Island(15, "Luzon", 109965, "Filippinene"),
                new Island(16, "Newfoundland", 108860, "Canada"),
                new Island(17, "Øya Cuba", 105806, "Cuba"),
                new Island(18, "Øya Island", 101826, "Island"),
                new Island(19, "Mindanao", 97530, "Filippinene"),
                new Island(20, "Irland", 84421, "Irland, Storbritannia"),
                new Island(21, "Hokkaido", 78719, "Japan"),
                new Island(22, "Hispaniola", 73929, "Den dominikanske republikk, Haiti"),
                new Island(23, "Sakhalin", 72493, "Russland"),
                new Island(24, "Banksøya", 70028, "Canada"),
                new Island(25, "Øya Sri Lanka", 65268, "Sri Lanka"),
                new Island(26, "Tasmania", 65022, "Australia"),
                new Island(27, "Devonøya", 55247, "Canada"),
                new Island(28, "Aleksanderøya", 49070, "Antarktis"),
                new Island(29, "Storøya i Ildlandet", 47401, "Argentina, Chile"),
                new Island(30, "Severnyj", 47079, "Russland"),
                new Island(31, "Berknerøya", 43873, "Antarktis"),
                new Island(32, "Axel Heibergs land", 43178, "Canada"),
                new Island(33, "Melvilleøya i Canada", 42149, "Canada"),
                new Island(34, "Salliq", 41214, "Canada"),
                new Island(35, "Marajó", 40100, "Brasil"),
                new Island(36, "Spitsbergen", 37814, "Norge"),
                new Island(37, "Kyushu", 37437, "Japan"),
                new Island(38, "New Britain", 35145, "Papua Ny-Guinea"),
                new Island(39, "Taiwan", 34507, "Taiwan"),
                new Island(40, "Prince of Wales Island", 33339, "Canada"),
                new Island(41, "Juzjnyj", 33246, "Russland"),
                new Island(42, "Hainan", 33210, "Kina"),
                new Island(43, "Øya Vancouver", 31285, "Canada"),
                new Island(44, "Timor", 28418, "Øst-Timor, Indonesia"),
                new Island(45, "Sicilia", 25662, "Italia"),
                new Island(46, "Somersetøya", 24786, "Canada"),
                new Island(47, "Kotelnyj/Faddejevskij", 24000, "Russland"),
                new Island(48, "Sardinia", 23949, "Italia"),
                new Island(49, "Bananal", 20000, "Brasil"),
                new Island(50, "Shikoku", 18545, "Japan"),
                new Island(51, "Halmahera", 18040, "Indonesia"),
                new Island(52, "Seram", 17454, "Indonesia"),
                new Island(53, "Ny-Caledonia", 16648, "Frankrike"),
                new Island(54, "Bathurstøya i Canada", 16042, "Canada"),
                new Island(55, "Patrickøya", 15848, "Canada"),
                new Island(56, "Thurstonøya", 15700, "Antarktis"),
                new Island(57, "Nordaustlandet", 14467, "Norge"),
                new Island(58, "Sumbawa", 14386, "Indonesia"),
                new Island(59, "Oktoberrevolusjonøya", 14204, "Russland"),
                new Island(60, "Flores (Indonesia)", 14154, "Indonesia"),
                new Island(61, "Qikiqtaq", 13111, "Canada"),
                new Island(62, "Negros", 13074, "Filippinene"),
                new Island(63, "Øya Samar", 12849, "Filippinene"),
                new Island(64, "Palawan", 12189, "Filippinene"),
                new Island(65, "Panay", 12011, "Filippinene"),
                new Island(66, "Yos Sudarso", 11742, "Indonesia"),
                new Island(67, "Bangka", 11413, "Indonesia"),
                new Island(68, "Ellef Ringnes' øy", 11295, "Canada"),
                new Island(69, "Bolsjevikøya", 11206, "Russland"),
                new Island(70, "Jamaica", 11190, "Jamaica"),
                new Island(71, "Bylotøya", 11067, "Canada"),
                new Island(72, "Sumba", 10711, "Indonesia"),
                new Island(73, "Mindoro", 10572, "Filippinene"),
                new Island(74, "Viti Levu", 10531, "Fiji"),
                new Island(75, "Øya Hawaii", 10434, "USA"),
                new Island(76, "Cape Breton", 10311, "Canada"),
                new Island(77, "Charlesøya", 9521, "Canada"),
                new Island(78, "Bougainville", 9318, "Papua Ny-Guinea"),
                new Island(79, "Kodiak", 9311, "USA"),
                new Island(80, "Kypros", 9234, "Kypros"),
                new Island(81, "Puerto Rico", 9100, "Puerto Rico"),
                new Island(82, "Komsomoletsøya", 8812, "Russland"),
                new Island(83, "Korsika", 8741, "Frankrike"),
                new Island(84, "Disko", 8612, "Grønland, Danmark"),
                new Island(85, "Carneyøya", 8500, "Antarktis"),
                new Island(86, "Chiloe", 8478, "Chile"),
                new Island(87, "Buru", 8473, "Indonesia"),
                new Island(88, "Kreta", 8350, "Hellas"),
                new Island(89, "Anticostiøya", 7941, "Canada"),
                new Island(90, "Rooseveltøya", 7910, "Antarktis"),
                new Island(91, "Vrangeløya", 7866, "Russland"),
                new Island(92, "Tupinambarana (vestre del)", 7700, "Brasil"),
                new Island(93, "New Ireland", 7404, "Papua Ny-Guinea"),
                new Island(94, "Leyte", 7368, "Filippinene"),
                new Island(95, "Øst-Falkland", 7040, "Storbritannia"),
                new Island(96, "Sjælland", 7031, "Danmark"),
                new Island(97, "Cornwallisøya", 6995, "Canada"),
                new Island(98, "Prince of Wales Island (Alaska)", 6675, "USA"),
                new Island(99, "Kerguelen", 6617, "Frankrike"),
                new Island(100, "Sipleøya", 6390, "Antarktis"),
            };
        }

        public Island GetByRank(int rank)
        {
            foreach (var island in _islands)
            {
                if (island.Rank == rank) return island;
            }
            return null;
        }

        /*
        public Island GetByRank(int rank)
        {
            return _islands.FirstOrDefault(island => island.Rank == rank);
            //return _islands.First(island => island.Rank == rank);
            //return _islands.Single(island => island.Rank == rank);
            //return _islands.SingleOrDefault(island => island.Rank == rank);
            //return _islands.Where(island => island.Rank == rank).FirstOrDefault();
        }
        */
        public List<Island> GetIslandsByCountry(string countryName)
        {
            var islands = new List<Island>();
            foreach (var island in _islands)
            {
                if (island.Countries.Contains(countryName))
                {
                    islands.Add(island);
                }
            }
            return islands;
        }

        //public List<Island> GetIslandsByCountry(string countryName)
        //{
        //    return _islands
        //        .Where(i => i.Countries.Contains(countryName))
        //        .ToList();
        //}

        public int GetIslandCountByCountry(string countryName)
        {
            return _islands.Count(i => i.Countries.Contains(countryName));
        }

        public bool HasCountryIslands(string countryName)
        {
            return _islands.Any(i => i.Countries.Contains(countryName));
            //return _islands.All(i => i.Countries.Contains(countryName));
        }

        //public bool HasCountryIslands(string countryName)
        //{
        //    foreach (var island in _islands)
        //    {
        //        if (island.Countries.Contains(countryName))
        //        {
        //            return true;
        //        }
        //    }
        //    return false;
        //}
    }
}
