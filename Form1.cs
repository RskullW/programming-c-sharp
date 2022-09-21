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
        }
        

        private void DrawHead(string namePen)
        {
            DrawPoint(namePen, new Point(100, 100), new Point(200, 200));
        }

        private void DrawEye(string namePen)
        {
            
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