using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TeamProjectDemo
{
    class Obstacle : Sprite
    {
        enum Obstacles
        {
            Beer, Duck
        }
        protected int plusHp;
        protected int ObstacleName;

        public Obstacle(System.Windows.Forms.PictureBox picture, int x, int y) : base(picture, x, y)
        {
            this.x = 600;
            this.y = this.getHeight();
        }
    }
}
