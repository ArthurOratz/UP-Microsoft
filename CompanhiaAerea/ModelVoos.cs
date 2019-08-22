namespace CompanhiaAerea
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class ModelVoos : DbContext
    {
        
        public ModelVoos()
            : base("name=ModelVoos")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Passagem>().HasOptional<FormaPagamento>(f => f.Pagamento).WithOptionalPrincipal<Passagem>(f => f.Passagem);
        }

        public virtual DbSet<Pessoa> Pessoas { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}