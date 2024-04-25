using System.Runtime.CompilerServices;

namespace SpartaDungeon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program pg = new Program();
            pg.mainScene();                                         //메인화면 불러옴
        }

        void mainScene()                                            // 메인화면 함수
        {
            Console.WriteLine("\n 스파르타 마을에 오신 여러분 환영합니다.\n 이곳에서 던전으로 들어가기전 활동을 할 수 있습니다.\n");
            Console.WriteLine(" 1. 상태 보기\n\n 2. 인벤토리\n\n 3. 상점\n");
            Console.Write(" 원하시는 행동을 입력해 주세요.\n >> ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    statusCheck();                                  // 스탯확인 창
                    exit();
                    break;// 메인 창 이동
                case "2":
                    inventory();                                    // 인벤토리 창
                    break;
                case "3":
                    shop();                                         // 상점 창
                    break;
                default:
                    Console.Write(wrong);                           // 재선택
                    Console.ReadLine();
                    Console.Clear();
                    mainScene();
                    break;
            }
        }
        // 문자열 대체 관련
        string pre = "\n 0. 나가기\n\n 원하시는 행동을 입력해 주세요.\n >> ";
        string wrong = " 잘못된 입력입니다. 아무 버튼이나 누르세요.\n >> ";
        string anybutton = " 아무 버튼이나 누르세요.\n >> ";

        void statusCheck()                                          // 스탯확인창 함수
        {
            Console.Clear();
            Console.WriteLine("\n 상태 보기\n 캐릭터의 정보가 표시됩니다.");
            Console.WriteLine($"\n Lv. {level}\n\n {name}\n\n 공격력 : {atk}\n\n 방어력 : {def}\n\n 체력 : {hp}\n\n Gold : {gold} G");
        }
        // stat 관련
        int level = 1;
        string name = "Chad (전사)";
        int atk = 10;
        int def = 5;
        int hp = 100;
        int gold = 1500;

        void inventory()                                            // 인벤토리 함수
        {
            string equiped = "[E]";
            string sentence_1 = ($" {item_1}       | 방어력 +5  | 무쇠로 만들어져 튼튼한 갑옷입니다.");
            string sentence_2 = ($" {item_2}   | 공격력 +7  | 스파르타의 전사들이 사용했다는 전설의 창입니다.");
            string sentence_3 = ($" {item_3}         | 공격력 +2  | 쉽게 볼 수 있는 낡은 검 입니다.");
            string sentence_4 = ($" {item_4}     | 방어력 +5  | 수련에 도움을 주는 갑옷입니다.");
            string sentence_5 = ($" {item_5} | 방어력 +15 | 스파르타의 전사들이 사용했다는 전설의 갑옷입니다.");
            string sentence_6 = ($" {item_6}       | 공격력 +5  |  어디선가 사용됐던거 같은 도끼입니다.");

            Console.Clear();
            Console.WriteLine("\n 인벤토리\n 보유 중인 아이템을 관리할 수 있습니다.\n\n [아이템 목록]\n\n 1. 장착 관리");

            if (sentence_1.Contains(equiped) == true)               // [E]가 있으면 문장이 보임  
            {
                Console.WriteLine("\n" + sentence_1);
            }
            if (sentence_2.Contains(equiped) == true)               // [E]가 있으면 문장이 보임
            {
                Console.WriteLine("\n" + sentence_2);
            }
            if (sentence_3.Contains(equiped) == true)               // [E]가 있으면 문장이 보임
            {
                Console.WriteLine("\n" + sentence_3);
            }
            if (sentence_4.Contains(equiped) == true)
            {
                Console.WriteLine("\n" + sentence_4);
            }
            if (sentence_5.Contains(equiped) == true)
            {
                Console.WriteLine("\n" + sentence_5);
            }
            if (sentence_6.Contains(equiped) == true)
            {
                Console.WriteLine("\n" + sentence_6);
            }
            Console.Write(pre);
            string choice = Console.ReadLine();


            switch (choice)
            {
                case "0":                               // 0 선택시 메인화면
                    Console.Clear();
                    mainScene();
                    break;
                case "1":                               // 1 선택시 장착 관리창
                    eq_manage();
                    break;
                default:                                // 재선택
                    Console.Write(wrong);
                    Console.ReadLine();
                    Console.Clear();
                    inventory();
                    break;
            }


        }

        public void eq_manage()                                     //장착 관리창 함수
        {

            string equiped = "[E]";
            string sentence_1 = ($" - 1 {item_1}       | 방어력 +5  | 무쇠로 만들어져 튼튼한 갑옷입니다.");
            string sentence_2 = ($" - 2 {item_2}   | 공격력 +7  | 스파르타의 전사들이 사용했다는 전설의 창입니다.");
            string sentence_3 = ($" - 3 {item_3}         | 공격력 +2  | 쉽게 볼 수 있는 낡은 검 입니다.");
            string sentence_4 = ($" - 4 {item_4}     | 방어력 +5  | 수련에 도움을 주는 갑옷입니다.");
            string sentence_5 = ($" - 4 {item_6}       | 공격력 +5  |  어디선가 사용됐던거 같은 도끼입니다.");

            Console.Clear();
            Console.WriteLine("\n 인벤토리 - 장착관리\n 보유 중인 아이템을 관리할 수 있습니다.\n\n [아이템 목록]");
            Console.WriteLine("\n" + sentence_1);
            Console.WriteLine("\n" + sentence_2);
            Console.WriteLine("\n" + sentence_3);
            if (gold == 500)
            {
                Console.WriteLine("\n" + sentence_4);
            }
            if (gold == 0)
            {
                Console.WriteLine("\n" + sentence_5);
            }

            Console.Write(pre);
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "0":                                           // 인벤토리 창으로 이동
                    Console.Clear();
                    inventory();
                    break;
                case "1":
                    if (sentence_1.Contains(equiped) == true)       // 문자에 [E]가 있으면 [E] 제거, def 감소
                    {
                        item_1 = "무쇠 갑옷";
                        def -= 5;
                        Console.Clear();
                        eq_manage();
                    }
                    else                                            // 문자에 [E]가 없으면 [E] 생성, def 증가
                    {
                        item_1 = "[E]무쇠 갑옷";
                        def += 5;
                        Console.Clear();
                        eq_manage();
                    }
                    break;
                case "2":
                    if (sentence_2.Contains(equiped) == true)       // 문자에 [E]가 있으면 [E] 제거, atk 감소
                    {
                        item_2 = "스파르타의 창";
                        atk -= 7;
                        Console.Clear();
                        eq_manage();
                    }
                    else                                            // 문자에 [E]가 없으면 [E] 생성, atk 증가
                    {
                        item_2 = "[E]스파르타의 창";
                        atk += 7;
                        Console.Clear();
                        eq_manage();
                    }
                    break;
                case "3":
                    if (sentence_3.Contains(equiped) == true)       // 문자에 [E]가 있으면 [E] 제거, atk 감소
                    {
                        item_3 = "낡은 검";
                        atk -= 2;
                        Console.Clear();
                        eq_manage();
                    }
                    else                                            // 문자에 [E]가 없으면 [E] 생성, atk 증가
                    {
                        item_3 = "[E]낡은 검";
                        atk += 2;
                        Console.Clear();
                        eq_manage();
                    }
                    break;
                case "4":
                    if (gold == 500)
                    {
                        if (sentence_4.Contains(equiped) == true)   // 문자에 [E]가 있으면 [E] 제거, def 감소
                        {
                            item_4 = "수련자 갑옷";
                            def -= 5;
                            Console.Clear();
                            eq_manage();
                        }
                        else                                        // 문자에 [E]가 없으면 [E] 생성, def 증가
                        {
                            item_4 = "[E]수련자 갑옷";
                            def += 5;
                            Console.Clear();
                            eq_manage();
                        }
                    }
                    else if (gold == 0)
                    {
                        if (sentence_5.Contains(equiped) == true)   // 문자에 [E]가 있으면 [E] 제거, atk 감소
                        {
                            item_6 = "청동 도끼";
                            atk -= 5;
                            Console.Clear();
                            eq_manage();
                        }
                        else                                        // 문자에 [E]가 없으면 [E] 생성, atk 증가
                        {
                            item_6 = "[E]청동 도끼";
                            atk += 5;
                            Console.Clear();
                            eq_manage();
                        }
                    }
                    else                                            // 재선택
                    {
                        Console.Write(wrong);
                        Console.ReadLine();
                        Console.Clear();
                        eq_manage();
                    }
                    break;
                default:                                            // 재선택
                    Console.Write(wrong);
                    Console.ReadLine();
                    Console.Clear();
                    eq_manage();
                    break;
            }
        }

        // 아이템 관련                  class 사용하면 폐기 가능
        string item_1 = "무쇠 갑옷";
        string item_2 = "스파르타의 창";
        string item_3 = "낡은 검";
        string item_4 = "수련자 갑옷";
        string item_5 = "스파르타의 갑옷";
        string item_6 = "청동 도끼";
        string item_4_gold = "1000 G";
        string item_5_gold = "3500 G";
        string item_6_gold = "1500 G";

        void shop()                                                 // 상점 함수
        {
            string bought = "구매완료";
            string sentence_1 = ($" - 2 무쇠 갑옷       | 방어력 +5  | 무쇠로 만들어져 튼튼한 갑옷입니다.               |  {bought}");
            string sentence_2 = ($" - 6 스파르타의 창   | 공격력 +7  | 스파르타의 전사들이 사용했다는 전설의 창입니다.  |  {bought}");
            string sentence_3 = ($" - 4 낡은 검         | 공격력 +2  | 쉽게 볼 수 있는 낡은 검 입니다.                  |  {bought}");
            string sentence_4 = ($" - 1 수련자 갑옷     | 방어력 +5  | 수련에 도움을 주는 갑옷입니다.                   |  {item_4_gold}");
            string sentence_5 = ($" - 3 스파르타의 갑옷 | 방어력 +15 | 스파르타의 전사들이 사용했다는 전설의 갑옷입니다.|  {item_5_gold}");
            string sentence_6 = ($" - 5 청동 도끼       | 공격력 +5  |  어디선가 사용됐던거 같은 도끼입니다.            |  {item_6_gold}");

            Console.Clear();
            Console.WriteLine("\n 상점\n 필요한 아이템을 얻을 수 있는 상점입니다.");
            Console.WriteLine($"\n [보유골드]\n {gold} G\n\n [아이템 목록]");
            Console.WriteLine("\n" + sentence_4);
            Console.WriteLine("\n" + sentence_1);
            Console.WriteLine("\n" + sentence_5);
            Console.WriteLine("\n" + sentence_3);
            Console.WriteLine("\n" + sentence_6);
            Console.WriteLine("\n" + sentence_2);
            Console.Write(pre);

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "0":                                                           // 메인 화면
                    Console.Clear();
                    mainScene();
                    Console.ReadLine();
                    break;
                case "1":                                                           // 수련자 갑옷 구매
                    if (sentence_4.Contains(bought) == false)
                    {
                        gold -= 1000;
                        if (gold < 0)
                        {
                            Console.WriteLine(" Gold가 부족합니다.");
                            Console.Write(anybutton);
                            gold += 1000;
                        }
                        else
                        {
                            item_4_gold = bought;
                            Console.WriteLine(" 구매를 완료했습니다.");
                            Console.Write(anybutton);
                        }
                    }
                    else
                    {
                        Console.WriteLine(" 이미 구매한 아이템입니다.");
                        Console.Write(anybutton);
                    }
                    Console.ReadLine();
                    Console.Clear();
                    shop();
                    break;
                case "2":                                                             // 무쇠 갑옷 구매
                    Console.WriteLine(" 이미 구매한 아이템입니다.");
                    Console.Write(anybutton);
                    Console.ReadLine();
                    Console.Clear();
                    shop();
                    break;
                case "3":                                                             // 스파르타의 갑옷 구매
                    if (sentence_5.Contains(bought) == false)
                    {
                        gold -= 3500;
                        if (gold < 0)
                        {
                            Console.WriteLine(" Gold가 부족합니다.");
                            Console.Write(anybutton);
                            gold += 3500;
                        }
                        else
                        {
                            item_5_gold = bought;
                            Console.WriteLine(" 구매를 완료했습니다.");
                            Console.Write(anybutton);
                        }
                    }
                    else
                    {
                        Console.WriteLine(" 이미 구매한 아이템입니다.");
                        Console.Write(anybutton);
                    }
                    Console.ReadLine();
                    Console.Clear();
                    shop();
                    break;
                case "4":                                                               // 낡은 검 구매
                    Console.WriteLine(" 이미 구매한 아이템입니다.");
                    Console.Write(anybutton);
                    Console.ReadLine();
                    Console.Clear();
                    shop();
                    break;
                case "5":                                                               // 청동 도끼 구매
                    if (sentence_6.Contains(bought) == false)
                    {
                        gold -= 1500;
                        if (gold < 0)
                        {
                            Console.WriteLine(" Gold가 부족합니다.");
                            Console.Write(anybutton);
                            gold += 1500;
                        }
                        else
                        {
                            item_6_gold = bought;
                            Console.WriteLine(" 구매를 완료했습니다.");
                            Console.Write(anybutton);
                        }
                    }
                    else
                    {
                        Console.WriteLine(" 이미 구매한 아이템입니다.");
                        Console.Write(anybutton);
                    }
                    Console.ReadLine();
                    Console.Clear();
                    shop();
                    break;
                case "6":                                                                   // 스파르타의 창 구매
                    Console.WriteLine(" 이미 구매한 아이템입니다.");
                    Console.Write(anybutton);
                    Console.ReadLine();
                    Console.Clear();
                    shop();

                    break;
                default:                                                                    // 상점 창
                    Console.Write(wrong);
                    Console.ReadLine();
                    Console.Clear();
                    shop();
                    break;
            }

        }

        void exit()                                                 // 0 누르면 메인 창으로가는 함수
        {
            Console.Write(pre);
            string choice = Console.ReadLine();

            switch (choice)                                          // 메인창 이동
            {
                case "0":
                    Console.Clear();
                    mainScene();
                    break;
                default:                                            // 재선택
                    Console.Write(wrong);
                    Console.ReadLine();
                    Console.Clear();
                    statusCheck();
                    exit();
                    break;
            }
        }

        public class Item
        {
            public string Name;
            public string Description;
            public int Price;
            public int Atk;
            public int Def;
            public bool Equiped;
            public bool Owned;

            public Item (string name, string description, int price, int atk, int def, bool owned)
            {
                Name = name;
                Description = description;
                Price = price;
                Atk = atk;
                Def = def;
                Equiped = false;
                Owned = owned;
            }
        }
        static List<Item> items = new List<Item>();
        // 이걸 사용하는 함수에 넣어야 함 ironArmor.Name 과 같은 형식으로 사용 가능
        Item ironArmor = new Item("무쇠 갑옷", "       | 방어력 +5  | 무쇠로 만들어져 튼튼한 갑옷입니다.", 0, 0, 5, true);
        Item spartaSpear = new Item("스파르타의 창", "   | 공격력 +7  | 스파르타의 전사들이 사용했다는 전설의 창입니다.", 0, 7, 0, true);
        Item rustySword = new Item("녹슨 검", "         | 공격력 + 2 | 쉽게 볼 수 있는 낡은 검 입니다.", 0, 0, 2, true);
        Item trainingArmor = new Item("수련자 갑옷", "     | 방어력 +5  | 수련에 도움을 주는 갑옷입니다.", 1000, 0, 5, false);
        Item spartaArmor = new Item("스파르타의 갑옷", " | 방어력 +15 | 스파르타의 전사들이 사용했다는 전설의 갑옷입니다.", 3500, 0, 15, false);
        Item bronzeAxe = new Item("청동 도끼", "       | 공격력 +5  |  어디선가 사용됐던거 같은 도끼입니다.", 1500, 5, 0, false);
    }
}