using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupHomework
{
    class Program
    {
        static void Main(string[] args)
        {


            //建立一個空的List
            List<int> number = new List<int>();

            // 在List裡放入班上人數       
            for (int i = 0; i < 66; i++)
            {
                number.Add(i);
            }

            for (int a = 1; a <= 11; a++)
            {

                // 產生亂數物件
                Random rand = new Random();

                for (int i = 0; i < 6; i++)
                {
                    //隨機挑選一個數字放入r變數
                    int r = rand.Next(1, number.Count);

                    //嘗試印出number[r],如果有錯誤就離開迴圈,(不加這個一直說索引超出陣列之類的所以先偷懶用這招)
                    try
                    {
                        Console.Write(number[r] + " ");
                    }
                    catch { break; }
                    

                    
                    number.RemoveAt(r);
                }
                Console.WriteLine("第" + a + "組");
            }


            // 暫停
            Console.Read();

        }
    }
}
