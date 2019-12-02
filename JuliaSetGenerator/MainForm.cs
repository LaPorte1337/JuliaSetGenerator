using System;
using System.Drawing;
using System.Media;
using System.Windows.Forms;

namespace JuliaSetGenerator
{
    public partial class MainForm : Form
    {
        const int maxIterations = 500;

        double cRe, cIm;
        ulong zoom;
        double deltaX;
        double deltaY;

        Color backgroundColor;
        Color foregroundColor;

        public MainForm()
        {
            InitializeComponent();
            backgroundColor = new Color();
            foregroundColor = new Color();

            backgroundColor = Color.Black;
            foregroundColor = Color.White;

            cRe = -0.8;
            cIm = -0.1;
            tbReCValue.Text = Convert.ToString(-0.8);
            tbImCValue.Text = Convert.ToString(-0.1);

            tbPictureHeight.Text = pictureBox1.Height.ToString();
            tbPictureWidth.Text = pictureBox1.Width.ToString();

            comboBox1.DataSource = new string[] { "красный", "зеленый", "синий", "желтый", "бирюзовый", "фиолетовый", "серый" };
        }

        private void DrawFractal(int w, int h, Graphics g, Pen pen, Color bColor, Color fColor)
        {
            double newRe, newIm, oldRe, oldIm;

            for (int x = 0; x < h; x++)
                for (int y = 0; y < w; y++)
                {
                    newRe = (x - w / 2) / (0.5 * zoom * w) + deltaX;
                    newIm = (y - h / 2) / (0.5 * zoom * h) - deltaY;

                    int i;

                    for (i = 0; i < maxIterations; i++)
                    {
                        oldRe = newRe;
                        oldIm = newIm;

                        newRe = oldRe * oldRe - oldIm * oldIm + cRe;
                        newIm = 2 * oldRe * oldIm + cIm;

                        if ((newRe * newRe + newIm * newIm) > 4)
                        {
                            pen.Color = bColor;
                            break;
                        }
                        else
                        {
                            pen.Color = fColor;
                        }
                    }

                    g.DrawRectangle(pen, x, y, 1, 1);
                }
        }

        private void DrawFractal(int w, int h, Graphics g, Pen pen)
        {
            double newRe, newIm, oldRe, oldIm;
            int maxIterations = 1000;
            
            for (int x = 0; x < w; x++)
                for (int y = 0; y < h; y++)
                {
                    newRe = (x - w / 2) / (0.5 * zoom * w) + deltaX;
                    newIm = (y - h / 2) / (0.5 * zoom * h) - deltaY;

                    int i;

                    for (i = 0; i < maxIterations; i++)
                    {
                        oldRe = newRe;
                        oldIm = newIm;

                        newRe = oldRe * oldRe - oldIm * oldIm + cRe;
                        newIm = 2 * oldRe * oldIm + cIm;

                        if ((newRe * newRe + newIm * newIm) > 4)
                        {
                            break;
                        }
                    }

                    pen.Color = ColorCheck(i);
                    g.DrawRectangle(pen, x, y, 1, 1);
                }
        }

        private void DrawMandelbrotSet(int w, int h, Graphics g, Pen pen)
        {
            for (int i = 0; i < w; i++)
            {
                for (int j = 0; j < h; j++)
                {
                    Complex z = new Complex(0, 0);
                    int k = 0;
                    while (k < maxIterations && z.re * z.re + z.im * z.im < 4)
                    {
                        z = Complex.Sqr(z) + new Complex((j - h / 2) / (0.5 * zoom * h) + deltaX, (i - w / 2) / (0.5 * zoom * w) - deltaY);
                        ++k;
                    }
                    if (z.re * z.re + z.im * z.im >= 4)
                    {
                        pen.Color = ColorCheck(k);
                        g.DrawRectangle(pen, j, i, 1, 1);
                    }
                    else
                    {
                        pen.Color = Color.FromArgb(0, 0, 0);
                        g.DrawRectangle(pen, j, i, 1, 1);
                    }
                }
            }
        }

        private void DrawMandelbrotSet(int w, int h, Graphics g, Pen pen, Color bColor, Color fColor)
        {
            for (int i = 0; i < w; i++)
            {
                for (int j = 0; j < h; j++)
                {
                    Complex z = new Complex(0, 0);
                    int k = 0;
                    while (k < maxIterations && (z.re * z.re) + (z.im * z.im) < 4)
                    {
                        z = Complex.Sqr(z) + new Complex(((j - (h / 2)) / (0.5 * zoom * h)) + deltaX, ((i - (w / 2)) / (0.5 * zoom * w)) - deltaY);
                        ++k;
                    }
                    if ((z.re * z.re) + (z.im * z.im) >= 4)
                    {
                        pen.Color = bColor;
                        g.DrawRectangle(pen, j, i, 1, 1);
                    }
                    else
                    {
                        pen.Color = fColor;
                        g.DrawRectangle(pen, j, i, 1, 1);
                    }
                }
            }
        }

