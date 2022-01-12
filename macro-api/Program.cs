using Microsoft.Data.Sqlite;
using Newtonsoft.Json;
using System.Data;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddCors(setup => setup.AddDefaultPolicy(policy => policy.WithOrigins("http://localhost:9000", "https://sandwichpouletmayonnaise.com")));

var app = builder.Build();

app.MapGet("api/entreesdujour", () =>
{
    var connectionStringBuilder = new SqliteConnectionStringBuilder()
    {
        DataSource = "c:/sqlite3/pouletmayo.db"
    };

    using (var connection = new SqliteConnection(connectionStringBuilder.ConnectionString))
    {
        try
        {
            connection.Open();

            var selectCmd = connection.CreateCommand();
            selectCmd.CommandText = "SELECT * FROM ENTREES WHERE jour = strftime('%w','now');";

            DataTable dt = new DataTable();
            using (var reader = selectCmd.ExecuteReader())
            {
                dt.Load(reader);
            }

            return Results.Text(JsonConvert.SerializeObject(dt));
        }
        catch (Exception ex)
        {
            return Results.Json(new { error = ex.Message });
        }
    }
});

app.UseCors();

app.Run();