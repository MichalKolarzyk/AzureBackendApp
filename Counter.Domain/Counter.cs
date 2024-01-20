namespace Counter.Domain
{
    public class Counter
    {
        private int _counter;


        public void Increment()
        {
            _counter += 1;
        }

        public void Decrement()
        {
            if (_counter <= 0)
                throw new Exception("Counter can not have negative value");

            _counter -= 1;
        }

        public int Get()
        {
            return _counter;
        }

        public void Restart()
        {
            _counter = 0;
        }
    }
}
