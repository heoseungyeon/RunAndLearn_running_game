using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TeamProjectDemo
{
    class Sprite
    {
        protected int x; // 객체 x좌표
        protected int y; // 객제 y좌표
        protected int dx; // 단위시간당 x 이동거리 
        protected int dy; // 단위시간당 y 이동거리 
        protected Image image; // 객체가 가지고 있는 이미지
        protected System.Windows.Forms.PictureBox picture;
        
   

        //생성자
        public Sprite() { }
        public Sprite(System.Windows.Forms.PictureBox picture, int x, int y)
        {
            this.picture = picture;
            this.x = x;
            this.y = y;
            this.dx = 0;
            this.dy = 0;
        }

        //get/set
        public int X
        {
            get { return x; }

            set { this.x = value; }
        }
        public int Y
        {
            get { return y; }

            set { this.y = value; }
        }
        public int Dx
        {
            get { return dx; }

            set { this.dx = value; }
        }
        public int Dy
        {
            get { return dy; }

            set { this.dy = value; }
        }
        public int getWidth()
        {
            return image.Width;
        }
        public int getHeight()
        {
            return image.Height;
        }

        //funcitional
        public void draw(Graphics g)
        {
            g.DrawImage(image, new Point(this.x, this.y));
        }
        public void move()
        {
            picture.Location = new Point(this.X, picture.Location.Y + dy);
          
        }
        public bool checkCollision(Sprite other)
        {
            Rectangle myRect = new Rectangle();
            Rectangle otherRect = new Rectangle();

            myRect.Location = new Point(x, y);
            myRect.Size = new Size(getWidth(), getHeight());

            otherRect.Location = new Point(other.X, other.Y);
            otherRect.Size = new Size(other.getWidth(), other.getHeight());

            return myRect.IntersectsWith(otherRect);
        }
    }
}
