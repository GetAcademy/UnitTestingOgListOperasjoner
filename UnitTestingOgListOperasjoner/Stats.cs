namespace UnitTestingOgListOperasjoner
{
    public class Stats
    {
        public int NumberCount { get; private set; }
        public int Sum { get; private set; }
        public int Mean => Sum / NumberCount;

        public void AddNumber(int number)
        {
            Sum += number;
            NumberCount++;
        }
    }
}
