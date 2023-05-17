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
    public class SuspeitosController : ControllerBase
    {
        private readonly SuspeitoRepository suspeitoRepository;

        public SuspeitosController(DataBaseContext dataBaseContext)
        {
            suspeitoRepository = new SuspeitoRepository(dataBaseContext);
        }

        [HttpGet]
        public ActionResult<List<SuspeitosModel>> Get()
        {
            try
            {
                var Lista = suspeitoRepository.ListarTodos();
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
