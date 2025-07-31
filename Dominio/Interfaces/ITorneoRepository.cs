using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ligaBetplay.Dominio.Entidades;

namespace ligaBetplay.Dominio.Interfaces
{
    public interface ITorneoRepository
    {
        void AddTorneo(Torneo torneo);
        Torneo? GetTorneoById(int id);
        IEnumerable<Torneo> GetAllTorneos();
        void UpdateTorneo(Torneo torneo);
        void DeleteTorneo(int id);
    }
}