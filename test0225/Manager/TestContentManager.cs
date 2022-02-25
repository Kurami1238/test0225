using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using test0225.Models;

namespace test0225.Manager
{
    public class TestContentManager
    {

        public void CreateTestContent(TestContent model)
        {
            string connStr = "Server=localhost;Database=Test0225;Integrated Security=True;";
            string commandText =
                @"  INSERT INTO TestContents
                    (BaseNumber, CoefficientNumber)
                VALUES
                    (@BaseNumber, @CoefficientNumber)";
            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    using (SqlCommand command = new SqlCommand(commandText, conn))
                    {
                        conn.Open();

                        command.Parameters.AddWithValue("@BaseNumber", model.BaseNumber);
                        command.Parameters.AddWithValue("@CoefficientNumber", model.CoefficientNumber);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}