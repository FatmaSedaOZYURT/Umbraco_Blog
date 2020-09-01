using System.Web;
using Umbraco.Core;
using Umbraco.Core.Cache;
using Umbraco.Core.Composing;
using Umbraco.Core.Services;
using Umbraco.Web.Mvc;
using CleanBolog.Core.Services;
using Current = Umbraco.Web.Composing.Current;

namespace CleanBolog.Core.ViewPages
{
    public abstract class CleanBologViewPage<T> : UmbracoViewPage<T>
    {
        public readonly IArticleService ArticleService;

        public CleanBologViewPage() : this(
            Current.Factory.GetInstance<IArticleService>(),
            Current.Factory.GetInstance<ServiceContext>(),
            Current.Factory.GetInstance<AppCaches>()
        )
        {
        }
        public CleanBologViewPage(IArticleService articleService, ServiceContext services, AppCaches appCaches)
        {
            ArticleService = articleService;
            Services = services;
            AppCaches = appCaches;
        }
    }

    public abstract class CleanBologViewPage : UmbracoViewPage
    {
        public readonly IArticleService ArticleService;
        public CleanBologViewPage() : this(
            Current.Factory.GetInstance<IArticleService>(),
            Current.Factory.GetInstance<ServiceContext>(),
            Current.Factory.GetInstance<AppCaches>()
        )
        { }

        public CleanBologViewPage(IArticleService articleService, ServiceContext services, AppCaches appCaches)
        {
            ArticleService = articleService;
            Services = services;
            AppCaches = appCaches;
        }
    }
}