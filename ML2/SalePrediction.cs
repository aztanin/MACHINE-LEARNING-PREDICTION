﻿using Microsoft.ML.Runtime.Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML2
{
    public class SalePrediction
    {
        [ColumnName("Score")]
        public float PredictedSale;
    }
}
