using System;

namespace phuchunghome.com.Models
{
   
    /// <summary>
    /// Chi tiết quyền của tài khoản
    /// </summary>
    public class UserPrivilege
    {
        
        public int Index { get; set; }
        public string Name { get; set; }
        /// <summary>
        /// Kiểm tra xem có là tài khoản admin hoặc user
        /// </summary>
        public bool IsAdmin { get; set; }
        public string Note { get; set; }
       
        public DateTime CreatedDate { get; set; }

        public string UpdateUser { get; set; }
       
        public DateTime UpdateDate { get; set; }
    }
}
