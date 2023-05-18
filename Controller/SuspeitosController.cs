using Challenge_idwall.Context;
using Challenge_idwall.Model;
using Challenge_idwall.Respository;
using Microsoft.AspNetCore.Mvc;

namespace Challenge_idwall.Controller

{
    [ApiController]
    [Route("api/[controller]")]
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
       // [HttpGet("{nome:string}")]
       // public ActionResult<SuspeitosModel> Get([FromRoute] string nome )
       // {
           // try
           // {
           //     var pessoa = suspeitoRepository.BuscarPorNomde(nome);
           //     return Ok(pessoa);
           // }catch(KeyNotFoundException ex) 
           // {
           //     throw ex;
          //  }
       // }
            

    }
}
