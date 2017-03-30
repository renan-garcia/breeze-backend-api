using System.Linq;
using System.Web.Http;
using Breeze.WebApi2;
using System.Web.Http.Cors;
using Breeze.ContextProvider;
using Newtonsoft.Json.Linq;
using Northwind.Data;

namespace Northwind.Api.Controllers
{
  [BreezeController]
  [EnableCors(origins: "*", headers: "*", methods: "*")]

  public class NorthBreezeController : ApiController
  {
    private MeuContexto _northwind;

    protected override void Initialize(System.Web.Http.Controllers.HttpControllerContext controllerContext)
    {
      base.Initialize(controllerContext);
      _northwind = new MeuContexto();
    }

    [HttpGet]
    [Route("api/NorthBreeze/Metadata")]
    public string Metadata()
    {
      var provider = new Breeze.ContextProvider.EF6.EFContextProvider<MeuContexto>();
      var metaData = provider.Metadata();

      return metaData;
    }

    [HttpPost]
    public SaveResult SaveChanges(JObject saveBundle)
    {
      var provider = new Breeze.ContextProvider.EF6.EFContextProvider<MeuContexto>();
      
      var result = provider.SaveChanges(saveBundle);
      return result;
    }

    [HttpGet]
    public IQueryable<Cliente> Clientes()
    {
      var custs = _northwind.Clientes;
      return custs;
    }
  }
}