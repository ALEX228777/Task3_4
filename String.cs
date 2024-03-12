using Task3_1;

namespace ConsTask3_1
{
    public class String : ChoseTip<string>
    {
        public override string RandomTip()
        {
            string letters = "abcdefghijklmnopqrstuvwxyzабвгдеёжзийклмнопрстуфхцчшщъыьэюя";

            char[] chars = new char[10];

            for (int i = 0; i < 10; i++)
            {
                chars[i] = letters[random.Next(0, letters.Length)];
            }

            return new string(chars);
        }

        public override string Stringer(string input)
        {
            return input;
        }
    }
}