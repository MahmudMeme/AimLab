using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AimLab
{
    [Serializable]
    public class Account
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public int CrossHairThickness { get; set; }
        public Color CrossHairColor { get; set; }
        public bool CrossHairHaveCircle { get; set; }
        public string SavedPath { get; set; }
        public Account(string name)
        {
            Name = name;
            Level = 1;
            CrossHairThickness = 1;
            CrossHairColor = Color.Black;
            CrossHairHaveCircle = true;
        }
    }
}
