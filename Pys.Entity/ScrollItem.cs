using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pys.Entity
{
    public class ScrollItem
    {
        public ScrollItem()
        {
            //
            //TODO: 在此处添加构造函数逻辑
            //
        }

        private int _id;
        public int ID { set { _id = value; } get { return _id; } }

        private string _name;
        public string Name { set { _name = value; } get { return _name; } }

        private string _url;
        public string Url { set { _url = value; } get { return _url; } }

        private string _title;
        public string Title { set { _title = value; } get { return _title; } }

        private string _content;
        public string Content { set { _content = value; } get { return _content; } }
    }
}
