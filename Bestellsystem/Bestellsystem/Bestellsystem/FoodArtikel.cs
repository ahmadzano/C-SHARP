﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bestellsystem
{
    class FoodArtikel: Artikel
    {
        DateTime HaltbarkeitsDauer { set; get; }
        String Kuehlungsart { set; get; }
    }
}
