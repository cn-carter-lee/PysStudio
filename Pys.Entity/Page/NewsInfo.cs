using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Pys.Entity
{
    [Table("NewsInfo")]
    public class NewsInfo : PageInfo
    {
        [Key]
        public long NewsId { set; get; }

        public string Source { set; get; }
    }
}