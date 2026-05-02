// Data/DataAccessReports.cs
using System.Data;
using System.Data.SqlClient;

namespace FarmOfEggs.Data
{
    public class DataAccessReports
    {
        private string connectionString =
            "Server=(localdb)\\MSSQLLocalDB;Database=FarmOfEggs;Trusted_Connection=True;";

        public DataTable GetEggsSoldByRetail()
        {
            string query = @"
                SELECT R.Name AS RetailStore, SUM(ES.AvgUnit) AS TotalEggsSold
                FROM EggSales ES
                INNER JOIN Retail R ON R.RetailID = ES.RetailID
                WHERE ES.CanceledOn IS NULL
                GROUP BY R.Name
                ORDER BY TotalEggsSold DESC";

            return RunQuery(query);
        }

        public DataTable GetAvgPriceByGrade()
        {
            string query = @"
                SELECT BE.Grade, AVG(ES.UnitPrice) AS AvgUnitPrice, SUM(ES.AvgUnit) AS TotalUnits
                FROM EggSales ES
                INNER JOIN BatchEgg BE ON BE.BatchEggID = ES.BatchEggID
                WHERE ES.CanceledOn IS NULL
                GROUP BY BE.Grade
                ORDER BY AvgUnitPrice DESC";

            return RunQuery(query);
        }

        public DataTable GetRevenueByFarm()
        {
            string query = @"
                SELECT F.Name AS FarmName, F.Location,
                       COUNT(ES.EggSalesID) AS NumberOfSales,
                       SUM(ES.AvgUnit * ES.UnitPrice) AS TotalRevenue
                FROM EggSales ES
                INNER JOIN BatchEgg  BE ON BE.BatchEggID  = ES.BatchEggID
                INNER JOIN BirdGroup BG ON BG.BirdGroupID = BE.BirdGroupID
                INNER JOIN Farm       F ON F.FarmID       = BG.FarmID
                WHERE ES.CanceledOn IS NULL
                GROUP BY F.Name, F.Location
                ORDER BY TotalRevenue DESC";

            return RunQuery(query);
        }

        public DataTable GetRevenueByBreed()
        {
            string query = @"
                SELECT BB.BreedName, SUM(ES.AvgUnit * ES.UnitPrice) AS TotalRevenue
                FROM EggSales ES
                INNER JOIN BatchEgg  BE ON BE.BatchEggID  = ES.BatchEggID
                INNER JOIN BirdGroup BG ON BG.BirdGroupID = BE.BirdGroupID
                INNER JOIN BirdBreed BB ON BB.BirdBreedID = BG.BirdBreedID
                WHERE ES.CanceledOn IS NULL
                GROUP BY BB.BreedName
                ORDER BY TotalRevenue DESC";

            return RunQuery(query);
        }

        private DataTable RunQuery(string query)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
            {
                DataTable table = new DataTable();
                adapter.Fill(table);
                return table;
            }
        }
    }
}