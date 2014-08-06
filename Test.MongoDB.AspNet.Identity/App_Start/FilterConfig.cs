using System.Web;
using System.Web.Mvc;

namespace Test.MongoDB.AspNet.Identity
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
