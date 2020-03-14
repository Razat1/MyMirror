using System;

namespace MyMirror_classes
{
    public class clsStock
    {
        private int mStockNo;
        private DateTime mDateAdded;
        private string mStockDes;
        private int mStockQuantity;
        private int mPrice;
        private bool mAvailable;

        public int StockNo {
                get {
                return mStockNo;

            }
            set {
                mStockNo = value;
            }


        }
        public string StockDes {
            get
            {
                return mStockDes;
            }
            set
            {
                mStockDes = value;
            } }
        public int Quantity {
            get
            {
                return mStockQuantity;
            }
            set
            {
                mStockQuantity = value;
            }

        }
        public DateTime DateAdded { get
            {
                return mDateAdded;
            }
            set
            {
                mDateAdded = value;

            } }
        public int Price {
            get
            {
                return mPrice;
                }
            set
            {
                mPrice = value;
            }


        }
        public bool Available {
            get
            {
                return mAvailable;
            }
            set
            {
                mAvailable = value;
            }

        }

        public bool Find(int stockNo)
        {
            mStockNo = 21;
            mDateAdded = Convert.ToDateTime("2016/11/11");
            mStockDes = "Test Description";
            mStockQuantity = 1;
            mPrice = 11;
            mAvailable = true;

            return true;
        }
    }
}