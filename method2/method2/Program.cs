using System.Text;

namespace method2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sentence = " sALAm mEn AyLA yaXsi DeYILEM";

            Console.WriteLine(NewSentence(sentence));
        }
        static string NewSentence(string sentence)
        {
            string[] words = sentence.Trim().Split(' ');

            StringBuilder newsent = new StringBuilder();
            for (int i = 0; i < words.Length; i++)
            {
                string word = words[i];

                newsent.Append(Char.ToUpper(word[0]));

                for (int j= 1; j < word.Length; j++)
                {
                    newsent.Append(Char.ToLower(word[j]));
                }

                if (i < words.Length - 1)
                {
                    newsent.Append(' ');
                }

              ;
            }
             

            return newsent.ToString().Trim();
        }
    }
}