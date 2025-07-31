using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ligaBetplay.Dominio.Entidades;
using ligaBetplay.Dominio.Interfaces;
using MySql.Data.MySqlClient;

namespace ligaBetplay.Infraestructura.Repositorios
{
    public class MySqlTorneoRepository : ITorneoRepository                                                                                                                                                                                                                                                                                                                        
    {
        private readonly string _connectionString;

        public MySqlTorneoRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public void AddTorneo(Torneo torneo)
        {
            using var conn = new MySqlConnection(_connectionString);
            conn.Open();

            using var cmd = conn.CreateCommand();
            cmd.CommandText = @"
                INSERT INTO torneos (nombre, fecha_inicio, fecha_fin, ubicacion, estado)
                VALUES (@nombre, @inicio, @fin, @ubicacion, @estado)";
            cmd.Parameters.AddWithValue("@nombre", torneo.Nombre);
            cmd.Parameters.AddWithValue("@inicio", torneo.FechaInicio);
            cmd.Parameters.AddWithValue("@fin", torneo.FechaFin);
            cmd.Parameters.AddWithValue("@ubicacion", torneo.Ubicacion);
            cmd.Parameters.AddWithValue("@estado", torneo.Estado);

            cmd.ExecuteNonQuery();
        }

        public void DeleteTorneo(int id)
        {
            using var conn = new MySqlConnection(_connectionString);
            conn.Open();

            using var cmd = conn.CreateCommand();
            cmd.CommandText = "DELETE FROM torneos WHERE id = @id";
            cmd.Parameters.AddWithValue("@id", id);

            cmd.ExecuteNonQuery();
        }

        public IEnumerable<Torneo> GetAllTorneos()
        {
            var torneos = new List<Torneo>();

            using var conn = new MySqlConnection(_connectionString);
            conn.Open();

            using var cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM torneos";

            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                torneos.Add(new Torneo
                {
                    Id = reader.GetInt32("id"),
                    Nombre = reader.GetString("nombre"),
                    FechaInicio = reader.GetDateTime("fecha_inicio"),
                    FechaFin = reader.GetDateTime("fecha_fin"),
                    Ubicacion = reader.GetString("ubicacion"),
                    Estado = reader.GetString("estado")
                });
            }

            return torneos;
        }

        public Torneo? GetTorneoById(int id)
        {
            using var conn = new MySqlConnection(_connectionString);
            conn.Open();

            using var cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM torneos WHERE id = @id";
            cmd.Parameters.AddWithValue("@id", id);

            using var reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                return new Torneo
                {
                    Id = reader.GetInt32("id"),
                    Nombre = reader.GetString("nombre"),
                    FechaInicio = reader.GetDateTime("fecha_inicio"),
                    FechaFin = reader.GetDateTime("fecha_fin"),
                    Ubicacion = reader.GetString("ubicacion"),
                    Estado = reader.GetString("estado")
                };
            }

            return null;
        }

        public void UpdateTorneo(Torneo torneo)
        {
            using var conn = new MySqlConnection(_connectionString);
            conn.Open();

            using var cmd = conn.CreateCommand();
            cmd.CommandText = @"
                UPDATE torneos 
                SET nombre = @nombre, fecha_inicio = @inicio, fecha_fin = @fin,
                    ubicacion = @ubicacion, estado = @estado 
                WHERE id = @id";

            cmd.Parameters.AddWithValue("@id", torneo.Id);
            cmd.Parameters.AddWithValue("@nombre", torneo.Nombre);
            cmd.Parameters.AddWithValue("@inicio", torneo.FechaInicio);
            cmd.Parameters.AddWithValue("@fin", torneo.FechaFin);
            cmd.Parameters.AddWithValue("@ubicacion", torneo.Ubicacion);
            cmd.Parameters.AddWithValue("@estado", torneo.Estado);

            cmd.ExecuteNonQuery();
        }
    }
}