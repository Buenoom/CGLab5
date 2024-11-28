using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            screen.BackColor = Color.White;
            trackbar_movement.Value = 0;
            trackbar_turn_x.Value = 0;
            trackbar_turn_y.Value = 0;
            trackbar_turn_z.Value = 0;
            trackbar_size.Value = 5;
            DrawSurface();
        }

        int scale = 0;
        double rotate_x = 0;
        double rotate_y = 0;
        double rotate_z = 0;

        double xmax = 2;
        double ymax = 2;
        double ymin = -2;
        double xmin = -2;
        double df = 0.1;

        double[,] ArrayOfVerticesZ;
        double[,] ArrayOfVerticesX;
        double[,] ArrayOfVerticesY;

        public void DrawSurface()
        {
            int offset = trackbar_movement.Value;
            rotate_x = trackbar_turn_x.Value * Math.PI / 180;
            rotate_y = trackbar_turn_y.Value * Math.PI / 180;
            rotate_z = trackbar_turn_z.Value * Math.PI / 180;
            scale = trackbar_size.Value;
            Bitmap bitm = new Bitmap(screen.Width, screen.Height);
            Graphics g = Graphics.FromImage(bitm);
            Pen MyPen = new Pen(Color.DarkSlateGray);

            ArrayOfVerticesZ = new double[Convert.ToInt32((xmax - xmin) / df) + 1, Convert.ToInt32((ymax - ymin) / df) + 1];
            ArrayOfVerticesX = new double[Convert.ToInt32((xmax - xmin) / df) + 1, Convert.ToInt32((ymax - ymin) / df) + 1];
            ArrayOfVerticesY = new double[Convert.ToInt32((xmax - xmin) / df) + 1, Convert.ToInt32((ymax - ymin) / df) + 1];

            // Вычисление всех координат вершин и занесение их в массивы координат всех вершин
            for (double i = xmin; i <= xmax + 0.1; i += df)
            {
                for (double j = ymin; j <= ymax + 0.1; j += df)
                {
                    ArrayOfVerticesZ[Convert.ToInt32((i - xmin) / df), Convert.ToInt32((j - ymin) / df)] = Math.Cbrt(j + i * j);
                    ArrayOfVerticesX[Convert.ToInt32((i - xmin) / df), Convert.ToInt32((j - ymin) / df)] = i;
                    ArrayOfVerticesY[Convert.ToInt32((i - xmin) / df), Convert.ToInt32((j - ymin) / df)] = j;
                }
            }

            // Аксонометрическое проецирование вершин
            for (int i = 0; i < ArrayOfVerticesZ.GetLength(0); i++)
            {
                for (int j = 0; j < ArrayOfVerticesZ.GetLength(1); j++)
                {
                    double x = ArrayOfVerticesX[i, j];
                    double y = ArrayOfVerticesY[i, j];
                    double z = ArrayOfVerticesZ[i, j];
                    double sinalpha = Math.Sin(rotate_x);
                    double sinbeta = Math.Sin(rotate_y);
                    double singamma = Math.Sin(rotate_z);
                    double cosalpha = Math.Cos(rotate_x);
                    double cosbeta = Math.Cos(rotate_y);
                    double cosgamma = Math.Cos(rotate_z);
                    ArrayOfVerticesX[i, j] = (x * cosbeta * cosgamma + y * sinalpha * sinbeta * cosgamma - y * singamma * cosalpha + z * singamma * sinalpha + z * sinbeta * cosalpha * cosgamma) * scale * 10;
                    ArrayOfVerticesY[i, j] = ((x * singamma * cosbeta + y * cosalpha * cosgamma + y * sinbeta * sinalpha * singamma - z * sinalpha * cosgamma + z * sinbeta * singamma * cosalpha) * scale * 10) + offset + 263;
                    ArrayOfVerticesZ[i, j] = (-x * sinbeta + y * cosbeta * sinalpha + z * cosalpha * cosbeta) * scale * 10 + 230;
                }
            }

            // Отрисовка
            for (int i = 0; i < ArrayOfVerticesZ.GetLength(0); i++)
            {
                for (int j = 0; j < ArrayOfVerticesZ.GetLength(1); j++)
                {
                    // Верхний сосед
                    if (i != 0) g.DrawLine(MyPen, Convert.ToInt32(ArrayOfVerticesY[i, j]), Convert.ToInt32(ArrayOfVerticesZ[i, j]), Convert.ToInt32(ArrayOfVerticesY[i - 1, j]), Convert.ToInt32(ArrayOfVerticesZ[i - 1, j]));
                    // Нижний сосед
                    if (i != ArrayOfVerticesZ.GetLength(0) - 1) g.DrawLine(MyPen, Convert.ToInt32(ArrayOfVerticesY[i, j]), Convert.ToInt32(ArrayOfVerticesZ[i, j]), Convert.ToInt32(ArrayOfVerticesY[i + 1, j]), Convert.ToInt32(ArrayOfVerticesZ[i + 1, j]));
                    // Левый сосед
                    if (j != 0) g.DrawLine(MyPen, Convert.ToInt32(ArrayOfVerticesY[i, j]), Convert.ToInt32(ArrayOfVerticesZ[i, j]), Convert.ToInt32(ArrayOfVerticesY[i, j - 1]), Convert.ToInt32(ArrayOfVerticesZ[i, j - 1]));
                    // Правый сосед
                    if (j != ArrayOfVerticesZ.GetLength(1) - 1) g.DrawLine(MyPen, Convert.ToInt32(ArrayOfVerticesY[i, j]), Convert.ToInt32(ArrayOfVerticesZ[i, j]), Convert.ToInt32(ArrayOfVerticesY[i, j + 1]), Convert.ToInt32(ArrayOfVerticesZ[i, j + 1]));
                }
            }

            /*
            
            for (int i = 0; i < ArrayOfVerticesZ.GetLength(0); i++)
            {
                for (int j = 0; j < ArrayOfVerticesZ.GetLength(1); j++)
                {
                    Debug.Write($"({ArrayOfVerticesX[i, j]}, {ArrayOfVerticesY[i, j]}, {ArrayOfVerticesZ[i, j]}) \t");
                }
                Debug.WriteLine("");
            }*/

            screen.Image = bitm;
        }
        private void trackbarScroll(object sender, EventArgs e)
        {
            DrawSurface();
        }
    }
}



