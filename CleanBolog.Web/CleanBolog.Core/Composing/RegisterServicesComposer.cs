using CleanBolog.Core.Services;
using Umbraco.Core.Composing;
using Umbraco.Core;

namespace CleanBolog.Core.Composing
{
    public class RegisterServicesComposer : IUserComposer
    {
        public void Compose(Composition composition)
        {
            composition.Register<ISmtpServices, SmtpServices>(Lifetime.Singleton);
            composition.Register<IArticleService, ArticleService>(Lifetime.Singleton);
        }
    }
}
