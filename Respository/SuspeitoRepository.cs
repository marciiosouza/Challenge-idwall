using Challenge_idwall.Context;
using Challenge_idwall.Model;

namespace Challenge_idwall.Respository
{
    public class SuspeitoRepository
    {
        private readonly DataBaseContext dataBaseContext;

        public SuspeitoRepository(DataBaseContext dataBaseContext)
        {
            this.dataBaseContext = dataBaseContext;


        }
        public IList<SuspeitosModel> ListarTodos()
        
        {
            var Lista = new List<SuspeitosModel>();
            Lista = dataBaseContext.Suspeito.ToList<SuspeitosModel>();
            return Lista;

        }

        public SuspeitosModel BuscarPorNomde(string nome)
        {
            var pessoa = dataBaseContext.Suspeito.Find(nome);
            return pessoa;
        }
    }
}
