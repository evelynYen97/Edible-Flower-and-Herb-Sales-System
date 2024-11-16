using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 個人專題
{
    internal class Global_var
    {
        internal static string strDBConnectionString = "";
        internal static string image_dir = "C:\\Evelyn\\個人專題\\個人專題\\images";
        internal static string image_dirLogin = "C:\\Evelyn\\個人專題\\個人專題\\usersPhotos";
        internal static string str目前圖檔的副檔名 = "";
        internal static List<ArrayList> listOrderItems = new List<ArrayList>(); //購物車
        internal  static string str送貨方式 = ""; //訂單描述
        internal static string strDeliveryWayChoose = ""; //運送方式
        internal static int intDeliveryPrice = 0; //運送價格
        internal static DateTime date下單日 = default(DateTime); 
        internal static DateTime date供貨日= default(DateTime);
        internal static DateTime date預訂供貨日=default(DateTime);
        internal static string strReservation = "";
        internal static string str訂購人姓名 = "";
        internal static string strPaymentChoose = "";
        internal static string strProductChangeChoose = "";
        internal static int intIDChoose = 1;
        internal static string strSexChoose = "";
        internal static string strJobChoose = "";
        internal static string strProductName = "";
        internal int intCategoryChoose = 0;
        internal string strCategory = "";
        internal static int intPID = 0;
        internal static int intSID = -1;
        internal static int intOID = -1;
        internal static int intUID = -1;
        internal static int intCID = -1;
        internal static int intUserPrivilege= -1;
        internal static string strUserName = "";
        internal static string strOSupplyDate = "";
        internal static string strOOrderDate = "";

        internal static DateTime dateFrom = default(DateTime);
        internal static DateTime dateTo = default(DateTime);
    }

}
