namespace TextRPG;
class Program
{

    public void Intro()
    {
        string name;

        Console.WriteLine("스파르타 던전에 오신여러분 환영합니다 .");
        Console.WriteLine("원하시는 이름을 설정해주세요 .");
        name = Console.ReadLine();

        Console.WriteLine("입력하신 이름은 " + name + "입니다 .");


        Program newname = new Program();
        newname.Newname();
    }

    public void Newname()
    {
        Console.WriteLine("원하시는 행동을 입력해주세요. ");
        Console.WriteLine("1. 저장 \r\n2.취소");
        string newname = Console.ReadLine();

        switch (newname)
        {
            case "1":
                Console.WriteLine("저장 되셨습니다.");
                break;

            case "2":
                Console.WriteLine("취소 되셨습니다 처음으로 돌아갑니다.");
                Intro();
                break;
            default:
                Console.WriteLine("잘못된 입력입니다.");
                Newname();
                break;
        }
        Program job = new Program();
        job.Job();
    }
        
    public string Job()
    {
        Console.WriteLine("직업을 선택해 주세요. ");
        Console.WriteLine(" 1. 전사 \r\n 2. 궁수 \r\n 3. 도적 ");
        string job = Console.ReadLine();
        switch (job)
        {
            case "1":
                Console.WriteLine("전사를 선택하셨습니다.");
                break;
            case "2":
                Console.WriteLine("궁수를 선택하셨습니다.");
                break;
            case "3":
                Console.WriteLine("도적을 선택하셨습니다.");
                break;
            default:
                Console.WriteLine("잘못된 입력입니다 .");
                Job();
                break;
        }

        Program start = new Program();
        start.Start();
        return job;

    }

    public void Stats()
    {
        

        Console.WriteLine("상태 보기 \r\n 캐릭터의 정보가표시됩니다.");

        int[] playerstatsS = new int[1];
        
        Random statsS = new Random();
        for (int s = 0; s < playerstatsS.Length; s++)
        {
            playerstatsS[s] = statsS.Next(15, 20);
        }

        int[] playerstatsD = new int[1];

        Random statsD = new Random();
        for (int d = 0; d < playerstatsD.Length; d++)
        {
            playerstatsD[d] = statsD.Next(15, 20);
        }

        int[] playerstatsHP = new int[1];

        Random statsHP = new Random();
        for (int hp = 0; hp < playerstatsHP.Length; hp++)
        {
            playerstatsHP[hp] = statsHP.Next(150, 200);
        }
        Console.WriteLine("이름 :" );
        Console.WriteLine("Lv :" );
        Console.WriteLine("직업 : " );
        Console.WriteLine("공격력 : " + playerstatsS[0]);
        Console.WriteLine("방어력 : " + playerstatsD[0]);
        Console.WriteLine("체력 : " + playerstatsHP[0]);
        Console.WriteLine("Gold :");

        Program exit = new Program();
        exit.Exit();
    }

    public void Item()
    {

        Console.WriteLine("인벤토리 \n보유 중인 아이템을 관리할수 있습니다.\n");
        Console.WriteLine("[아이템 목록]");

        List<string> items = new List<string>();

        foreach(string item in items)
        {

            Console.WriteLine(item);
        }

        Program exit = new Program();
        exit.Exit();

    }
    public void Shop()
    {
        Console.WriteLine("상점 \n필요한 아이템을 얻을 수 있는 상점입니다.");
        Console.WriteLine("[보유골드]\n" + "G");

        List<string> shop = new List<string>();

        shop.Add("-수련자 갑옷 \t |방어력  +5\t |수련에 도움을 주는 갑옷입니다.\t| 1000G");
        shop.Add("- 무쇠갑옷\t| 방어력 +9\t| 무쇠로 만들어져 튼튼한 갑옷입니다.\t|구매완료");
        shop.Add("- 스파르타의 갑옷\t|방어력 +15\t|스파르타의 전사들이 사용했다는 전설의 갑옷입니다.\t3500 G");
        shop.Add("- 낡은 검\t| 공격력 +2\t| 쉽게 볼 수 있는 낡은 검 입니다.\t|  600 G");
        shop.Add("- 청동 도끼\t| 공격력 +5\t|어디선가 사용됐던거 같은 도끼입니다.\t|  1500 G");
        shop.Add("- 스파르타의 창\t| 공격력 +7\t| 스파르타의 전사들이 사용했다는 전설의 창입니다.\t|  구매완료");


    }
    


    public void Start()
    {
        Console.WriteLine("스파르타 던전에 오신 여러분 환영합니다.");
        Console.WriteLine("이곳에서 던전에 들어가기전 활동을 할수있습니다. ");

        Console.WriteLine("1.상태 보기 \n2.인벤토리 \n3.상점");

        Console.WriteLine("원하시는 행동을 입력해주세요.\n >>");

        string doing = Console.ReadLine();

        switch (doing)
        {
            case "1":
                Program stats = new Program();
                stats.Stats();
                break;

            case "2":
                Program inventory = new Program();
                inventory.Item();
                break;

            case "3":
                
                break;

            default:
                Start();
                break;


        }


    }
    public void Exit()
    {
        Console.WriteLine("\n 0.나가기\n 원하시는 행동을 입력해주세요 .\n >>");
        string exit = Console.ReadLine();
        switch (exit)
        {
            case "0":
                Start();
                break;

            default:
                Console.WriteLine("잘못된 입력입니다 .");
                Exit();
                break;
        }
    }

    static void Main(string[] args)
    {

        Program intro = new Program();
        intro.Intro();

        
        
    }
}