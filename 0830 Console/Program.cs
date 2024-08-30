using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0830_Console
{
    class Program
    { /// <summary>
      /// 
      /// </summary>
      /// <param name="args"></param>
        static void Main(string[] args)
        {
            int i = 1;           //ループ用
            int pattern = 0;     //選択肢
            int money = 1000;    //所持金

            int cnt1 = 0;
            int cnt2 = 0;
            int cnt3 = 0;

            const string goodsName1 = "魔法のステッキ";
            const string goodsName2 = "カリュドーンの弓";
            const string goodsName3 = "細木数子の六芒星スポナー";

            const int goods1 = 120;
            const int goods2 = 140;
            const int goods3 = 130;


            //Random rand = new Random();

            //int randomNum = rand.Next(400, 700);



            while (i == 1)
            {
                Console.Clear();
                Console.WriteLine("================");
                Console.WriteLine("    鍛冶屋      ");
                Console.WriteLine("================");
                Console.Write("1."+goodsName1 );
                Console.Write(goods1);
                Console.WriteLine("円");
                Console.Write("2." + goodsName2 );
                Console.Write(goods2);
                Console.WriteLine("円");
                Console.Write("3."+ goodsName3 );
                Console.Write(goods3);
                Console.WriteLine("円");
                Console.Write("所持金・・・");
                Console.Write(money);
                Console.WriteLine("円");

                Console.Write("\n購入する商品を選択してください(99で買い物終了)＞");
                string str = Console.ReadLine();



                bool isSuccess = int.TryParse(str, out pattern);

                if (isSuccess)
                {

                    if (pattern == 1)
                    {
                        if (money >= goods1)
                        {
                            cnt1++;
                            money -= goods1;
                            Console.WriteLine("\n"+goodsName1+"を購入した！");
                            Console.Write("財布から");
                            Console.Write(goods1);
                            Console.WriteLine("円がなくなった！");
                            Console.Write("残り所持金・・・");
                            Console.Write(money);
                            Console.WriteLine("円");
                        }
                        else
                        {
                            Console.WriteLine("お金が足りない！");
                        }
                        Console.ReadLine();
                    }

                    if (pattern == 2)
                    {
                        if (money >= goods2)
                        {
                            cnt2++;
                            money -= goods2;
                            Console.WriteLine("\n"+goodsName2+"を購入した！");
                            Console.Write("財布から");
                            Console.Write(goods2);
                            Console.WriteLine("円がなくなった！");
                            Console.Write("残り所持金・・・");
                            Console.Write(money);
                            Console.WriteLine("円");
                        }
                        else
                        {
                            Console.WriteLine("お金が足りない！");
                        }
                        Console.ReadLine();
                    }

                    if (pattern == 3)
                    {
                        if (money >= goods3)
                        {
                            cnt3++;
                            money -= goods3;
                            Console.WriteLine("\n"+goodsName3+"を購入した！");
                            Console.Write("財布から");
                            Console.Write(goods3);
                            Console.WriteLine("円がなくなった！");
                            Console.Write("残り所持金・・・");
                            Console.Write(money);
                            Console.WriteLine("円");
                        }
                        else
                        {
                            Console.WriteLine("お金が足りない！");
                        }
                        Console.ReadLine();
                    }


                    else if (pattern == 99)
                    {
                        i--;
                    }
                    else if (pattern <= 0 || pattern >= 4)
                    {
                        Console.Write("選択肢から選んでね");
                        Console.ReadLine();
                    }

                }
                else
                {
                    Console.Write("数字で入力してね");
                    Console.ReadLine();
                }
            }
            Console.Clear();
            Console.WriteLine("ご利用感謝！");
            Console.Write("\n"+goodsName1+"　　　　・・・");
            Console.Write(cnt1);
            Console.WriteLine("個");
            Console.Write(goodsName2+ "　　　　・・・");
            Console.Write(cnt2);
            Console.WriteLine("個");
            Console.Write(goodsName3 + "・・・");
            Console.Write(cnt3);
            Console.WriteLine("個");
            Console.Write("\n残金・・・");
            Console.Write(money);
            Console.WriteLine("円");
            //キー入力待ち

            Console.WriteLine("\nエンターキーを押して閉じる");
            Console.ReadLine();
        }
    }



}


