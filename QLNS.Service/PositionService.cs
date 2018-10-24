using QLNS.Data.Infrastructure;
using QLNS.Data.Repositories;
using QLNS.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNS.Service
{
    public interface IPositionService
    {
        Position Add(Position Position);
        void Update(Position Position);
        Position Delete(int id);
        IEnumerable<Position> GetAll();
        IEnumerable<Position> GetAll(string keyWord);
        IEnumerable<Position> GetAllPaging(int page, int pageSize, out int totalRow);
        Position GetById(int id);
        IEnumerable<Position> GetAllByTagPaging(string tag, int page, int pageSize, out int totalRow);
        void SaveChanges();
    }
    public class PositionService : IPositionService
    {
        IPositionRepository _positionRepository;
        IUnitOfWork _unitOfWork;
        public PositionService(IPositionRepository positionRepository, IUnitOfWork unitOfWork)
        {
            this._positionRepository = positionRepository;
            this._unitOfWork = unitOfWork;
        }
        public Position Add(Position position)
        {
           return _positionRepository.Add(position);
        }

        public Position Delete(int id)
        {
            return _positionRepository.Delete(id);
        }

        public IEnumerable<Position> GetAll()
        {
            return _positionRepository.GetAll();
        }

        public IEnumerable<Position> GetAll(string keyWord)
        {
            return _positionRepository.GetMulti(c => c.GetType().GetProperties().ToList().Any(d => d.GetValue(c).ToString().Contains(keyWord)));
        }

        public IEnumerable<Position> GetAllByTagPaging(string tag, int page, int pageSize, out int totalRow)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Position> GetAllPaging(int page, int pageSize, out int totalRow)
        {
            throw new NotImplementedException();
        }

        public Position GetById(int id)
        {
            return _positionRepository.GetSingleById(id);
        }

        public void SaveChanges()
        {
            _unitOfWork.Commit();
        }

        public void Update(Position Position)
        {
            throw new NotImplementedException();
        }
    }
}
