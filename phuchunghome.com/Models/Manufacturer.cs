using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace phuchunghome.com.Models
{
   
  
    public class Manufacturer
    {
        
        public int Index { get; set; }
        public string Name { get; set; }
      
        public DateTime CreatedDate { get; set; }

        public string UpdateUser { get; set; }
      
        public DateTime UpdateDate { get; set; }
    }
}
