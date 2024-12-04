using System;
using System.Data;
using System.Data.SqlClient;

namespace DesafioDePescaAPI.App_Start
{
    public class BD
    {
        private readonly string _connectionString;

        // Constructor sin parámetros que define directamente el connection string
        public BD()
        {
            _connectionString = @"Server=.\SQLEXPRESS;Database=DesafioDePescaDB;Trusted_Connection=True;";
        }

        // Constructor opcional para pasar un connection string dinámico (si alguna vez lo necesitas)
        public BD(string connectionString)
        {
            _connectionString = connectionString;
        }

        public int ExecuteCommand(string query, SqlParameter[] parameters = null)
        {
            try
            {
                using (var connection = new SqlConnection(_connectionString))
                {
                    using (var command = new SqlCommand(query, connection))
                    {
                        if (parameters != null)
                        {
                            command.Parameters.AddRange(parameters);
                        }

                        connection.Open();
                        return command.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception($"Error ejecutando comando SQL: {ex.Message}", ex);
            }
        }

        public DataTable ExecuteQuery(string query, SqlParameter[] parameters = null)
        {
            try
            {
                using (var connection = new SqlConnection(_connectionString))
                {
                    using (var command = new SqlCommand(query, connection))
                    {
                        if (parameters != null)
                        {
                            command.Parameters.AddRange(parameters);
                        }

                        using (var adapter = new SqlDataAdapter(command))
                        {
                            DataTable table = new DataTable();
                            adapter.Fill(table);
                            return table;
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception($"Error ejecutando consulta SQL: {ex.Message}", ex);
            }
        }

        public object ExecuteScalar(string query, SqlParameter[] parameters = null)
        {
            try
            {
                using (var connection = new SqlConnection(_connectionString))
                {
                    using (var command = new SqlCommand(query, connection))
                    {
                        if (parameters != null)
                        {
                            command.Parameters.AddRange(parameters);
                        }

                        connection.Open();
                        return command.ExecuteScalar();
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception($"Error ejecutando operación escalar SQL: {ex.Message}", ex);
            }
        }
    }
}