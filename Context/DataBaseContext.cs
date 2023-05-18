using Challenge_idwall.Model;
using Microsoft.EntityFrameworkCore;

namespace Challenge_idwall.Context
{
    public class DataBaseContext:DbContext
    {
        public DataBaseContext(DbContextOptions options) : base(options)
        {

        }

        protected DataBaseContext()
        {

        }

        public DbSet<SuspeitosModel> Suspeito { get; set; }

        public DbSet<NacionalidadeModel> Nacionalidade { get; set; }

    }


}
