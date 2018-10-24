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
    public interface IWorkingProcessService
    {
        WorkingProcess Add(WorkingProcess WorkingProcess);
        void Update(WorkingProcess WorkingProcess);
        WorkingProcess Delete(int id);
        IEnumerable<WorkingProcess> GetAll();
        IEnumerable<WorkingProcess> GetAll(string keyWord);
        IEnumerable<WorkingProcess> GetAllPaging(int page, int pageSize, out int totalRow);
        WorkingProcess GetById(int id);
        IEnumerable<WorkingProcess> GetAllByTagPaging(string tag, int page, int pageSize, out int totalRow);
        void SaveChanges();
    }
    public class WorkingProcessService : IWorkingProcessService
    {
        IWorkingProcessRepository _workingProcessRepository;
        IUnitOfWork _unitOfWork;
        public WorkingProcessService(IWorkingProcessRepository workingProcessRepository, IUnitOfWork unitOfWork)
        {
            this._workingProcessRepository = workingProcessRepository;
            this._unitOfWork = unitOfWork;
        }
        public WorkingProcess Add(WorkingProcess workingProcess)
        {
            return _workingProcessRepository.Add(workingProcess);
        }

        public WorkingProcess Delete(int id)
        {
            return _workingProcessRepository.Delete(id);
        }

        public IEnumerable<WorkingProcess> GetAll()
        {
            return _workingProcessRepository.GetAll();
        }

        public IEnumerable<WorkingProcess> GetAll(string keyWord)
        {
            return _workingProcessRepository.GetMulti(c => c.GetType().GetProperties().ToList().Any(d => d.GetValue(c).ToString().Contains(keyWord)));
        }

        public IEnumerable<WorkingProcess> GetAllByTagPaging(string tag, int page, int pageSize, out int totalRow)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<WorkingProcess> GetAllPaging(int page, int pageSize, out int totalRow)
        {
            throw new NotImplementedException();
        }

        public WorkingProcess GetById(int id)
        {
            return _workingProcessRepository.GetSingleById(id);
        }

        public void SaveChanges()
        {
            _unitOfWork.Commit();
        }

        public void Update(WorkingProcess WorkingProcess)
        {
            throw new NotImplementedException();
        }
    }
}
