using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCoCaro
{
    public class Player
    {
        //ten
        private string name;

        public string Name
        {
            get { return name;  }
            set { name = value;  }
        }
        //hinh
        private Image mark;

        public Image Mark
        {
            get { return mark; }
            set { mark = value; }
        }
        //nguoi choi
        public Player(string name, Image mark)
        {
            this.Name = name;
            this.Mark = mark;
        }


    }
}
