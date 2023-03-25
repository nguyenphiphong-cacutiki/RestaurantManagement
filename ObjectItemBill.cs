using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectGroup03_63KTPM2_Version01
{
    
    public class ObjectItemBill
    {
        public static string id;
        public static string idMon;
        public static int amount;
        public static int grandTotal;
        public static string status;
        public static string date;
        public static string indexTable;
        public  ObjectItemBill()
        {

        }
        public ObjectItemBill(string _id, string _idMon, int _amount, int _grandTotal,
            string _status, string _date, string _indexTable)
        {
            id = _id;
            idMon = _idMon;
            amount = _amount;
            grandTotal = _grandTotal;
            status = _status;
            date = _date;
            indexTable = _indexTable;
        }

    }
}
