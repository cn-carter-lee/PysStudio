using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Pys.Entity
{
    [Table("CaseInfo")]
    public class CaseInfo : PageInfo
    {
        [Key]
        public long CaseId { get; set; }
        public string Name { get; set; }
        public string ImageName { get; set; }
    }
}
