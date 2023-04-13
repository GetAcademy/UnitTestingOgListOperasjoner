using System;

namespace UnitTestingOgListOperasjoner.Islands
{
    internal class ListOperationsDemo
    {
        /*
         * Pause til 13:06
         *
         * Noen vanlige operasjoner på lister av objekter:
         *  - Finne et objekt ut fra bestemt feltverdi 
         *  - Finne alle objekter ut fra bestemt feltverdi (filter Where) - eller telle - eller alle/ingen/noen
         *  - Aggregeringer som min, max, sum, snitt
         *  - Sortere
         *  - Lage en ny liste med verdiene til et eller flere felt - eller en konstruksjon avledet av dette (map Select)
         *  - Fjerne alle objekter som tilfredstiller et bestemt kriterie
         *  - Oppdatere feltverdien til alle objekter som tilfredstiller et bestemt kriterie
         *
         *  - Gruppere objekter
         *  - Slå sammen lister. En liste minus en annen. Snitt mellom to lister.          
         *  - Hente ut delliste, feks de n første, n mellomste eller n siste.
         *  - Reversere
         *  - Merge lister (Zip)
         */
        public static void Run()
        {
            var islandCollection = new IslandCollection();

            // - Finne et objekt ut fra bestemt feltverdi 
            //var island = islandCollection.GetByRank(50);
            //island.Show();

            // -Finne alle objekter ut fra bestemt feltverdi(filter Where) -eller telle - eller alle / ingen / noen
            var norwegianIslands = islandCollection.GetIslandsByCountry("Norge");
            foreach (var island in norwegianIslands)
            {
                island.Show();
            }


        }
    }
}
