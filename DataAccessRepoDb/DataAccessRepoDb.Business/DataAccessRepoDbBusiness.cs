using DataAccessRepoDb.Data;
using DataAccessRepoDb.Entities;

namespace DataAccessRepoDb.Business
{
    public class DataAccessRepoDbBusiness
    {
        private DataAccessRepoDbRepository _dataAccessRepoDbRepository;

        public DataAccessRepoDbBusiness()
        {
            _dataAccessRepoDbRepository = new DataAccessRepoDbRepository();
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