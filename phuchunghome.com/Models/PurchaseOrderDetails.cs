using System;

namespace phuchunghome.com.Models
{
   
    public class PurchaseOrderDetails
    {
        /// <summary>
        /// Mã đơn hàng
        /// </summary>
       public int PurchaseOrderID { get; set; }
        /// <summary>
        /// Mã sản phẩm
        /// </summary>
        public string ProductID { get; set; }
        /// <summary>
        /// Số lượng
        /// </summary>
        public int Quantity { get; set; }
    }
}
