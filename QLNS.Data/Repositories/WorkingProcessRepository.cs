using QLNS.Data.Infrastructure;
using QLNS.Model.Models;

namespace QLNS.Data.Repositories
{
    public interface IWorkingProcessRepository : IRepository<WorkingProcess>
    {
    }

    public class WorkingProcessRepository : RepositoryBase<WorkingProcess>, IWorkingProcessRepository
    {
        public WorkingProcessRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
