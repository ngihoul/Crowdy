using Crowdy.BLL.Services.Interfaces;
using Crowdy.DAL.Entities;
using Crowdy.DAL.Repositories;
using Crowdy.DAL.Repositories.Interfaces;

namespace Crowdy.BLL.Services
{
    public class StatusService : IStatusService
    {
        private readonly IStatusRepository _statusRepository;

        public StatusService(IStatusRepository statusRepository)
        {
            _statusRepository = statusRepository;
        }

        public List<Status> GetAll()
        {
            List<Status>? statuses = _statusRepository.GetAll().ToList();

            if (statuses.Count <= 0)
            {
                throw new Exception("Aucune categorie n'a été trouvée.");
            }

            return statuses;
        }

        public Status GetOneById(int id)
        {
            Status? status = _statusRepository.GetOneById(id);

            if (status == null)
            {
                throw new Exception("Le status n'existe pas.");
            }

            return status;
        }

        public Status? GetOneByName(string name)
        {
            Status? status = _statusRepository.GetOneByName(name);

            if (status == null)
            {
                throw new Exception("Le status n'existe pas.");
            }

            return status;
        }

        public Status Create(Status status)
        {
            throw new NotImplementedException();
        }

        public bool Update(Status status)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Status status)
        {
            throw new NotImplementedException();
        }
    }
}
