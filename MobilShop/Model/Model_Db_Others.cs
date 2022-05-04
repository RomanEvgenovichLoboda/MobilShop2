using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace MobilShop
{
    public partial class Model_Db_Others : DbContext
    {
        public Model_Db_Others()
            : base("name=Model_Db_Others")
        {
        }

        public virtual DbSet<Mobile> Mobiles { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
