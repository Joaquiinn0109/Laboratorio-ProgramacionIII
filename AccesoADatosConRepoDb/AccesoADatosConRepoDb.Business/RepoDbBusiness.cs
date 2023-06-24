using AccesoADatosConRepoDb.Data;
using AccesoADatosConRepoDb.Entities;

namespace AccesoADatosConRepoDb.Business
{
    public class RepoDbBusiness
    {
        private RepoDbRepository _dataAccessRepoDbRepository;

        public RepoDbBusiness()
        {
            _dataAccessRepoDbRepository = new RepoDbRepository();
        }
        public List<Movie> GetAll()
        {
            return (List<Movie>)_dataAccessRepoDbRepository.GetAll();
        }
        //public List<Movie> Search(string textToSearch)
        //{
        //    return _dataAccessRepoDbRepository.Search(textToSearch);
        //}
    }
}