using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileStram_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            bool bFlag = true;

            while (bFlag == true)
            {
                Console.WriteLine("1. 서시");
                Console.WriteLine("2. 귀천");
                Console.WriteLine("3. 꽃 덤불");
                Console.WriteLine("4. 꽃");
                Console.WriteLine("5. 별 헤는 밤");
                Console.WriteLine("6. 수선화에게");
                Console.WriteLine("7. 타는 목마름으로");
                Console.WriteLine("8. 잰말놀이1");
                Console.WriteLine("9. 잰말놀이2");
                Console.WriteLine("10. 잰말놀이3");
                Console.Write("불러올 파일이름: ");

                try
                {
                    string fileName = Console.ReadLine();
                    using (StreamReader sr = new StreamReader(new FileStream($"{fileName}.txt", FileMode.Open, FileAccess.Read)))
                    {
                        list.Add(sr.ReadLine());

                        string item;
                        Console.WriteLine();
                        while ((item = sr.ReadLine()) != null)
                        {
                            Console.WriteLine(item);
                        }
                        Console.WriteLine();
                        Console.Write("계속하시겠습니까? (1. 예 / 2. 아니오)");
                        Console.WriteLine("숫자 입력");
                        int choice = int.Parse(Console.ReadLine());
                        if (choice == 1)
                        {
                            continue;
                        }
                        else if (choice == 2)
                        {
                            bFlag = false;
                        }
                    }
                }
                catch (Exception err)
                {
                    Console.WriteLine(err.Message);
                }
            }
        }
    }
}
