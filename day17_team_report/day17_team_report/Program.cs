namespace day17_team_report
{
    internal class Program
    {
        //상자를 열때(오픈박스) 상자 열림(오픈) 함수 진행
        public interface IOpenBox
        {
            public void OpenBox();
        }
        //던전 문을 열때 상호작용시(오픈던전) 던전 입장 함수 진행
        public interface IEnterDungeon
        {
            public void EnterDungeon();
        }
        //모코코를 주울때 상호작용시 겟모코코 함수 진행
        public interface IMokoko
        {
            public void GetMokoko();
        }
        // npc와 상호작용 시 (talkNpc) 함수 진행
        public interface INormalNpc
        {
            public void TalkNpc();
        }

        // 상인 npc 와 상호작용시 거래할수있는 함수 
        public interface IShopNpc
        {
            public void TradeNpc();
        }
        public class Player : IShopNpc
        {
            public void OpenBox(IOpenBox openBox)
            {
                Console.WriteLine("상자의 자물쇄를 해제하는 중입니다...");
            }

            public void EnterDungeon(IEnterDungeon enterDungeon)
            {
                Console.WriteLine("인스턴스 던전에 진입하는 중입니다.");
            }

            public void GetMokoko(IMokoko mokoko)
            {
                Console.WriteLine("기분좋은 향기가 솔솔 피어난다.");
            }

            public void TalkNpc(INormalNpc normalNpc)
            {
                Console.WriteLine("이 엔피시와 대화.");
            }

            public void TradeNpc()
            {
                Console.WriteLine("상점창을 연다.");
            }
        }

        public class Box : IOpenBox
        {
            public void OpenBox()
            {
                Console.WriteLine("상자가 열림");
            }
        }

        public class Dungeon : IEnterDungeon
        {
            public void EnterDungeon()
            {
                Console.WriteLine("인스턴스 던전에 진입하는 중입니다.");
            }
        }

        public class Mokoko : IMokoko
        {
            public void GetMokoko()
            {
                Console.WriteLine("기분좋은 향기가 솔솔 피어난다.");
            }
        }

        public class NormalNpc : INormalNpc
        {
            public void TalkNpc()
            {
                Console.WriteLine("이 엔피시와 대화.");
            }
        }
        static void Main(string[] args)
        {
            Player player = new Player();
            Box box = new Box();
            Dungeon dungeon = new Dungeon();
            Mokoko mokoko = new Mokoko();
            NormalNpc normalNpc = new NormalNpc();

            player.OpenBox(box);
            player.EnterDungeon(dungeon);
            player.GetMokoko(mokoko);
            player.TalkNpc(normalNpc);
            player.TradeNpc();

            box.OpenBox();
        }
    }
}
