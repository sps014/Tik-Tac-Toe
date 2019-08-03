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
    public partial class TileSpot : Control
    {
        private int uid;
        public int Uid
        {
            get
            {
                return uid;
            }
            set
            {
                uid = value;
                uid2D.SetFrom1D(value);
            }
        }
        private Index2D uid2D = new Index2D();
        public Index2D Uid2D
        {
            get
            {
                return uid2D;
            }
        }

        private OwnerType owner = OwnerType.NONE;

        private Color colorAI=Color.DeepPink;
        public Color ColorAI
        {
            get
            {
                return colorAI;
            }
            set
            {
                colorAI = value;
                Invalidate();
            }
        }

        private Color colorPlayer = Color.DodgerBlue;
        public Color ColorPlayer
        {
            get
            {
                return colorPlayer;
            }
            set
            {
                colorPlayer = value;
                Invalidate();
            }
        }
        public OwnerType Owner
        {
            get
            {
                return owner;
            }
            set
            {
                owner = value;
                Invalidate();
            }
        }


        public TileSpot()
        {
            InitializeComponent();
            Font = new Font("Segoe UI", 25.8F,FontStyle.Bold,GraphicsUnit.Point, ((byte)(0)));
            ForeColor = Color.White;

        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
            DrawText(pe.Graphics);

        }
        private void DrawText(Graphics e)
        {
            e.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            switch(Owner)
            {
                case OwnerType.NONE:
                    Text = "";
                    e.FillRectangle(new SolidBrush(BackColor), ClientRectangle);
                    break;
                case OwnerType.PLAYER:
                    Text = "X";
                    e.FillRectangle(new SolidBrush(colorPlayer), ClientRectangle);
                    break;
                case OwnerType.AI:
                    Text = "O";
                    e.FillRectangle(new SolidBrush(colorAI), ClientRectangle);
                    break;
            }

            var metrics=e.MeasureString(Text, Font);
            var sh = metrics.Height;
            var sw = metrics.Width;

            e.DrawString(Text, Font, new SolidBrush(ForeColor), Width / 2-sw/2, Height / 2-sh/2);

        }
        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);

            OnTileClicked?.Invoke(this);

        }

        public delegate void OnTileClickHandler(TileSpot tileSpot);
        public static event OnTileClickHandler OnTileClicked;

        public struct Index2D
        {
            public int I { get; set; }
            public int J { get; set; }

            public void SetFrom1D(int index)
            {
                var i = index / 3;
                var j = index - i * 3;
                I = i;
                J = j;
            }

            public int Get1DIndex()
            {
                return I * 3 + J;
            }
        }

    }
}
