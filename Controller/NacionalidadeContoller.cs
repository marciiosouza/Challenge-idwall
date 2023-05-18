
using Challenge_idwall.Context;
using Challenge_idwall.Model;
using Challenge_idwall.Respository;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc;

namespace Challenge_idwall.Controller

{
    [ApiController]
    [Route("api/[controller]")]
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