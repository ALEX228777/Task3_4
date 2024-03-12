using Task3_1;

namespace ConsoleApp15
{
    public class Double :ChoseTip<double>
    {
        public override double RandomTip()
        {
            return random.NextDouble();
        }

        public override double Stringer(string input)
        {
            return double.Parse(input);
        }
    }
}