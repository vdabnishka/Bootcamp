using System.Collections.Generic;
using System.Threading.Tasks;

namespace Bootcamp.Repositories.Contracts.Queries
{
	public interface IAreaQueries
	{
		Task<IEnumerable<Models.Area>> Get();
		Task<Models.Area> Get(int id);
	}
}