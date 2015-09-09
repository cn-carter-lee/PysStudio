using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pys.Entity
{
    public class PageHeader
    {
        public string Title { set; get; }

        public string Keywords { set; get; }

        public string Description { set; get; }

        public string SeoString
        {
            get
            {
                return string.Format("<title>{0}</title>\r\n<meta name=\"keywords\" content=\"{0}\" />\r\n<meta name=\"description\"  content=\"{1}\" />\r\n", Title, Keywords, Description);
            }
        }
    }

    public class PageInfo : PageHeader
    {
        public string Content { set; get; }

        public DateTime AddTime { set; get; }
    }


}
