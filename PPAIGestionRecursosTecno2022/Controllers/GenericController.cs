using Microsoft.AspNetCore.Mvc;

namespace PPAIGestionRecursosTecno2022.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class GenericController<T> : ControllerBase where T : class
    {
        private IGenericService<T> _genericService;

        public GenericController(IGenericService<T> repoGenerico)
        {
            _genericService = repoGenerico;
        }

        [HttpGet]
        public List<T> GetAll()
        {
            return _genericService.GetAll();
        }
        [HttpGet("{id}")]
        public T GetById(int id)
        {
            return _genericService.GetById(id);
        }
        [HttpPost]
        public List<T> Insert([FromBody] T value)
        {
            return _genericService.Insert(value);
        }
        //[HttpPut]
        //public List<T> Update([FromBody] T value)
        //{
        //    return _genericService.Update(value);
        //}
        [HttpDelete("{id}")]
        public List<T> Delete(int id)
        {
            return _genericService.Delete(id);
        }
    }
}
