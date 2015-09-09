using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Pys.Entity
{
    [Table("FunctionInfo")]
    public class FunctionInfo : PageInfo
    {
        [Key]
        public long FuncitonId { set; get; }
    }
}