        private Color ColorCheck(int i)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    return Color.FromArgb(255, i * 10 % 255, 0, 0);
                case 1:
                    return Color.FromArgb(255, 0, i * 10 % 255, 0);
                case 2:
                    return Color.FromArgb(255, 0, 0, i * 10 % 255);
                case 3:
                    return Color.FromArgb(255, i * 10 % 255, i * 10 % 255, 0);
                case 4:
                    return Color.FromArgb(255, 0, i * 10 % 255, i * 10 % 255);
                case 5:
                    return Color.FromArgb(255, i * 10 % 255, 0, i * 10 % 255);
                case 6:
                    return Color.FromArgb(255, i * 10 % 255, i * 10 % 255, i * 10 % 255);
                default:
                    return Color.FromArgb(255, 0, 0, 0);
            }
        }
        
        private void Draw_Click(object sender, EventArgs e)
        {
            try
            {
                pictureBox1.Height = int.Parse(tbPictureHeight.Text);
                pictureBox1.Width = int.Parse(tbPictureWidth.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
            }

            try
            {
                cRe = double.Parse(tbReCValue.Text);
                cIm = double.Parse(tbImCValue.Text);

                Pen myPen = new Pen(Color.Black, 1);
                Bitmap bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                Graphics g = Graphics.FromImage(bitmap);
                pictureBox1.Image = bitmap;
                zoom = ulong.Parse(tbZoomValue.Text);
                deltaX = double.Parse(tbDeltaXValue.Text);
                deltaY = double.Parse(tbDeltaYValue.Text);

                if (radioButton1.Checked == true && checkBox1.Checked == false)
                {
                    DrawFractal(pictureBox1.Width, pictureBox1.Height, g, myPen, backgroundColor, foregroundColor);
                }
                if (radioButton2.Checked == true && checkBox1.Checked == false)
                {
                    DrawFractal(pictureBox1.Width, pictureBox1.Height, g, myPen);
                }
                if (radioButton1.Checked == true && checkBox1.Checked == true)
                {
                    DrawMandelbrotSet(pictureBox1.Width, pictureBox1.Height, g, myPen, backgroundColor, foregroundColor);
                }
                if (radioButton2.Checked == true && checkBox1.Checked == true)
                {
                    DrawMandelbrotSet(pictureBox1.Width, pictureBox1.Height, g, myPen);
                }
                SystemSounds.Beep.Play();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                SaveFileDialog sfd = new SaveFileDialog
                {
                    Title = "Сохранить",
                    OverwritePrompt = true,
                    CheckPathExists = true,
                    Filter = "Image File (.png)|*.png"
                };

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        pictureBox1.Image.Save(sfd.FileName);
                        MessageBox.Show("Сохранение завершено успешно", "Готово", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Ошибка");
                    }
                }
            }
            else
            {
                MessageBox.Show("Нема картинки");
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            try
            {
                pictureBox1.Height = int.Parse(tbPictureHeight.Text);
                pictureBox1.Width = int.Parse(tbPictureWidth.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
            }
        }

        private void BtnBackroundColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog
            {
                AnyColor = true
            };
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    backgroundColor = colorDialog.Color;
                    Graphics graphics = Graphics.FromHwnd(pbBColor.Handle);
                    Pen pen = new Pen(backgroundColor, 25);
                    graphics.DrawRectangle(pen, 0, 0, 25, 25);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка");
                }
            }
            else
            {
                MessageBox.Show("Цвет не выбран");
            }
        }

        private void BtnForegroundColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog
            {
                AnyColor = true
            };
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    foregroundColor = colorDialog.Color;
                    Graphics graphics = Graphics.FromHwnd(pbFColor.Handle);
                    Pen pen = new Pen(foregroundColor, 25);
                    graphics.DrawRectangle(pen, 0, 0, 25, 25);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка");
                }
            }
            else
            {
                MessageBox.Show("Цвет не выбран");
            }
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            radioButton2.Checked = true;
        }

        private void Mandelbrot_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                tbReCValue.Enabled = false;
                tbImCValue.Enabled = false;
                btnRandomGenerate.Enabled = false;
            }
            else
            {
                tbReCValue.Enabled = true;
                tbImCValue.Enabled = true;
                btnRandomGenerate.Enabled = true;
            }
        }

        private void RandomButton_Click(object sender, EventArgs e)
        {
            Random random1 = new Random();
            cRe = random1.Next(-1, 2) * random1.NextDouble();
            cIm = random1.Next(-1, 2) * random1.NextDouble();
            tbReCValue.Text = cRe.ToString();
            tbImCValue.Text = cIm.ToString();
        }
    }

    class Complex
    {
        public double re;
        public double im;

        public Complex(double r, double i)
        {
            re = r;
            im = i;
        }

        public static Complex Sqr(Complex c)
        {
            return new Complex(c.re * c.re - c.im * c.im, 2 * c.re * c.im);
        }

        public static Complex operator +(Complex c1, Complex c2)
        {
            return new Complex(c1.re + c2.re, c1.im + c2.im);
        }

        public static Complex operator *(Complex c1, Complex c2)
        {
            return new Complex(c1.re * c2.re - c1.im * c2.im, c1.re * c2.im + c1.im * c2.re);
        }
    }
}
