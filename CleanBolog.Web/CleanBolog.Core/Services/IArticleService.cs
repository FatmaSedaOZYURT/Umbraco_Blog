using CleanBolog.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using Umbraco.Core.Models.PublishedContent;

namespace CleanBolog.Core.Services
{
    public interface IArticleService
    {
        IPublishedContent GetArticleListPage(IPublishedContent siteRoot);
        IEnumerable<IPublishedContent> GetLatestArticles(IPublishedContent siteRoot);
        ArticleViewModel GetLatestArticles(IPublishedContent currentContentItem, HttpRequestBase request);
    }
}
