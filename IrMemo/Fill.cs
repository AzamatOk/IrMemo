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
            public Fill(int Row,int Column, int CardType)
            {

                string[] allfiles = System.IO.Directory.GetFiles(@"WordsWithImage", "_" + CardType + "*.bmp");
                foreach (string filename in allfiles)
                {
                    string s = filename.Substring(15);
                    s = s.Remove(s.Length - 4); 
                    Cards.Add(s);
                }

                while (Cards.Count > Row * Column)
                {
                    Random rand = new Random();
                    int r = rand.Next(0, Cards.Count);


                    Cards.Remove("_" + CardType + "_" + r + "_" + "0");
                    Cards.Remove("_" + CardType + "_" + r + "_" + "1");
                }
                

               var random = new Random(DateTime.Now.Millisecond);
               Cards = Cards.OrderBy(x => random.Next()).ToList();


                PictureArray = new string[Row, Column];
                int CardNameIndexInList = 0;
                for (int i = 0; i < Row; i++)
                    for (int j = 0; j < Column; j++)
                    {
                        
                        PictureArray[i, j] = Cards[CardNameIndexInList];
                        CardNameIndexInList++;
                    }
                
            }
            public string GetnIdices(int RowsInd,int ColumnsInd)
            {
                return PictureArray[RowsInd,ColumnsInd];
            }
            public void SetDeleted(int RowIndex, int ColumnIndex, string DelImage)
            {
                PictureArray[RowIndex, ColumnIndex] = DelImage;
            }
        }
    }
}
