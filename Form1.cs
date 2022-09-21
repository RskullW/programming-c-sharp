using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        private Bitmap _bitmap;
        private Graphics _graphics;
        private int _heightWindow;
        private int _widthWindod;

        private Dictionary<string, Pen> _pens;

        public Form1()
        {
            InitializeComponent();
            Initialize();
            Draw();
            FinishDraw();
        }

        private void Initialize()
        {
            _heightWindow = 600;
            _widthWindod = 1500;

            _bitmap = new Bitmap(_widthWindod, _heightWindow);
            _graphics = Graphics.FromImage(_bitmap);
            _pens = new Dictionary<string, Pen>();
            
            CreatePen("black4", new Pen(Color.Black, 4));
        }

        private void CreatePen(string name, Pen pen)
        {
            _pens[name] = pen;
        }
        private void Draw()
        {
            DrawHead("black4");
            DrawEye("black4");
        }
        

        private void DrawHead(string namePen)
        {
            DrawPoint(namePen, new Point(120, 40), new Point(80, 80)); // 1
            DrawPoint(namePen, new Point(80, 80), new Point(110, 130)); // 2
            DrawPoint(namePen, new Point(120, 40), new Point(170, 38)); // 3
            DrawPoint(namePen, new Point(110, 130), new Point(130, 132)); // 4
            DrawPoint(namePen, new Point(110, 130), new Point(128, 120)); // 5
            DrawPoint(namePen, new Point(130, 132), new Point(108, 78)); // 6
            DrawPoint(namePen, new Point(108, 78), new Point(80, 80)); // 7
            DrawPoint(namePen, new Point(108, 78), new Point(135, 82)); // 8
            DrawPoint(namePen, new Point(135, 82), new Point(120, 40)); // 9
            DrawPoint(namePen, new Point(135, 82), new Point(147, 136)); // 10
            DrawPoint(namePen, new Point(147, 136), new Point(130, 132)); // 11
            DrawPoint(namePen, new Point(147, 136), new Point(180, 145)); // 12
            DrawPoint(namePen, new Point(180, 145), new Point(210, 140)); // 13
            DrawPoint(namePen, new Point(210, 140), new Point(225, 130)); // 14
            DrawPoint(namePen, new Point(225, 130), new Point(135, 82)); // 15
            DrawPoint(namePen, new Point(225, 130), new Point(270, 70)); // 16
            DrawPoint(namePen, new Point(245, 100), new Point(120, 40)); // 17
            DrawPoint(namePen, new Point(270, 70), new Point(257, 55)); // 18
            DrawPoint(namePen, new Point(257, 55), new Point(215, 85)); // 19
            DrawPoint(namePen, new Point(170, 38), new Point(225, 41)); // 20
            DrawPoint(namePen, new Point(225, 41), new Point(235, 70)); // 21
            DrawPoint(namePen, new Point(225, 41), new Point(245, 30)); // 22
            DrawPoint(namePen, new Point(245, 30), new Point(257, 55)); // 23
            DrawPoint(namePen, new Point(250, 42), new Point(280, 37)); // 24
            DrawPoint(namePen, new Point(280, 37), new Point(263, 63)); // 25
            DrawPoint(namePen, new Point(210, 140), new Point(230, 180)); // 32
            DrawPoint(namePen, new Point(230, 180), new Point(225, 130)); // 33
        }

        private void DrawEye(string namePen)
        {
            DrawPoint(namePen, new Point(190, 75), new Point(210, 65)); // 26
            DrawPoint(namePen, new Point(210, 65), new Point(220, 67)); // 27
            DrawPoint(namePen, new Point(220, 67), new Point(222, 78)); // 28
            DrawPoint(namePen, new Point(222, 78), new Point(206, 73)); // 29
            DrawPoint(namePen, new Point(190, 75), new Point(220, 67)); // 30
            DrawPoint(namePen, new Point(222, 78), new Point(200, 80)); // 31
        }

        private void DrawTorso(string namePen)
        {
            
        }
        
        private void DrawPoint(string name, Point firstPoint, Point secondPoint)
        {
            Point[] points = new Point[2];

            points[0] = firstPoint;
            points[1] = secondPoint;
            
            _graphics.DrawPolygon(_pens[name], points);
        } 

        private void FinishDraw()
        {
            pictureBox1.Image = _bitmap;
        }
    }
}