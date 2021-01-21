using HomeWork1.Interface;

namespace HomeWork1.Collections
{
    public class TestValue1 : IValueInterface
    {
        public TestValue1(int value) => MyValue = value.ToString();

        public string MyValue { get; set; }

        public string GetCurrentValue()
        {
            return MyValue;
        }
    }
}
