using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace phuchunghome.com.Models
{
    public class AccountUser
    {
        public string UserName { get; set; }
        public string PassWord { get; set; }
        public string Name { get; set; }    
        public int AccountPrivilege { get; set; }      
        public DateTime CreatedDate { get; set; }
        public string UpdateUser { get; set; }       
        public DateTime UpdateDate { get; set; }

    }
}