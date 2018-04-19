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
            List<string> member = new List<string>();
            //提示使用者輸入一組要分幾個人
            Console.Write("請輸入一組要分幾個人");
            //讀取使用者輸入的數字
            int groupIndex = int.Parse(Console.ReadLine());


            // = =......dafuq(將班上人名存入此陣列)
            string[] memberName = new string[] { "葉俊廷", "張澤瑜", "王程捷", "江儀婷", "張秉華", "陳柏霖", "黃紀瑜",
                "黃昱維", "蔡逸群", "登琳", "世新魏鈞孝吧", "劉定南", "陳信如", "童信傑", "李岳倫", "鄒和恆", "簡毓玟", "劉子瑄", "蕭紹洋", "李亞宸la", "張以潔",
                "邱仕紳", "呂家瑩", "世新林鑫佑", "徐均得", "陳佳欣", "張恩瑋", "周詮", "王湘婷", "蕭宇成", "Max Cheung(BANG)", "馬嘉誠Σヽ(ﾟД ﾟ; )", "陳昱嘉",
                "康珈熏", "盧奕宏", "陳郁佳的大哥黃博涵", "遲正雯", "世新林星彤", "許晏誠ｘ勒是奇多　", "許子安", "高子晴", "陳思婷", "矝鵘鮿", "余彥廷",
                "吳耀輝", "鄭丞智", "林冠廷", "世新何曜宇", "邵喬雨", "張豐愷", "林子晴", "邱雁回", "陳家欣是韓妞", "鄧雅馨", "謝汶珊", "李曼寧", "我是陳柏霖2號", "張鈺慈", "鍾宜珊", "raer_tsai",
                "世新李姳諼", "鄭曼君", "陳柏霖", "世新許子安", "世新方若帆", "李曼寧", "世新張豐愷", "世新遲正雯", "世新周詮" };
            
            //在List裡放入班上人名  
            for (int i = 0; i < memberName.Length; i++)
            {
                member.Add(memberName[i]);
            }

            //每跑完六個人名就利用WriteLine換行並增加顯示第幾組
            for (int a = 1; a <= (float)memberName.Length / groupIndex+1; a++)
            {

                // 產生亂數物件
                Random rand = new Random();

                for (int i = 0; i < groupIndex; i++)
                {
                    //隨機挑選一個數字放入r變數
                    int r = rand.Next(0, member.Count);


                    //嘗試印出member[r]所存的內容,如果有錯誤就離開迴圈,(不加try catch會一直說索引超出陣列之類的,不會改所以先偷懶用這招)
                    try
                    {
                        Console.Write(member[r] + "___");//底線是用來分隔人名比較好讀
                    }
                    catch { }
                    try
                    { member.RemoveAt(r); }
                    catch { };

                }
                Console.WriteLine("第" + a + "組");
            }


            // 暫停畫面
            Console.Read();

        }
    }
}
