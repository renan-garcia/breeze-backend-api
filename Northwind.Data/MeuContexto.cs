using System.Data.Entity;
namespace Northwind.Data
{
  public class MeuContexto : DbContext
  {
    public MeuContexto() : base("name=Northwind")
    { }
    public virtual DbSet<Cliente> Clientes { get; set; }
  }
}
