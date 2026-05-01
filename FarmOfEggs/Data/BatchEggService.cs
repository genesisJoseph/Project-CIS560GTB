using FarmOfEggs.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace FarmOfEggs.Data
{
    public class BatchEggService
    {
        private DataAccess db = new DataAccess();

        // Ensure this method is inside the BatchEggService class
        public void Delete(int id)
        {
            using (var conn = db.GetConnection())
            {
                conn.Open();
                var cmd = new SqlCommand("DELETE FROM BatchEgg WHERE BatchEggID = @ID", conn);
                cmd.Parameters.AddWithValue("@ID", id);
                cmd.ExecuteNonQuery();
            }
        }

        // Full Insert with all attributes
        public void Insert(BatchEgg egg)
        {
            using (var conn = db.GetConnection())
            {
                conn.Open();
                var cmd = new SqlCommand(
                    @"INSERT INTO BatchEgg (BirdGroupID, Quantity, Size, DateProduced, BestByDate, Grade, EggColor) 
                      VALUES (@BirdGroupID, @Quantity, @Size, @DateProduced, @BestByDate, @Grade, @EggColor)", conn);
                AddParameters(cmd, egg);
                cmd.ExecuteNonQuery();
            }
        }

        public void Update(BatchEgg egg)
        {
            using (var conn = db.GetConnection())
            {
                conn.Open();
                var cmd = new SqlCommand(
                    @"UPDATE BatchEgg 
                      SET BirdGroupID = @BirdGroupID, Quantity = @Quantity, Size = @Size, 
                          DateProduced = @DateProduced, BestByDate = @BestByDate, 
                          Grade = @Grade, EggColor = @EggColor 
                      WHERE BatchEggID = @BatchEggID", conn);
                cmd.Parameters.AddWithValue("@BatchEggID", egg.BatchEggID);
                AddParameters(cmd, egg);
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
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new BatchEgg
                        {
                            BatchEggID = (int)reader["BatchEggID"],
                            BirdGroupID = (int)reader["BirdGroupID"],
                            Quantity = (int)reader["Quantity"],
                            Size = reader["Size"]?.ToString(),
                            DateProduced = (DateTime)reader["DateProduced"],
                            BestByDate = reader["BestByDate"] as DateTime?,
                            Grade = reader["Grade"]?.ToString(),
                            EggColor = reader["EggColor"]?.ToString()
                        });
                    }
                }
            }
            return list;
        }
        public List<BatchEgg> GetRow(string id)
        {            
            var list = new List<BatchEgg>();
            using (var conn = db.GetConnection())
            {
                conn.Open();
                var cmd = new SqlCommand("SELECT * FROM BatchEgg WHERE BatchEggID = @id", conn);
                cmd.Parameters.AddWithValue("@id", id);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new BatchEgg
                        {
                            BatchEggID = (int)reader["BatchEggID"],
                            BirdGroupID = (int)reader["BirdGroupID"],
                            Quantity = (int)reader["Quantity"],
                            Size = reader["Size"]?.ToString(),
                            DateProduced = (DateTime)reader["DateProduced"],
                            BestByDate = reader["BestByDate"] as DateTime?,
                            Grade = reader["Grade"]?.ToString(),
                            EggColor = reader["EggColor"]?.ToString()
                        });
                    }
                }
            }
            return list;
        }
        private void AddParameters(SqlCommand cmd, BatchEgg egg)
        {
            cmd.Parameters.AddWithValue("@BirdGroupID", egg.BirdGroupID);
            cmd.Parameters.AddWithValue("@Quantity", egg.Quantity);
            cmd.Parameters.AddWithValue("@Size", (object)egg.Size ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@DateProduced", egg.DateProduced);
            cmd.Parameters.AddWithValue("@BestByDate", (object)egg.BestByDate ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@Grade", (object)egg.Grade ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@EggColor", (object)egg.EggColor ?? DBNull.Value);
        }
    }
}
