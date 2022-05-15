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
                for (int i = 0; i < a * b; i++)
                {
                    
                    string name = "";
                    int IrOrRus = 0, WordIndex = i;
                    if (i > a * b / 2 - 1)
                    {
                        IrOrRus = 1;
                        WordIndex = i % (a * b / 2);
                    }
                    name += "_" + type.ToString() + "_" + WordIndex.ToString() + "_" + IrOrRus.ToString();
                    Cards.Add(name);
                    
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
        }
    }
}
