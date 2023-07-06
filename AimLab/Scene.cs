using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AimLab
{
    public class Scene
    {
        public static int HeadHit { get; set; } = 10;
        public static int BodyHit { get; set; } = 5;
        public static int ArmOrLegHit { get; set; } = 2;
        public static int Miss { get; set; } = -10;
        public Target target { get; set; }

        public static Color ColorCrosshair { get; set; } = Color.Black;
        public static bool CircleCrosshair { get; set; } = false;
        public static Point Pointer { get; set; }
        public static int Thickness { get; set; } = 2;

        public Scene()
        {
            target = new Target()
            {

            };
        }
        public void Draw(Graphics g)
        {
            if (target.HeadCenter.X != 0)
            {
                target.Draw(g);
            }
        }
        public void AddTarget(Point point)
        {
            target = new Target();
            target.HeadCenter = point;
            target.UpdatePoints();
        }
        public int HitSometing(Point Location)
        {
            if (target.HitHead(Location))
                return HeadHit;
            else if (target.HitBody(Location))
                return BodyHit;
            else if (target.HitArmLeft(Location))
                return ArmOrLegHit;
            else if (target.HitArmRight(Location))
                return ArmOrLegHit;
            else if (target.HitLegLeft(Location))
                return ArmOrLegHit;
            else if (target.HitLegRight(Location))
                return ArmOrLegHit;
            else return Miss;
        }

        internal void DrawLines()
        {
            target.Crosshair = Pointer;

        }
       
    }
}
