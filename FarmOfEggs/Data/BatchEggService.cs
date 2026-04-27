using FarmOfEggs.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmOfEggs.Data
{
    public class BatchEggService
    {
        private DataAccess db = new DataAccess();

        public void Insert(BatchEgg egg)
        {
            using (var conn = db.GetConnection())
            {
                conn.Open();
                var cmd = new SqlCommand(
                    @"INSERT INTO BatchEgg
                (BirdGroupID, Size, DateProduced, BestByDate, Grade, EggColor)
                VALUES (@BirdGroupID, @Size, @DateProduced, @BestByDate, @Grade, @EggColor)", conn);

                cmd.Parameters.AddWithValue("@BirdGroupID", egg.BirdGroupID);
                cmd.Parameters.AddWithValue("@Size", egg.Size);
                cmd.Parameters.AddWithValue("@DateProduced", egg.DateProduced);
                cmd.Parameters.AddWithValue("@BestByDate", egg.BestByDate);
                cmd.Parameters.AddWithValue("@Grade", egg.Grade);
                cmd.Parameters.AddWithValue("@EggColor", egg.EggColor);

                cmd.ExecuteNonQuery();
            }
        }
        public void Update(BatchEgg egg)
        {
            using (var conn = db.GetConnection())
            {
                conn.Open();
                var cmd = new SqlCommand(
                    @"UPDATE BatchEgg SET
                BirdGroupID = @BirdGroupID,
                Size = @Size,
                DateProduced = @DateProduced,
                BestByDate = @BestByDate,
                Grade = @Grade,
                EggColor = @EggColor
              WHERE BatchEggID = @BatchEggID", conn);

                cmd.Parameters.AddWithValue("@BatchEggID", egg.BatchEggID);
                cmd.Parameters.AddWithValue("@BirdGroupID", egg.BirdGroupID);
                cmd.Parameters.AddWithValue("@Size", egg.Size);
                cmd.Parameters.AddWithValue("@DateProduced", egg.DateProduced);
                cmd.Parameters.AddWithValue("@BestByDate", egg.BestByDate);
                cmd.Parameters.AddWithValue("@Grade", egg.Grade);
                cmd.Parameters.AddWithValue("@EggColor", egg.EggColor);

                cmd.ExecuteNonQuery();
            }
        }
        public void Delete(int id)
        {
            using (var conn = db.GetConnection())
            {
                conn.Open();
                var cmd = new SqlCommand(
                    "DELETE FROM BatchEgg WHERE BatchEggID = @ID", conn);

                cmd.Parameters.AddWithValue("@ID", id);
                cmd.ExecuteNonQuery();
            }
        }
        public List<BatchEgg> GetAll()
        {
            var list = new List<BatchEgg>();

            using (var conn = db.GetConnection())
            {
                conn.Open();
                var cmd = new SqlCommand("SELECT * FROM BatchEgg", conn);
                var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    list.Add(new BatchEgg
                    {
                        BatchEggID = (int)reader["BatchEggID"],
                        BirdGroupID = (int)reader["ChickenGroupID"],
                        Size = reader["Size"].ToString(),
                        DateProduced = (DateTime)reader["DateProduced"],
                        BestByDate = (DateTime)reader["BestByDate"],
                        Grade = reader["Grade"].ToString(),
                        EggColor = reader["EggColor"].ToString()
                    });
                }
            }

            return list;
        }
    }
}
