namespace RoutesSystem.Core.Reports
{
    public interface IReportFileType
    {
        void CreateReport(IReportData data);
    }
}