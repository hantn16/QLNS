using QLNS.Data.Infrastructure;
using QLNS.Model.Models;

namespace QLNS.Data.Repositories
{
    public interface IPositionRepository : IRepository<Position>
    {
    }

    public class PositionRepository : RepositoryBase<Position>, IPositionRepository
    {
        public PositionRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
