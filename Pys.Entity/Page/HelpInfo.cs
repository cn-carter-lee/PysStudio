using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Pys.Entity
{
    [Table("HelpInfo")]
    public class HelpInfo : PageInfo
    {
        [Key]
        public string Name { set; get; }
        public string ChineseName { set; get; }
    }
}
