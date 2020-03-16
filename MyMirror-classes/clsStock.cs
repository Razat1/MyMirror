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
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@StockNo", stockNo);
            DB.Execute("sproc_tblStock_SelectAll");
            if (DB.Count == 1)
            {
                mStockNo = Convert.ToInt32(DB.DataTable.Rows[0]["StockNo"]);
                mStockDes = Convert.ToString(DB.DataTable.Rows[0]["StockDescription"]);
                mStockQuantity = Convert.ToInt32(DB.DataTable.Rows[0]["Quantity"]);
                mDateAdded = Convert.ToDateTime(DB.DataTable.Rows[0]["DateAdded"]);
                mPrice = Convert.ToInt32(DB.DataTable.Rows[0]["Price"]);
                mAvailable = Convert.ToBoolean(DB.DataTable.Rows[0]["Available"]);
                return true;
            }
            else {
                return false;
            }

   
        }
    }
}