using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Pys.Entity;

namespace Pys.Data
{
    public interface IDataProvider
    {
        void AddNews(NewsInfo newsInfo);
        NewsInfo GetNewsById(int newsId);
        List<NewsInfo> GetListNews();
        List<NewsInfo> GetListNews(int pageIndex, int pageSize);

        void AddCase(CaseInfo caseInfo);
        CaseInfo GetCaseById(int caseId);
        List<CaseInfo> GetListCases();

        ModuleInfo GetModuleInfoByName(string name);

        List<ScrollItem> GetIndexScrollItems();

        void AddSiteInfo(SiteInfo siteInfo);
        SiteInfo GetSiteInfoById(int siteId);
        List<SiteInfo> GetListSiteInfo();

        void AddSeo(SeoInfo seoInfo);
        SeoInfo GetSeoInfoById(int seoId);
        List<SeoInfo> GetListSeoInfo();

        void AddHelpInfo(HelpInfo helpInfo);
        HelpInfo GetHelpInfoByName(string name);
        List<HelpInfo> GetListHelpInfo();

        void AddFunctionInfo(FunctionInfo functionInfo);
        FunctionInfo GetPysFunctionById(int functionId);
        List<FunctionInfo> GetListPysFunction();

        void AddDownloadInfo(DownloadInfo downloadInfo);
        DownloadInfo GetDownloadInfoById(int functionId);
        List<DownloadInfo> GetListDownloadInfo();

        void AddBlogInfo(BlogInfo blogInfo);
        BlogInfo GetBlogInfoById(long blogId);
        List<BlogInfo> GetListBlogInfo();
    }
}
