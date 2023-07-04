﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AimLab
{
    public class Target
    {
        public static int RadiusHead { get; set; } = 28;
        public static int BodyWidth { get; set; } = 60;
        public static int BodyHeight { get; set; } = 120;
        public static int ArmWidth { get; set; } = 20;
        public static int ArmHeight { get; set; } = 60;
        public static int LegWidth { get; set; } = 20;
        public static int LegHeght { get; set; } = 80;

        public Point HeadCenter { get; set; }
        public Point BodyCenter { get; set; }
        public Point ArmLeft { get; set; }
        public Point ArmRight { get; set; }
        public Point LegLeft { get; set; }
        public Point LegRight { get; set; }

        public Target()
        {
        }
        public void UpdatePoints()
        {
            BodyCenter = new Point(HeadCenter.X - RadiusHead, HeadCenter.Y + (BodyHeight / 2) - RadiusHead + 5);
            ArmLeft = new Point(BodyCenter.X - BodyWidth / 2 + ArmWidth / 2, BodyCenter.Y);

            ArmRight = new Point(BodyCenter.X + BodyWidth, BodyCenter.Y);

            LegLeft = new Point(BodyCenter.X, BodyCenter.Y + BodyWidth * 2);

            LegRight = new Point(BodyCenter.X + BodyWidth - LegWidth, BodyCenter.Y + BodyWidth * 2);
        }
        public void Draw(Graphics g)
        {
            Brush brush = new SolidBrush(Color.Cyan);
            Pen pen = new Pen(Color.DarkCyan);
            //Head
            g.FillEllipse(brush, HeadCenter.X - RadiusHead, HeadCenter.Y - RadiusHead, RadiusHead * 2, RadiusHead * 2);
            g.DrawEllipse(pen, HeadCenter.X - RadiusHead, HeadCenter.Y - RadiusHead, RadiusHead * 2, RadiusHead * 2);
            //Body
            brush = new SolidBrush(Color.DarkCyan);
            g.FillRectangle(brush, BodyCenter.X, BodyCenter.Y, BodyWidth, BodyHeight);
            //arms
            brush = new SolidBrush(Color.DarkTurquoise);
            g.FillRectangle(brush, ArmLeft.X, ArmLeft.Y, ArmWidth, ArmHeight);
            g.FillRectangle(brush, ArmRight.X, ArmRight.Y, ArmWidth, ArmHeight);
            //legs
            brush = new SolidBrush(Color.DarkTurquoise);
            g.FillRectangle(brush, LegLeft.X, LegLeft.Y, LegWidth, LegHeght);
            g.FillRectangle(brush, LegRight.X, LegRight.Y, LegWidth, LegHeght);

            pen.Dispose();
            brush.Dispose();
        }
        public static int MaxWidth()
        {
            return BodyWidth + ArmWidth;
        }

        public static int MaxHeght()
        {
            return BodyHeight + LegHeght + (RadiusHead * 2);
        }
        public bool HitHead(Point cursur)
        {
            int distance = (int)Math.Sqrt(Math.Pow(HeadCenter.X - cursur.X, 2) + Math.Pow(HeadCenter.Y - cursur.Y, 2));
            return distance < RadiusHead;
        }
        public bool HitBody(Point cursur)
        {
            if (cursur.X >= BodyCenter.X && cursur.X <= BodyCenter.X + BodyWidth && cursur.Y >= BodyCenter.Y && cursur.Y <= BodyCenter.Y + BodyHeight)
            {
                return true;
            }
            return false;
        }
        public bool HitArmLeft(Point cursur)
        {
            if (cursur.X >= ArmLeft.X && cursur.X <= ArmLeft.X + ArmWidth && cursur.Y >= ArmLeft.Y && cursur.Y <= ArmLeft.Y + ArmHeight)
            {
                return true;
            }
            return false;
        }
        public bool HitArmRight(Point cursur)
        {
            if (cursur.X >= ArmRight.X && cursur.X <= ArmRight.X + ArmWidth && cursur.Y >= ArmRight.Y && cursur.Y <= ArmRight.Y + ArmHeight)
            {
                return true;
            }
            return false;
        }
        public bool HitLegLeft(Point cursur)
        {
            if (cursur.X >= LegLeft.X && cursur.X <= LegLeft.X + LegWidth && cursur.Y >= LegLeft.Y && cursur.Y <= LegLeft.Y + LegHeght)
            {
                return true;
            }
            return false;
        }
        public bool HitLegRight(Point cursur)
        {
            if (cursur.X >= LegRight.X && cursur.X <= LegRight.X + LegWidth && cursur.Y >= LegRight.Y && cursur.Y <= LegRight.Y + LegHeght)
            {
                return true;
            }
            return false;
        }

    }

}
