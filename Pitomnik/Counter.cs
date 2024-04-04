namespace Pitomnik
{
    internal class Counter
    {
        private int counter;
        public void Increment() { counter++; }
        public int GetCounter() => counter;
        public bool InRange(int i) => 0 < i && i <= counter;
    }
}
