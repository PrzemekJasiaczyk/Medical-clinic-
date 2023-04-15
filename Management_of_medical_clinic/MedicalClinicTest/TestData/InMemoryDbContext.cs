using Console_Management_of_medical_clinic.Data;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using System.Data.Common;

namespace MedicalClinicTest.TestData
{
	public class InMemoryDbContext : IDisposable
	{
		readonly DbConnection _connection;
		readonly DbContextOptions<AppDbContext> _contextOptions;

		public InMemoryDbContext()
		{
			_connection = new SqliteConnection("Filename=:memory:");
			_connection.Open();

			_contextOptions = new DbContextOptionsBuilder<AppDbContext>()
				.UseSqlite(_connection)
				.Options;
		}

		public AppDbContext CreateTestContext()
		{
			return new AppDbContext(_contextOptions);
		}

		public void Dispose()
		{
			_connection.Dispose();
		}
	}
}
