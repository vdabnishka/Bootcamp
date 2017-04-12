using System.Collections.Generic;
using System.Web.Http;
using Bootcamp.Models;
using Bootcamp.Repositories.Contracts.Queries;
using System.Threading.Tasks;
using Bootcamp.Repositories.Queries;

namespace Bootcamp.Web.Controllers
{
	public class AreaQueryController : ApiController
	{
		private IAreaQueries _queryRepo;

		public AreaQueryController() : this(new AreaQueries())
		{
		}

		public AreaQueryController(IAreaQueries repo)
		{
			_queryRepo = repo;
		}

		// GET api/<controller>
		public async Task<IEnumerable<Area>> Get()
		{
			return await _queryRepo.Get();
		}

		// GET api/<controller>/5
		public async Task<Area> Get(int id)
		{
			return await _queryRepo.Get(id);
		}

		// POST api/<controller>
		public void Post([FromBody]string value)
		{
			// update area
		}

		// PUT api/<controller>/5
		public void Put(int id, [FromBody]string value)
		{
			// create area
		}

		// DELETE api/<controller>/5
		public void Delete(int id)
		{
			// delete area
		}
	}
}