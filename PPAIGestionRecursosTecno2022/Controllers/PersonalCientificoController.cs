using Microsoft.AspNetCore.Mvc;
using PPAIGestionRecursosTecno2022.Models;

namespace PPAIGestionRecursosTecno2022.Controllers
{
    public class PersonalCientificoController : GenericController<PersonalCientifico>
    {
        public PersonalCientificoController(IGenericService<PersonalCientifico> repoGenerico) : base(repoGenerico)
        {
        }
    }
}
