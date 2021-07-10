using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FireSimulation
{

    public enum BoxType { Start, End, Wall, Normal, Fire, Human };


    public class GridBox : IDisposable
    {

        public int x, y, width, height;
        public SolidBrush brush;

        public Rectangle boxRec;
        public BoxType boxType;


        public GridBox(int iX, int iY, BoxType iType)
        {
            this.x = iX;
            this.y = iY;
            this.boxType = iType;
            switch (iType)
            {
                case BoxType.Normal:
                    brush = new SolidBrush(Color.WhiteSmoke);
                    break;
                case BoxType.End:
                    brush = new SolidBrush(Color.Lime);
                    break;
                case BoxType.Start:
                    brush = new SolidBrush(Color.Green);
                    break;
                case BoxType.Wall:
                    brush = new SolidBrush(Color.Gray);
                    break;
                case BoxType.Fire:
                    brush = new SolidBrush(Color.Yellow);
                    break;
                case BoxType.Human:
                    brush = new SolidBrush(Color.WhiteSmoke);//to let human box become flexible
                    break;
            }
            width = 20;
            height = 20;
            boxRec = new Rectangle(x, y, width, height);
        }


        public void SwitchBox()
        {
            switch (this.boxType)
            {
                case BoxType.Normal:
                    if (this.brush != null)
                        this.brush.Dispose();
                    this.brush = new SolidBrush(Color.Gray);
                    this.boxType = BoxType.Wall;
                    break;
                case BoxType.Wall:
                    if (this.brush != null)
                        this.brush.Dispose();
                    this.brush = new SolidBrush(Color.WhiteSmoke);
                    this.boxType = BoxType.Normal;
                    break;
            }
        }

        public void SetNormalBox()
        {
            if (this.brush != null)
                this.brush.Dispose();
            this.brush = new SolidBrush(Color.WhiteSmoke);
            this.boxType = BoxType.Normal;
        }

        public void SetStartBox()
        {
            if (this.brush != null)
                this.brush.Dispose();
            this.brush = new SolidBrush(Color.Green);
            this.boxType = BoxType.Start;
        }

        public void SetEndBox()
        {
            if (this.brush != null)
                this.brush.Dispose();
            this.brush = new SolidBrush(Color.Lime);
            this.boxType = BoxType.End;
        }

        public void Dispose()
        {
            if (this.brush != null)
                this.brush.Dispose();
        }

    }
}
