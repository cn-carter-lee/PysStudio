using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Pys.Entity
{
    [Table("ModuleInfo")]
    public class ModuleInfo : PageHeader
    {
        [Key]
        public string Name { get; set; }          
        public string CName { get; set; }
        public int SortFlag { get; set; }
    }
}
