using System.Web;
using System.Web.Mvc;

namespace nguyenxuanloc_2011064700
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
