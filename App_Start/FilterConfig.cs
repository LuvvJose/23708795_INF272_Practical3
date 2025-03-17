using System.Web;
using System.Web.Mvc;

namespace _23708795_INF272_Practical3
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
