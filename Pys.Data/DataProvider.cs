using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Pys.Entity;
using System.Data.OleDb;
using System.Data.Common;

namespace Pys.Data
{
    public class PysDataProvider : IDataProvider
    {
        private static PysDataGateway<DataContext> _gateway = PysDataGateway<DataContext>.Instance;
        private int _pageIndex = 0;
        private int _pageSize = 10;

        private void Save()
        {
            _gateway.Save();
        }

        public void AddNews(NewsInfo newsInfo)
        {
            _gateway.Add(newsInfo);
            Save();
        }
        public NewsInfo GetNewsById(int newsId)
        {
            _gateway.Save();
            return _gateway.GetEntities<NewsInfo>().Find(newsId);
        }
        public List<NewsInfo> GetListNews()
        {
            return GetListNews(0, 10);
        }
        public List<NewsInfo> GetListNews(int pageIndex, int pageSize)
        {
            return _gateway.GetEntities<NewsInfo>().OrderBy(n => n.AddTime).Skip(pageIndex * pageSize).Take(pageSize).ToList();
        }

        public List<ScrollItem> GetIndexScrollItems()
        {
            List<ScrollItem> listPsyScrollItem = new List<ScrollItem>();
            string commandString = "select * from homescroll order by id asc";
            DbDataReader reader = PysDataBase.GetDataReader(commandString);
            if (reader != null)
            {
                while (reader.Read())
                {
                    ScrollItem psyScrollItem = new ScrollItem();
                    psyScrollItem.ID = Convert.ToInt32(reader["id"]);
                    psyScrollItem.Name = reader["m_name"].ToString();
                    psyScrollItem.Url = reader["m_url"].ToString();
                    psyScrollItem.Title = reader["m_title"].ToString();
                    psyScrollItem.Content = reader["m_content"].ToString();
                    listPsyScrollItem.Add(psyScrollItem);
                }
                reader.Close();
                reader.Dispose();
            }
            return listPsyScrollItem;
        }
        public ModuleInfo GetModuleInfoByName(string name)
        {
            return _gateway.GetEntities<ModuleInfo>().Find(name);
        }

        public void AddCase(CaseInfo caseInfo)
        {
            throw new NotImplementedException();
        }
        public CaseInfo GetCaseById(int caseId)
        {
            return _gateway.GetEntities<CaseInfo>().Find(caseId);
        }

        public List<CaseInfo> GetListCases()
        {
            return GetListCases(_pageIndex, _pageSize);
        }

        public List<CaseInfo> GetListCases(int pageIndex, int pageSize)
        {
            return _gateway.GetEntities<CaseInfo>().OrderBy(c => c.AddTime).Skip(pageIndex * pageSize).Take(pageSize).ToList();
        }



        public void AddSiteInfo(SiteInfo siteInfo)
        {
            _gateway.Add(siteInfo);
            this.Save();
        }
        public SiteInfo GetSiteInfoById(int siteId)
        {
            return _gateway.GetEntities<SiteInfo>().Find(siteId);
        }
        public List<SiteInfo> GetListSiteInfo()
        {
            return GetListSiteInfo(0, 10);
        }
        public List<SiteInfo> GetListSiteInfo(int pageIndex, int pageSize)
        {
            return _gateway.GetEntities<SiteInfo>().OrderBy(s => s.AddTime).Skip(pageIndex * pageSize).Take(pageSize).ToList();
        }



        public void AddSeo(SeoInfo seoInfo)
        {
            throw new NotImplementedException();
        }
        public SeoInfo GetSeoInfoById(int seoId)
        {
            return _gateway.GetEntities<SeoInfo>().Find(seoId);
        }

        public List<SeoInfo> GetListSeoInfo()
        {
            return GetListSeoInfo(_pageIndex, _pageSize);
        }

        public List<SeoInfo> GetListSeoInfo(int pageIndex, int pageSize)
        {
            return _gateway.GetEntities<SeoInfo>().OrderBy(s => s.AddTime).Skip(pageIndex * pageSize).Take(pageSize).ToList();
        }



        public HelpInfo GetHelpInfoByName(string name)
        {
            return _gateway.GetEntities<HelpInfo>().Find(name);
        }


        public void AddHelpInfo(HelpInfo helpInfo)
        {
            throw new NotImplementedException();
        }
        public List<HelpInfo> GetListHelpInfo()
        {
            List<HelpInfo> listHelpInfo = new List<HelpInfo>();
            DbDataReader reader = null;
            reader = PysDataBase.GetDataReader("select * from sitecontent");
            if (reader != null)
            {
                while (reader.Read())
                {
                    HelpInfo helpInfo = new HelpInfo();
                    helpInfo.Name = reader["m_name"].ToString(); ;
                    helpInfo.ChineseName = reader["c_name"].ToString();
                    listHelpInfo.Add(helpInfo);
                }
                reader.Close();
                reader.Dispose();
            }
            return listHelpInfo;
        }


        public void AddFunctionInfo(FunctionInfo functionInfo)
        {
            _gateway.Add(functionInfo);
            Save();
        }
        public FunctionInfo GetPysFunctionById(int functionId)
        {
            return _gateway.GetEntities<FunctionInfo>().Find(functionId);
        }
        public List<FunctionInfo> GetListPysFunction()
        {
            return _gateway.GetEntities<FunctionInfo>().ToList();
        }


        public void AddDownloadInfo(DownloadInfo downloadInfo)
        {
            throw new NotImplementedException();
        }
        public DownloadInfo GetDownloadInfoById(int downloadInfoId)
        {
            return _gateway.GetEntities<DownloadInfo>().Find(downloadInfoId);
        }

        public List<DownloadInfo> GetListDownloadInfo()
        {
            //DownloadInfo d = new DownloadInfo()
            //{
            //    Title = "THIS IS MY NATIVE LAND,I WILL DEFEND IT WITH MY LIFE!",
            //    Content = "THIS,CCCCCCCCCCCCCCCCCCCCCC",
            //    Description = "THIS,DDDD",
            //    Keywords = "THIS,kkk",
            //    FileUrl = "HTTP://WWW.BAID.COM",
            //    AddTime = DateTime.Now
            //};
            //Gateway.GetEntities<DownloadInfo>().Add(d);
            //Gateway.Save();

            return GetListDownloadInfo(_pageIndex, _pageSize);
        }

        public List<DownloadInfo> GetListDownloadInfo(int pageIndex, int pageSize)
        {
            return _gateway.GetEntities<DownloadInfo>().OrderBy(d => d.AddTime).Skip(pageIndex * pageSize).Take(pageSize).ToList();
        }


        public void AddBlogInfo(BlogInfo blogInfo)
        {
            _gateway.Add(blogInfo);
            Save();
        }
        public BlogInfo GetBlogInfoById(long blogId)
        {
            var blog = _gateway.GetEntities<BlogInfo>().Where(b => b.BlogId == blogId).FirstOrDefault();
            return blog;
        }
        public List<BlogInfo> GetListBlogInfo()
        {
            return GetListBlogInfo(_pageIndex, _pageSize);
        }
        public List<BlogInfo> GetListBlogInfo(int pageIndex, int pageSize)
        {
            return _gateway.GetEntities<BlogInfo>().OrderBy(b => b.AddTime).Skip(pageIndex * pageSize).Take(pageSize).ToList();
        }














    }
}
