namespace PR_14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int wX;
            int hX;
            double xF, yF;
            double step;

            wX = pictureBox1.Width;
            hX = pictureBox1.Height;

            Bitmap flag = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics FlagGraphics = Graphics.FromImage(flag);
            System.Drawing.Pen myPen;
            myPen = new System.Drawing.Pen(System.Drawing.Color.Blue);
            FlagGraphics.DrawLine(myPen, 0, (int)(hX/2), wX, (int)(hX / 2));
            FlagGraphics.DrawLine(myPen, (int)(wX / 2), 0, (int)(wX / 2), hX);

            for (step = 0; step <= 2 * Math.PI; step += 0.001)
            {
                xF = (step*25)+(int)(wX/2);
                double tmp = Math.Sin(step);
                tmp *= 50;
                yF = (int)(hX / 2) - tmp;
                flag.SetPixel((int)xF, (int)yF, Color.Red);
            }
            pictureBox1.Image = flag;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form Form2 = new Form2();
            Form2.Show();
        }
    }
}