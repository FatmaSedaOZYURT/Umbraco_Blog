using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Umbraco.Core.Models.PublishedContent;

namespace CleanBolog.Core.ViewModels
{
    public class ArticleViewModel
    {
        public bool IsArticleListPage { get; set; }
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
        public int TotalItemCount { get; set; }
        public double PageCount { get; set; }
        public IEnumerable<IPublishedContent> Results { get; set; }
        public string Url { get; set; }
    }
}
