using System.Text;
using System;

namespace PadawansTask8
{
    public static class WordsManipulation
    {
        public static void RemoveDuplicateWords(ref string text)
        {
            if(text == null)
            {
                throw new ArgumentException();
            }
            else if(text.Length == 0)
            {
                throw new ArgumentNullException();
            }
            else
            {
                char[] suka = text.ToCharArray();
                for (int i = 0; i < suka.Length; ++i)
                {
                    if (text[i] == ',' || text[i] == '.' || text[i] == '?' ||
                        text[i] == '!' || text[i] == ':' || text[i] == ';' || text[i] == '-')
                    {
                        suka[i] = ' ';
                    }
                    else
                    {
                        suka[i] = text[i];
                    }
                }
                string text2 = new string(suka);

                string[] hh = text2.Split(' ');

                for (int i = 0; i < hh.Length; ++i)
                {
                    for (int j = i + 1; j < hh.Length; ++j)
                    {
                        if (hh[i] == hh[j] && hh[i] != " ")
                        {
                            hh[j] = " ";
                        }
                    }
                }

                string final = "";
                for (int i = 0; i < hh.Length - 1; ++i)
                {
                    if (hh[i] != " ")
                    {
                        final += hh[i] + " ";
                    }
                    else
                    {
                        final += hh[i] + "";
                    }
                }
                text = final;
            }
            
        }
    }
}