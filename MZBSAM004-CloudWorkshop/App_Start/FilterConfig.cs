using System.Web;
using System.Web.Mvc;

namespace MZBSAM004_CloudWorkshop
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
