using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR_14
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        protected override void OnPaint(PaintEventArgs e)
        {
            const int minX = -2;
            const int maxX = 5;

            PointF[] points = new PointF[maxX-minX];
            for (int i = 0; i<points.Length; i++)
            {
                float x = i + minX;
                if(x<=3) points[i] = new PointF(x,2-x);
                else points[i] = new PointF(x,x*x);
            }

            float w = this.ClientSize.Width;
            float h = this.ClientSize.Height;
            float minY = points[0].Y;
            float maxY = points[0].Y;

            for (int i = 1; i < points.Length; i++)
            {
                if (minY > points[i].Y) minY = points[i].Y;
                if (maxY < points[i].Y) maxY = points[i].Y;
            }

            for(int i = 0; i < points.Length; i++)
            {
                points[i].X = w * (points[i].X-minX)/(maxX-minX);
                points[i].Y =h-h* (points[i].Y-minY)/(maxY-minY);
            }
            e.Graphics.DrawLines(Pens.Blue, points);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form Form3 = new Form3();
            Form3.Show();
        }
    }
}
