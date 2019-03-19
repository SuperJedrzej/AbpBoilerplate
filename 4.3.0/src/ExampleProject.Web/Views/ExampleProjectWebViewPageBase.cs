using Abp.Web.Mvc.Views;

namespace ExampleProject.Web.Views
{
    public abstract class ExampleProjectWebViewPageBase : ExampleProjectWebViewPageBase<dynamic>
    {

    }

    public abstract class ExampleProjectWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected ExampleProjectWebViewPageBase()
        {
            LocalizationSourceName = ExampleProjectConsts.LocalizationSourceName;
        }
    }
}