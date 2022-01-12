using api_sample.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.Sqlite;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace api_sample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EntreesDuJourController : ControllerBase
    {
        // GET: api/<EntreesDuJourController>
        [HttpGet]
        public IEnumerable<EntreesDuJour> Get()
        {
            var connectionStringBuilder = new SqliteConnectionStringBuilder()
            {
                DataSource = "c:/sqlite3/pouletmayo.db"
            };

            using (var connection = new SqliteConnection(connectionStringBuilder.ConnectionString))
            {
                connection.Open();

                var selectCmd = connection.CreateCommand();
                selectCmd.CommandText = "SELECT * FROM ENTREES WHERE jour = strftime('%w','now');";

                using (var reader = selectCmd.ExecuteReader())
                {
                    var entreesDuJour = new List<EntreesDuJour>();
                    while (reader.Read())
                    {
                        entreesDuJour.Add(new EntreesDuJour()
                        {
                            jour = reader.GetInt16(0),
                            Nom = reader.GetString(1),
                            Description = reader.GetString(2),
                            Vegan = reader.GetBoolean(3)
                        });
                    }
                    return entreesDuJour;
                }
            }
        }
    }
}
