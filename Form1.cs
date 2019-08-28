using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YilanOyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

         
        List<Box> boxesList = new List<Box>();
        private void Form1_Load(object sender, EventArgs e)
        {
            
            int size = 18;
            int x = 0;
            int y = 0;
            int margin = 2;
            for (int i = 0; i < 750; i++)
            {
                Box box = new Box(new Point(x,y),new Size(size,size),i,panel1);
                x += size + margin ;
                boxesList.Add(box);
                if ((i+1) % 25 == 0)
                {
                    y += size + margin;
                    x = 0;
                }
                
            }
            Walls();
        }

        class Box
        {
            public Point Location { get; set; }
            public Color Color { get; set; }
            public Size Size { get; set; }
            public int indis { get; set; }
            public Panel Panel { get; set; }
            public PictureBox PictureBox { get; set; }
            public bool Wall { get; set; }
            public bool feed { get; set; }
            public bool queue { get; set; }

            public Box(Point point,Size size,int indis,Panel panel)
            {
                Location = point;
                Size = size;
                this.indis = indis;
                Panel = panel;
                CreatePictureBox();
                Wall = false;
                feed = false;
                queue = false;
            }

            public void CreatePictureBox()
            {
                PictureBox = new PictureBox();
                PictureBox.Size = Size;
                PictureBox.Location = Location;
                PictureBox.BackColor = Color.FromArgb(4,57,108);
                Panel.Controls.Add(PictureBox);
            }

            public void setWall()
            {
                Wall = true;
                PictureBox.BackColor = Color.FromArgb(74,78,77);
            }
        }

        private void Label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void Walls()
        {
            for (int i = 0; i <=24; i++)
            {
                boxesList[i].setWall();
            }

            for (int i = 0; i <= 725; i+=25)
            {
                boxesList[i].setWall();
            }
            for (int i = 725; i <750; i++)
            {
                boxesList[i].setWall();
            }
            for (int i = 24; i <= 725; i+=25)
            {
                boxesList[i].setWall();
            }
        }
    }
}
