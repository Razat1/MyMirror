using System;

namespace MyMirror_classes
{
    public class clsStock
    {
        public int StockNo { get; set; }
        public string StockDes { get; set; }
        public int Quantity { get; set; }
        public DateTime DateAdded { get; set; }
        public int Price { get; set; }
        public bool Available { get; set; }
    }
}