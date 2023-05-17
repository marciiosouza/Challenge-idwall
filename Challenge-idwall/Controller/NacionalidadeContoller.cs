using Challenge_idwall.Context;
using Challenge_idwall.Model;
using Challenge_idwall.Respository;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Storage;
using RouteAttribute = Microsoft.AspNetCore.Components.RouteAttribute;

namespace Challenge_idwall.Controller

{
    [Route("api/[controller]")]
    [ApiController]
    public class NacionalodadeController : ControllerBase
    {
        private readonly NacionalidadeRepository NacionalidadeRepository;

        public NacionalodadeController(DataBaseContext dataBaseContext)
        {
            NacionalidadeRepository = new NacionalidadeRepository(dataBaseContext);
        }

        [HttpGet]
        public ActionResult<List<NacionalidadeModel>> Get()
        {
            try
            {
                var Lista = NacionalidadeRepository.ListarTodos();
                if (Lista != null)
                {
                    return Ok(Lista);

                }
                else
                {
                    return NotFound();
                }
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
    }
}