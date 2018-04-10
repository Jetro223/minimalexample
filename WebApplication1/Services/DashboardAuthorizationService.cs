using System.Security.Claims;

namespace WebApplication1.Services
{
    public class DashboardAuthorizationService
    {
        public bool HasAccess(ClaimsPrincipal user, string useCaseName)
        {
            //todo: Evtl. Daten aus DB laden

            if (user.IsInRole("DG_Dashboard-Admins"))
                return true;

            switch (useCaseName)
            {
                case "SqlServerJobViewer":
                    return user.IsInRole("Performance Log Users");

                case "VisLogViewer":
                    return user.IsInRole("DG_VISLog-Viewer");

                case "ReportinBonitaetViewer":
                    return user.IsInRole("DG_ReBoni-Viewer");

                default:
                    return false;
            }
        }
    }
}
