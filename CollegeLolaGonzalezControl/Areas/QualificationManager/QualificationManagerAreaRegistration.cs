using System.Web.Mvc;

namespace CollegeLolaGonzalezControl.Areas.QualificationManager
{
    public class QualificationManagerAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "QualificationManager";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "QualificationManager_default",
                "QualificationManager/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}