using System.Web;
using System.Web.Mvc;

namespace ATP2_Mid_2nd_Lab_Task
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
