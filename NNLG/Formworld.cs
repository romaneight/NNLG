using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NNLG
{
    public partial class Formworld : Form
    {
        int CountOfBots = 500;
        private int height = 800;
        private int width = 800;
        private int SizeOfSides = 10;
        List<PictureBox> Bots = new List<PictureBox>();
        public Formworld()
        {
            InitializeComponent();
            this.Height = height;
            this.Width = width;
            CreateBots(Bots);
            Console.WriteLine("fg"+Bots.Count);
        }
        void CreateBots(List<PictureBox> Bots)
        {
            Random random = new Random();
            for (int i = 0; i < CountOfBots; i++)
            {
                PictureBox bot = new PictureBox();
                bot.BackColor = Color.Blue;
                bot.Size = new Size(SizeOfSides, SizeOfSides);
                bot.Location = new Point(random.Next(0,800), random.Next(0,800));
                Bots.Add(bot);
                this.Controls.Add(Bots[i]);
            }
        }
    }
}
