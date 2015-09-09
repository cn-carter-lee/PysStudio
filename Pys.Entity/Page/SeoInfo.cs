using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Pys.Entity
{
    [Table("SeoInfo")]
    public class SeoInfo : PageInfo
    {
        [Key]
        public long SeoId { set; get; }
    }
}
