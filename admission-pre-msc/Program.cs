using System;
using System.Linq;
using System.Collections.Generic;

namespace admission_pre_msc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(isHidden("fgex.", "tyf34gdgf;'ektufjhgdgex.;.;rtjynur6"));
            Console.WriteLine(isHidden("abc", "2altrb53c.sse"));
            Console.WriteLine(isHidden("abc", "btarc"));
            Console.ReadLine();
        }

        static string isHidden(string msg1, string msg2)
        {
            List<char> message = msg1.ToList();
            List<char> charForTest = msg2.ToList();
            int index = 0;

            for (int i = 0; i < message.Count; i++)
            {
                if (charForTest.Contains(message[i]))
                {
                    if (index < charForTest.FindIndex(c => c == message[i]))
                    {
                        index = charForTest.FindIndex(c => c == message[i]);
                        continue;
                    }
                }

                return "0";
            }

            return "1";
        }
    }
}
