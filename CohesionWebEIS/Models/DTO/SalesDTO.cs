using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CohesionWebEIS.Models.DTO
{
    public class SalesDTO
    {
        public string SALES_ORDER_ID        { get; set; }
        public DateTime ORDER_DATE          { get; set; }
        public string CUSTOMER_CODE         { get; set; }
        public string CUSTOMER_NAME         { get; set; }
        public string PRODUCT_CODE          { get; set; }
        public string PRODUCT_NAME          { get; set; }
        public Decimal ORDER_QTY            { get; set; }
        public char CONFIRM_FLAG            { get; set; }
        public char SHIP_FLAG               { get; set; }
    }
}