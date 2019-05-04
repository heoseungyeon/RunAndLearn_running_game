using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TeamProjectDemo
{
    class Item : Sprite
    {
        enum Items
        {
            Hotsix, Jokbo, Soju
        }
        protected int plusHp;
        protected int itemName;

        public Item(System.Windows.Forms.PictureBox picture, int x, int y) : base(picture, x, y)
        {
            this.x = 600;
        }
    }
}
