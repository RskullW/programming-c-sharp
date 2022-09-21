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
            DrawLineHead("black4");
            DrawLineEye("black4");
            DrawLineTorso("black4");
            DrawLineRightLeg("black4");
            DrawLineLeftLeg("black4");
        }
        

        private void DrawLineHead(string namePen)
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

        private void DrawLineEye(string namePen)
        {
            DrawPoint(namePen, new Point(190, 75), new Point(210, 65)); // 26
            DrawPoint(namePen, new Point(210, 65), new Point(220, 67)); // 27
            DrawPoint(namePen, new Point(220, 67), new Point(222, 78)); // 28
            DrawPoint(namePen, new Point(222, 78), new Point(206, 73)); // 29
            DrawPoint(namePen, new Point(190, 75), new Point(220, 67)); // 30
            DrawPoint(namePen, new Point(222, 78), new Point(200, 80)); // 31
        }

        private void DrawLineTorso(string namePen)
        {
            DrawPoint(namePen, new Point(230, 180), new Point(330, 235)); // 34
            DrawPoint(namePen, new Point(270, 70), new Point(328, 75)); // 35
            DrawPoint(namePen, new Point(330, 235), new Point(328, 75)); // 36
            DrawPoint(namePen, new Point(330, 235), new Point(355, 225)); // 37
            DrawPoint(namePen, new Point(355, 225), new Point(365, 215)); // 38
            DrawPoint(namePen, new Point(365, 215), new Point(330, 200)); // 39
            DrawPoint(namePen, new Point(365, 215), new Point(380, 230)); // 40
            DrawPoint(namePen, new Point(355, 225), new Point(375, 240)); // 41
            DrawPoint(namePen, new Point(375, 240), new Point(380, 230)); // 42
            DrawPoint(namePen, new Point(380, 230), new Point(390, 242)); // 43
            DrawPoint(namePen, new Point(375, 240), new Point(485, 242)); // 44
            DrawPoint(namePen, new Point(485, 242), new Point(500, 110)); // 45
            DrawPoint(namePen, new Point(500, 110), new Point(328, 75)); // 46
            DrawPoint(namePen, new Point(500, 110), new Point(497, 85)); // 47
            DrawPoint(namePen, new Point(497, 85), new Point(460, 100)); // 47.1
            DrawPoint(namePen, new Point(497, 85), new Point(495, 70)); // 48
            DrawPoint(namePen, new Point(495, 70), new Point(480, 55)); // 49
            DrawPoint(namePen, new Point(480, 55), new Point(390, 50)); // 50
            DrawPoint(namePen, new Point(390, 50), new Point(330, 78)); // 51
            DrawPoint(namePen, new Point(495, 70), new Point(600, 120)); // 52
            DrawPoint(namePen, new Point(600, 120), new Point(497, 85)); // 53
            DrawPoint(namePen, new Point(600, 120), new Point(585, 220)); // 54
            DrawPoint(namePen, new Point(585, 220), new Point(490, 220)); // 55
            DrawPoint(namePen, new Point(510, 220), new Point(485, 242)); // 56
            DrawPoint(namePen, new Point(505, 225), new Point(505, 242)); // 57
            DrawPoint(namePen, new Point(560, 220), new Point(580, 242)); // 58
            DrawPoint(namePen, new Point(585, 220), new Point(580, 242)); // 59
            DrawPoint(namePen, new Point(485, 242), new Point(580, 242)); // 60
        }
        
        private void DrawLineRightLeg(string namePen)
        {
            DrawPoint(namePen, new Point(580, 242), new Point(575, 320)); // 61
            DrawPoint(namePen, new Point(505, 242), new Point(515, 320)); // 62
            DrawPoint(namePen, new Point(485, 242), new Point(495, 295)); // 63
            DrawPoint(namePen, new Point(495, 295), new Point(515, 320)); // 64
            DrawPoint(namePen, new Point(515, 320), new Point(575, 320)); // 65
            DrawPoint(namePen, new Point(515, 320), new Point(516, 335)); // 66
            DrawPoint(namePen, new Point(516, 335), new Point(548, 320)); // 67
            DrawPoint(namePen, new Point(548, 320), new Point(548, 335)); // 68
            DrawPoint(namePen, new Point(516, 335), new Point(548, 335)); // 68.1
            DrawPoint(namePen, new Point(548, 335), new Point(550, 355)); // 69
            DrawPoint(namePen, new Point(550, 354), new Point(565, 375)); // 70
            DrawPoint(namePen, new Point(575, 320), new Point(574, 335)); // 71
            DrawPoint(namePen, new Point(574, 335), new Point(565, 375)); // 72
            DrawPoint(namePen, new Point(565, 375), new Point(540, 376)); // 73
            DrawPoint(namePen, new Point(550, 355), new Point(530, 355)); // 74
            DrawPoint(namePen, new Point(540, 376), new Point(530, 355)); // 75
            DrawPoint(namePen, new Point(516, 335), new Point(500, 345)); // 76
            DrawPoint(namePen, new Point(548, 335), new Point(505, 360)); // 77
            DrawPoint(namePen, new Point(500, 345), new Point(505, 360)); // 78
            DrawPoint(namePen, new Point(505, 360), new Point(490, 360)); // 79
            DrawPoint(namePen, new Point(500, 345), new Point(485, 346)); // 80
            DrawPoint(namePen, new Point(490, 360), new Point(485, 346)); // 81
        }

        private void DrawLineLeftLeg(string namePen)
        {
            DrawPoint(namePen, new Point(330, 235), new Point(326, 320)); // 82
            DrawPoint(namePen, new Point(326, 320), new Point(318, 335)); // 83
            DrawPoint(namePen, new Point(318, 335), new Point(297, 337)); // 84
            DrawPoint(namePen, new Point(326, 320), new Point(295, 322)); // 85
            DrawPoint(namePen, new Point(297, 337), new Point(295, 322)); // 86
            DrawPoint(namePen, new Point(375, 240), new Point(376, 310)); // 87
            DrawPoint(namePen, new Point(318, 335), new Point(355, 329)); // 88
            DrawPoint(namePen, new Point(376, 310), new Point(355, 329)); // 89
            DrawPoint(namePen, new Point(355, 329), new Point(375, 240)); // 90
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