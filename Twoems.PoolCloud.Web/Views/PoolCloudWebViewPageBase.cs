using Abp.Web.Mvc.Views;

namespace Twoems.PoolCloud.Web.Views
{
    public abstract class PoolCloudWebViewPageBase : PoolCloudWebViewPageBase<dynamic>
    {

    }

    public abstract class PoolCloudWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected PoolCloudWebViewPageBase()
        {
            LocalizationSourceName = PoolCloudConsts.LocalizationSourceName;
        }
    }
}