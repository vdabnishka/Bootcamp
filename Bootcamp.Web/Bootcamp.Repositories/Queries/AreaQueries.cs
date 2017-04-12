using Bootcamp.DataAccess;
using Bootcamp.Repositories.Contracts.Queries;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace Bootcamp.Repositories.Queries
{
	public class AreaQueries : IAreaQueries
	{
		private Func<BootcampEntities> _contextFactory;

		public AreaQueries() : this (() => new BootcampEntities())
		{

		}

		public AreaQueries(Func<BootcampEntities> contextFactory)
		{
			_contextFactory = contextFactory;
		}

		public async Task<IEnumerable<Models.Area>> Get()
		{
			using (var context = _contextFactory())
			{
				var results = await context.Areas.Select(area => new Models.Area
				{
					ID = area.Id,
					Name = area.Name
				}).ToListAsync();
				return results;
			}
		}

		public async Task<Models.Area> Get(int id)
		{
			using (var context = _contextFactory())
			{
				var result = await context.Areas.Select(area => new Models.Area
				{
					ID = area.Id,
					Name = area.Name
				}).SingleOrDefaultAsync(a => a.ID == id);

				return result;
			}
		}
    }
}
