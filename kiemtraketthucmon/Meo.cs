﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kiemtraketthucmon
{
    class Meo : DongVat
    {
        public Meo()
        {
        }

        public Meo(string mauLong) : base(mauLong)
        {
            MauLong = mauLong;
        }

        public override string keu()
        {
            return base.keu() + "Meo meo ";

        }
    }
}
