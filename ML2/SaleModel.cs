using Microsoft.ML.Runtime.Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML2
{
    public class SaleModel
    {
        [Column("0")]
        public float Month;

        [Column("1")]
        public float Year;

        [Column("2", name: "Label")]
        public float Sale;
    }
}
