using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pys.Entity
{
    [Table("BlogInfo")]
    public class BlogInfo : PageInfo
    {
        [Key]
        public long BlogId { set; get; }
        public long TypeId { set; get; }
    }
}
