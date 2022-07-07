using PPAIGestionRecursosTecno2022.Models;

namespace PPAIGestionRecursosTecno2022.Services
{
    public class PersonalCientificoService : IGenericService<PersonalCientifico>
    {
        private static PersonalCientificoService _instance;
        private static List<PersonalCientifico> _personalesCientificos;

        public static PersonalCientificoService GetInstance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new PersonalCientificoService();
                }
                return _instance;
            }
        }

        public List<PersonalCientifico> Delete(int id)
        {
            try
            {
                _personalesCientificos.RemoveAll(x => x.Legajo == id.ToString());
                return _personalesCientificos;
            }
            catch (Exception ex)
            {
                throw new Exception("No se encontró personal cientifico con ese ID.");

            }
        }

        public List<PersonalCientifico> GetAll()
        {
            if (_personalesCientificos == null) _personalesCientificos = new List<PersonalCientifico>();
            return _personalesCientificos;
        }

        public PersonalCientifico GetById(int id)
        {
            try
            {
                return _personalesCientificos.Where(x => x.Legajo == id.ToString()).SingleOrDefault();
            }
            catch (Exception ex)
            {
                throw new Exception("No se encontró personal cientifico con ese ID.");
            }
        }

        public PersonalCientifico GetByName(string name)
        {
            try
            {
                return _personalesCientificos.Where(x => x.Nombre == name).SingleOrDefault();
            }
            catch (Exception ex)
            {
                throw new Exception("No se encontró personal cientifico con ese nombre.");
            }
        }

        public List<PersonalCientifico> Insert(PersonalCientifico entity)
        {
            try
            {
                if (_instance == null) _instance = new PersonalCientificoService();
                if (_personalesCientificos == null) _personalesCientificos = new List<PersonalCientifico>();
                _personalesCientificos.Add(entity);
                return _personalesCientificos;
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo agregar personal cientìfico.");
            }
        }

        public List<PersonalCientifico> Update(PersonalCientifico entity)
        {
            try
            {
                _personalesCientificos.RemoveAll(x => x == entity);
                _personalesCientificos.Add(entity);
                return _personalesCientificos;
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo actualizar PC.");
            }
        }
    }
}
