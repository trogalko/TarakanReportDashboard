using TarakanReportDashboard.Resources;
using Telerik.ReportViewer.BlazorNative.Services;

namespace TarakanReportDashboard.Services
{
    public class CustomStringLocalizer : ITelerikReportingStringLocalizer
    {
        public string this[string name]
        {
            get
            {
                return this.GetStringFromResource(name);
            }
        }

        public string GetStringFromResource(string key)
        {
            return ReportViewerMessages.ResourceManager.GetString(key, ReportViewerMessages.Culture);
        }
    }
}
