﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boolean.CSharp.Main.Misc
{
    public class Unicycle
    {
        private string _nameOfUnicyclist;

        //Constructor1:
        public Unicycle(string Name)
        {
            _nameOfUnicyclist = Name;
        }

        public string NameOfUnicyclist { get => _nameOfUnicyclist; set => _nameOfUnicyclist = value; }
        public int WheelCount { get; set; } = 1;    //Default value = 1
    }
}
