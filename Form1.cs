using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace feniks
{
    public partial class Forma : Form
    {
        Graphics Graph;
        Font MyFont = new Font("Arial", 10, FontStyle.Bold);
        SolidBrush MyBrush = new SolidBrush(Color.Black);
        Pen MyPen = new Pen(Color.Black);
        public Forma()
        {
            InitializeComponent();
            Graph = CreateGraphics();
        }
        private void Forma_Shown(object sender, EventArgs e)
        {
            this.MinimumSize = new Size(150, 150);
            Text = this.ClientSize.Width.ToString() + " на " + this.ClientSize.Height.ToString();
        }
        private void Forma_Resize(object sender, EventArgs e)
        {
            Graph = CreateGraphics();
            Text = this.ClientSize.Width.ToString() + " на " + this.ClientSize.Height.ToString();
            Graph.Clear(BackColor);
            Graph.DrawString("Координаты: " + this.Top + "/" + this.Left, MyFont, MyBrush, 30, 30);
            Graph.DrawEllipse(MyPen, this.ClientSize.Width / 2 - 15, this.ClientSize.Height / 2 - 15, 30, 30);
        }
        private void Forma_LocationChanged(object sender, EventArgs e)
        {
            Graph = CreateGraphics();
            Graph.Clear(BackColor);
            Graph.DrawString("Координаты: " + this.Top + "/" + this.Left, MyFont, MyBrush, 30, 30);
            Graph.DrawEllipse(MyPen, this.ClientSize.Width / 2 - 15, this.ClientSize.Height / 2 - 15, 30, 30);
        }
        private void Forma_Load(object sender, EventArgs e)
        {
            MyFont = new Font("Arial", 10, FontStyle.Bold);
            MyBrush = new SolidBrush(Color.Black);
        }
        private void Forma_Paint(object sender, PaintEventArgs e)
        {
            Graph.Clear(BackColor);
            Graph.DrawString("Координаты: " + this.Top + "/" + this.Left, MyFont, MyBrush, 30, 30);
            Graph.DrawEllipse(MyPen, this.ClientSize.Width / 2 - 15, this.ClientSize.Height / 2 - 15, 30, 30);
        }
    }
}
