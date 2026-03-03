using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace ReportingSystem.DataAccessLayer
{
    public class RawMaterialDataAccess
    {
        private string connectionString;

        public RawMaterialDataAccess(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void Insert(RawMaterial rawMaterial)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "INSERT INTO RawMaterials (Name, Quantity, Date) VALUES (@Name, @Quantity, @Date)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Name", rawMaterial.Name);
                    command.Parameters.AddWithValue("@Quantity", rawMaterial.Quantity);
                    command.Parameters.AddWithValue("@Date", rawMaterial.Date);
                    command.ExecuteNonQuery();
                }
            }
        }

        public List<RawMaterial> GetReportsByDateRange(DateTime startDate, DateTime endDate)
        {
            List<RawMaterial> rawMaterials = new List<RawMaterial>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM RawMaterials WHERE Date BETWEEN @StartDate AND @EndDate";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@StartDate", startDate);
                    command.Parameters.AddWithValue("@EndDate", endDate);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            rawMaterials.Add(new RawMaterial
                            {
                                Name = reader["Name"].ToString(),
                                Quantity = Convert.ToInt32(reader["Quantity"]),
                                Date = Convert.ToDateTime(reader["Date"])
                            });
                        }
                    }
                }
            }
            return rawMaterials;
        }
    }

    public class RawMaterial
    {
        public string Name { get; set; }
        public int Quantity { get; set; }
        public DateTime Date { get; set; }
    }
}