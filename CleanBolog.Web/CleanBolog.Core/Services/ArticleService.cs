using CleanBolog.Core.Helper;
using CleanBolog.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web;

namespace CleanBolog.Core.Services
{
    public class ArticleService : IArticleService
    {
        public IPublishedContent GetArticleListPage(IPublishedContent siteRoot)
        {
            return siteRoot.Descendants().Where(a => a.ContentType.Alias == "articleList").FirstOrDefault();
        }

        public IEnumerable<IPublishedContent> GetLatestArticles(IPublishedContent siteRoot)
        {
            var articleList = GetArticleListPage(siteRoot);
            return articleList.Descendants().Where(a => a.ContentType.Alias == "article" && a.IsPublished()).OrderByDescending(a => a.Value<DateTime>("articleDate"));
        }

        public ArticleViewModel GetLatestArticles(IPublishedContent currentContentItem, HttpRequestBase request)
        {
            var articleList = GetArticleListPage(currentContentItem.Root());
            var articles = articleList.Descendants().Where(a => a.IsVisible()).OrderByDescending(a => a.Value<DateTime>("articleDate"));

            var isArticleListPage = articleList.Id == currentContentItem.Id;
            var fallbackPageSize = isArticleListPage ? 10 : 3; //Eğer artclelist ten geliyors 10 tane değilse 3 tane dönecek.

            var pageNumber = QueryStringHelper.GetIntFromQueryString(request, "page", 1);
            var pageSize = QueryStringHelper.GetIntFromQueryString(request, "size", fallbackPageSize);

            var pageOfArticles = articles.Skip((pageNumber - 1) * pageSize).Take(pageSize);
            var totalItemCount = articles.Count();
            var pageCount = totalItemCount > 0 ? Math.Ceiling((double)totalItemCount / pageSize) : 1;

            ArticleViewModel model = new ArticleViewModel()
            {
                IsArticleListPage = isArticleListPage,
                PageCount = pageCount,
                PageNumber = pageNumber,
                PageSize = pageSize,
                TotalItemCount = totalItemCount,
                Results = pageOfArticles,
                Url = currentContentItem.Url
            };
            return model;
        }
    }
}
