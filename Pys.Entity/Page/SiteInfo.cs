using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pys.Entity
{
    [Table("SiteInfo")]
    public class SiteInfo : PageInfo
    {
        [Key]
        public long SiteId { set; get; }
        public string Name { set; get; }
        public string ImageName { set; get; }
    }
}
