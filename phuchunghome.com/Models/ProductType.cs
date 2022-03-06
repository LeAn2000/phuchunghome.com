using System;

namespace phuchunghome.com.Models
{
    
    /// <summary>
    /// Loại hàng
    /// </summary>
    public class ProductType
    {
       
        public int Index { get; set; }
        public string Name { get; set; }
       
        public DateTime CreatedDate { get; set; }

        public string UpdateUser { get; set; }
      
        public DateTime UpdateDate { get; set; }
    }
}
