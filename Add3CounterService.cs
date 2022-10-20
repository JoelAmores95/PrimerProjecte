namespace PrimerProjecte
{
    public class Add3CounterService : ICounterService
    {
        private int _counter = 0;
        public int getAddIncrement()
        {
            _counter += 3;
            return _counter-3;
        }
    }
}