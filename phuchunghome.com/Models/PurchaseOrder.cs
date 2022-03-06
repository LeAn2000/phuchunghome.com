using System;


namespace phuchunghome.com.Models
{

    /// <summary>
    /// Đơn đặt hàng
    /// </summary>
    public class PurchaseOrder
    {
       
        public int ID { get; set; }
        public string Name { get; set; }
        public string NumberPhone { get; set; }
        /// <summary>
        /// Địa chỉ (số nhà, đường, tỉnh)
        /// </summary>
        public string Address { get; set; }
        /// <summary>
        /// Thành phố
        /// </summary>
        public int City { get; set; }
        /// <summary>
        /// Quận huyện
        /// </summary>
        public int District { get; set; }
      
        public DateTime CreatedDate { get; set; }
        /// <summary>
        /// Trạng thái đơn hàng
        /// </summary>
        public bool OrderStatus { get; set; }
        /// <summary>
        /// Thành tiền
        /// </summary>
        public float TotalAmount { get; set; }
    }
}
