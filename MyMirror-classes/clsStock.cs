using System;

namespace MyMirror_classes
{
    public class clsStock
    {
        private int mstockNo;
        private DateTime mDateAdded;

        public int StockNo {
                get {
                return mstockNo;

            }
            set {
                mstockNo = value;
            }


        }
        public string StockDes { get; set; }
        public int Quantity { get; set; }
        public DateTime DateAdded { get
            {
                return mDateAdded;
            }
            set
            {
                mDateAdded = value;

            } }
        public int Price { get; set; }
        public bool Available { get; set; }

        public bool Find(int stockNo)
        {
            mstockNo = 21;
            mDateAdded = Convert.ToDateTime("2016/11/11");

            return true;
        }
    }
}