using Abp.Web.Mvc.Views;

namespace Graduation.App.Web.Views
{
    public abstract class AppWebViewPageBase : AppWebViewPageBase<dynamic>
    {

    }

    public abstract class AppWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected AppWebViewPageBase()
        {
            LocalizationSourceName = AppConsts.LocalizationSourceName;
        }
    }
}