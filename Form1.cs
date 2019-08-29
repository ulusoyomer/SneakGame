using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
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

        Random random = new Random();
        List<Box> boxesList = new List<Box>();
        List<Box> sneaks = new List<Box>(); 
        Sneak sneak;
        int yon = 1;
        int durum = 1;
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
            sneak = new Sneak(boxesList,sneaks);
            AddFeed();
            timer1.Start();
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

            public void setQueue()
            {
                queue = true;
                feed = false;
                PictureBox.BackColor = Color.FromArgb(3,150,136);
            }

            public void setFeed()
            {
                feed = true;
                PictureBox.BackColor = Color.FromArgb(133,30,62);
            }

            public void setBack()
            {
                feed = false;
                queue = false;
                PictureBox.BackColor = Color.FromArgb(4,57,108);
            }
        }

        class Sneak
        {
            public List<Box> BoxesList { get; set; }
            public List<Box> Sneaks { get; set; }
            public int yon { get; set; }
            public int startPosition { get; set; }
            public Sneak(List<Box> boxesList,List<Box> sneaks)
            {
                startPosition = 35;
                BoxesList = boxesList;
                Sneaks = sneaks;
                boxesList[33].setQueue();
                Sneaks.Add(boxesList[33]);
                boxesList[34].setQueue();
                Sneaks.Add(boxesList[34]);
                boxesList[35].setQueue();
                Sneaks.Add(boxesList[35]);

            }

            public int move(int valu)
            {
                switch (valu)
                {
                    case 1:
                        startPosition += 1;
                        break;
                    case 2:
                        startPosition += 25;
                        break;
                    case 3:
                        startPosition -= 1;
                        break;
                    case 4:
                        startPosition -= 25;
                        break;
                }

                if (BoxesList[startPosition].Wall || BoxesList[startPosition].queue)
                {
                    return 1;
                }
                else if(BoxesList[startPosition].feed)
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
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

        public void AddFeed()
        {
            int a = random.Next(0, 750);
            if (boxesList[a].Wall || boxesList[a].queue)
            {
                AddFeed();
            }
            else
            {
                boxesList[a].setFeed();
            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            int deger = sneak.move(yon);
            if (deger == 1)
            {
                timer1.Stop();
                durum = 0;
            }
            else if (deger == 2)
            {
                boxesList[sneak.startPosition].setQueue();
                sneaks.Add(boxesList[sneak.startPosition]);
                AddFeed();
                labelScore.Text = Convert.ToString(Convert.ToInt32(labelScore.Text) + 10);
            }
            else
            {
                sneaks[0].setBack();
                sneaks.RemoveAt(0);
                boxesList[sneak.startPosition].setQueue();
                sneaks.Add(boxesList[sneak.startPosition]);
            }

        }

        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (keyData == Keys.Up)
            {
                if (yon != 2)
                {
                    yon = 4;
                }
            }
            else if (keyData == Keys.Down)
            {
                if (yon != 4)
                {
                    yon = 2;
                }
            }
            else if (keyData == Keys.Left)
            {
                if (yon != 1)
                {
                    yon = 3;
                }
            }
            else if(keyData == Keys.Right)
            {
                if (yon != 3)
                {
                    yon = 1;
                }
            }
            return base.ProcessDialogKey(keyData);
        }

        private void ButtonStop_Click(object sender, EventArgs e)
        {
            if (String.Equals(buttonStop.Text,"Durdur") && durum != 0)
            {
                timer1.Stop();
                buttonStop.Text = "Başlat";
            }
            else if (durum == 0)
            {
                
            }
            else
            {
                buttonStop.Text = "Durdur";
                timer1.Start();
            }
        }

        private void ButtonRe_Click(object sender, EventArgs e)
        {
            if (durum == 0)
            {
                foreach (Box box in boxesList)
                {
                    box.setBack();
                }

                yon = 1;
                Walls();
                durum = 1;
                sneaks.Clear();
                sneak = new Sneak(boxesList,sneaks);
                labelScore.Text = "0";
                AddFeed();
                timer1.Start();
            }
        }
    }
}
