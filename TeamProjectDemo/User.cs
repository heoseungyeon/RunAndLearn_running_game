using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Threading;

namespace TeamProjectDemo
{
    class User : Sprite
    {
        protected int hp;
        protected int score;
        protected int deathCount;
        protected int superCount;

        public User(System.Windows.Forms.PictureBox picture, int x, int y) : base(picture, x, y)
        {
            hp = 100;
            score = 0;
            deathCount = 0;
            superCount = 0;
        }

        public void Jump()
        {

            dy = -1;
            while (picture.Location.Y > 100)
            {
                move();
                Thread.Sleep(1);
            }
            dy = +1;
            while (picture.Location.Y != 200)
            {
                move();
                Thread.Sleep(1);
            }
        }
    }
}
