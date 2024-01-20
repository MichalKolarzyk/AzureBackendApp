using FluentAssertions;

namespace CounterTest
{
    public class WhenIncrementingCounter
    {
        private readonly Counter.Domain.Counter _counter;
        private readonly int valueBeforeIncrementation;

        public WhenIncrementingCounter()
        {
            _counter = new Counter.Domain.Counter();
            valueBeforeIncrementation = _counter.Get();
            _counter.Increment();
        }

        [Fact]
        public void Then_CounterValueShould_IncreseByOne()
        {
            _counter.Get().Should().Be(valueBeforeIncrementation + 1);
        }
    }
}