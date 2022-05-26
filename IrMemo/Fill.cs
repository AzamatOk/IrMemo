using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace IrMemo
{
    public partial class Menu
    {
        public class Fill
        {
            List<string> Cards = new List<string>();
            string[,] PictureArray;
            public Fill(int a,int b, int type)
            {

                string[] allfiles = System.IO.Directory.GetFiles(@"WordsWithImage", "_" + type + "*.bmp");
                foreach (string filename in allfiles)
                {
                    string s = filename.Substring(15);
                    s = s.Remove(s.Length - 4); 
                    Cards.Add(s);



                }

                while (Cards.Count > a * b)
                {
                    Random rand = new Random();
                    int r = rand.Next(0, Cards.Count);


                    Cards.Remove("_" + type + "_" + r + "_" + "0");
                    Cards.Remove("_" + type + "_" + r + "_" + "1");
                }


                for (int i = 0; i < (a*b-Cards.Count)/2; i++)
                {
                    Random rand = new Random();
                    int r = rand.Next(0, Cards.Count);
                    if (r % 2 == 0)
                    {
                        Cards.Remove("_" + type + "_" + r + "_" + "0");
                        Cards.Remove("_" + type + "_" + r + "_" + "1");
                    }

                    Cards.Remove("_" + type + "_" + r + "_" + "0");
                    Cards.Remove("_" + type + "_" + r + "_" + "1");
                }
                

               var random = new Random(DateTime.Now.Millisecond);
               Cards = Cards.OrderBy(x => random.Next()).ToList();


                PictureArray = new string[a, b];
                int CardNameIndexInList = 0;
                for (int i = 0; i < a; i++)
                    for (int j = 0; j < b; j++)
                    {
                        
                        PictureArray[i, j] = Cards[CardNameIndexInList];
                        CardNameIndexInList++;
                    }
                
            }
            public string GetC(int a,int b)
            {
                return PictureArray[a,b];
                
            }
            public void set(int a, int b, string s)
            {
                PictureArray[a, b] = s;
            }

            public int RowsCount(int a)
            {
                if (a == 1)
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
