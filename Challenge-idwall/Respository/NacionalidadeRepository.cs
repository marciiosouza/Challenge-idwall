using Challenge_idwall.Context;
using Challenge_idwall.Model;

namespace Challenge_idwall.Respository
{
    public class NacionalidadeRepository
    {
        private readonly DataBaseContext dataBaseContext;

        public NacionalidadeRepository (DataBaseContext dataBaseContext)
        {
            this.dataBaseContext = dataBaseContext;


        }
        public IList<NacionalidadeModel> ListarTodos()

        {
            var Lista = new List<NacionalidadeModel>();
            Lista = dataBaseContext.Nacionalidade.ToList<NacionalidadeModel>();
            return Lista;

        }
    }
}
