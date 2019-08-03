using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TIK_TAC_TOE
{
    public partial class BlackBoard : Control
    {
        private int lineWidth = 2;
        public int LineWidth
        {
            get
            {
                return lineWidth;
            }
            set
            {
                lineWidth = value;
                Invalidate();
            }
        }

        public static TileSpot[,] Spots = new TileSpot[3,3];

        private Rectangle[,] SpotRect=new Rectangle[3,3];

        public BlackBoard()
        {
            InitializeComponent();
            GenerateTiles();
            TileSpot.OnTileClicked += TileSpot_OnTileClicked;
        }

        private void TileSpot_OnTileClicked(TileSpot tileSpot)
        {
            GameManager.OnSpotClicked(tileSpot);
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
            pe.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            DrawGridLines(pe.Graphics);
            if (!DesignMode)
                GenerateTiles();

        }
        private void DrawGridLines(Graphics e)
        {
            e.DrawRectangles(new Pen(ForeColor, lineWidth), GetSpotRectDrawable().ToArray());
        }

        private void GenerateTiles()
        {
            GetSpotRect();

            int k = 0;

            for(int i=0;i<3;i++)
            {
                for(int j=0;j<3;j++)
                {
                    Spots[i,j] = new TileSpot();
                    Spots[i, j].Location = SpotRect[i, j].Location;
                    Spots[i, j].Size = SpotRect[i, j].Size;
                    Spots[i, j].Parent = this;
                    Spots[i, j].Uid = k++;

                }
            }
        }

        private void GetSpotRect()
        {
            int dw = Width / 3;
            int dh = Height / 3;

            for(int i=0;i<3;i++)
            {
                for(int j=0;j<3;j++)
                {
                    int x = dw * j;
                    int y = dh * i;

                    SpotRect[i, j] = new Rectangle(x+lineWidth/2,y+lineWidth/2, dw-lineWidth, dh-lineWidth);
                }
            }
        }
        private List<Rectangle> GetSpotRectDrawable()
        {

            List<Rectangle> rectangles = new List<Rectangle>();

            int dw = Width / 3;
            int dh = Height / 3;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    int x = dw * j;
                    int y = dh * i;

                    rectangles.Add(new Rectangle(x+lineWidth/2, y + lineWidth / 2, dw-lineWidth, dh-lineWidth));

                }
            }
            return rectangles;
        }

        protected new bool DesignMode
        {
            get
            {
                if (base.DesignMode)
                    return true;

                return LicenseManager.UsageMode == LicenseUsageMode.Designtime;
            }
        }
    }
}
