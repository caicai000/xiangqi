using System;
namespace chinesechree
{
    public class Classchess
    {
        public abstract class Chess
        {
            public string Name;
            public string Color;
            public int i;
            public int j;
            public Boolean state;
            public string Job;

            public Chess(string Name, string Color, int i, int j, bool state, string Job)
            {
                this.Name = Name;
                this.Color = Color;
                this.i = i;
                this.j = j;
                this.state = state;

            }

            public int geti()
            {
                return i;
            }
            public int getj()
            {
                return j;
            }
            public string getname()
            {
                return Name;
            }
            public bool getstate()
            {
                return state;
            }
            public void killstate()
            {
                this.state = false;
            }
            public string getcolor()
            {
                return Color;
            }
            public void Introduciton()
            {
                Console.WriteLine($"Hi,I'm {Name}, {Color},live in ({i},{j}),{state}");

            }

        }
        public class shuai : Chess
        {
            public shuai(string Name, string Color, int i, int j, bool state)
                : base(Name, Color, i, j, true, "shuai") { }

        }
        public class shi : Chess
        {
            public shi(string Name, string Color, int i, int j, bool state)
                : base(Name, Color, i, j, true, "shi") { }
        }
        public class xiang : Chess
        {
            public xiang(string Name, string Color, int i, int j, bool state)
                : base(Name, Color, i, j, true, "xiang") { }
        }
        public class ma : Chess
        {
            public ma(string Name, string Color, int i, int j, bool state)
                : base(Name, Color, i, j, true, "ma") { }
        }
        public class che : Chess
        {
            public che(string Name, string Color, int i, int j, bool state)
                : base(Name, Color, i, j, true, "che") { }
        }
        public class pao : Chess
        {
            public pao(string Name, string Color, int i, int j, bool state)
                : base(Name, Color, i, j, true, "pao") { }
        }
        public class bing : Chess
        {
            public bing(string Name, string Color, int i, int j, bool state)
                : base(Name, Color, i, j, true, "bing") { }
        }
        public class jiang : Chess
        {
            public jiang(string Name, string Color, int i, int j, bool state)
                : base(Name, Color, i, j, true, "jiang") { }

        }
        public class wu : Chess
        {
            public wu(string Name, string Color, int i, int j, bool state)
                : base(Name, Color, i, j, true, "wu") { }
        }
    }
}
