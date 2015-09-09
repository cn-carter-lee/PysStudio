using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Pys.Entity
{
    [Table("DownloadInfo")]
    public class DownloadInfo : PageInfo
    {
        [Key]
        public long DownloadId { set; get; }

        public string Source { set; get; }

        public string FileUrl { set; get; }
    }
}