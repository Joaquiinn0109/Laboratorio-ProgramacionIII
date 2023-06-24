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
        public List<Movie> TraerTodasLasPeliculas()
        {
            return _dataAccessRepoDbRepository.TrearTodasLasPeliculas();
        }
        public void Agregar(int num)
        {
            _dataAccessRepoDbRepository.AgregarPeliculas(num);
        }
        public void Editar()
        {
            _dataAccessRepoDbRepository.EditarPeliculas();
        }
        public List<Movie> Busqueda(string textToSearch)
        {
            return _dataAccessRepoDbRepository.Busqueda(textToSearch);
        }
        public void Eliminar()
        {
            _dataAccessRepoDbRepository.Eliminar();
        }
    }
}