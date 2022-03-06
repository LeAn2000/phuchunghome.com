using System;


namespace phuchunghome.com.Models
{
 
    /// <summary>
    /// Sản phẩm
    /// </summary>
    public class Product
    {
       
        public string ProductID { get; set; }
        public string ProductName { get; set; }
        /// <summary>
        /// Loại hàng
        /// </summary>
        public int ProductTypeID { get; set; }
        /// <summary>
        /// Nhà cung cấp
        /// </summary>
        public float ManufacturerID { get; set; }
        /// <summary>
        /// Giá nhập
        /// </summary>
        public float CostPrice { get; set; }
        /// <summary>
        /// Giá khuyến mãi
        /// </summary>
        public float PromotionalPrice { get; set; }
        /// <summary>
        /// Giá bán
        /// </summary>
        public float Price { get; set; }
        /// <summary>
        /// Khả năng vượt trội
        /// </summary>
        public string Outstanding { get; set; }
        /// <summary>
        /// Thông số sản phẩm
        /// </summary>
        public string Specification { get; set; }
        /// <summary>
        /// Tổng quan hàng
        /// </summary>
        public string Overview { get; set; }
        public string Image1 { get; set; }
        public string Image2 { get; set; }
        public string Image3 { get; set; }
    
        public DateTime CreatedDate { get; set; }

        public string UpdateUser { get; set; }
     
        public DateTime UpdateDate { get; set; }
    }
}
