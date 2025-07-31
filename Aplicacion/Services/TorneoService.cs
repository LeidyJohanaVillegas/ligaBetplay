using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ligaBetplay.Dominio.Entidades;
using ligaBetplay.Dominio.Interfaces;

namespace ligaBetplay.Aplicacion.Services
{
    public class TorneoService
    {
        private readonly ITorneoRepository _repo;

        public TorneoService(ITorneoRepository repo)
        {
            _repo = repo;
        }

        public void CrearTorneo(Torneo torneo) => _repo.AddTorneo(torneo);
        public Torneo? BuscarTorneo(int id) => _repo.GetTorneoById(id);
        public void ActualizarTorneo(Torneo torneo) => _repo.UpdateTorneo(torneo);
        public void EliminarTorneo(int id) => _repo.DeleteTorneo(id);
    }
}