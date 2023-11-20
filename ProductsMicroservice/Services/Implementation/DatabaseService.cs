using ProductsMicroservice.Persistance;

namespace ProductsMicroservice.Services.Implementation;

public class DatabaseService : IDatabaseService
{
	private readonly DatabaseContext _dbContext;
	public DatabaseService(DatabaseContext dbContext)
	{
		_dbContext = dbContext;
	}
}

