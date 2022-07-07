using PPAIGestionRecursosTecno2022.Models;

namespace PPAIGestionRecursosTecno2022.Services
{
    public class MarcaService : IGenericService<Marca>
    {
        private static MarcaService _instance;
        private static List<Marca> _marcas;

        public static MarcaService GetInstance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new MarcaService();
                }
                return _instance;
            }
        }
        public List<Marca> Delete(int id)
        {
            try
            {
                _marcas.RemoveAll(x => x.Id == id);
                return _marcas;
            }
            catch (Exception ex)
            {
                throw new Exception("No se encontró marca con ese ID.");
            }
        }

        public List<Marca> GetAll()
        {
            if (_marcas == null) _marcas = new List<Marca>();
            return _marcas;
        }

        public Marca GetById(int id)
        {
            try
            {
                return _marcas.Where(x => x.Id == id).SingleOrDefault();
            }
            catch (Exception ex)
            {
                throw new Exception("No se encontró marca con ese ID.");
            }
        }

        public Marca GetByName(string name)
        {
            try
            {
                return _marcas.Where(x => x.Nombre == name).SingleOrDefault();
            }
            catch (Exception ex)
            {
                throw new Exception("No se encontró marca con ese ID.");
            }
        }

        public List<Marca> Insert(Marca entity)
        {
            try
            {
                if (_instance == null) _instance = new MarcaService();
                if (_marcas == null) _marcas = new List<Marca>();
                _marcas.Add(entity);
                return _marcas;
            }
            catch (Exception e)
            {
                throw new Exception("No se pudo agregar marca.");
            }
        }

        public List<Marca> Update(Marca entity)
        {
            try
            {
                _marcas.RemoveAll(x => x == entity);
                _marcas.Add(entity);
                return _marcas;
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo actualizar marca.");
            }
        }
    }
}
