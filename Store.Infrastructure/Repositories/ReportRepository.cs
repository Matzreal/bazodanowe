using Store.Common;
using Store.Domain.Model.Report;
using Store.Domain.Repositories;

namespace Store.Infrastructure.Repositories
{
    public class ReportRepository : GenericRepository<Report>, IReportRepository
    {
    }
}
