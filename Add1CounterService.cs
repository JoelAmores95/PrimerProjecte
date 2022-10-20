namespace PrimerProjecte
{
    public class Add1CounterService : ICounterService
    {
        private int _counter = 0;
/*        private static Add1CounterService? _Instance = null;*/
        public int getAddIncrement()
        {
            return _counter++;
        }
        /*private Add1CounterService() { }
        public static Add1CounterService GetInstance()
        {
            if(_Instance == null) _Instance = new Add1CounterService();
            return _Instance;
        }*/
    }
}