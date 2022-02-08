using System.Threading.Tasks;
using ProEventos.Domain;

namespace ProEventos.Persistence.Contratos
{
    public interface IPalestrantePersist
    {
         // palestrantes
         Task<Palestrante[]> GetAllPalestrantesByNomeAsync(string name, bool includeEventos);
         Task<Palestrante[]> GetAllPalestrantesAsync(bool includeEventos);
         Task<Palestrante> GetPalestranteByIdAsync(int PalestranteId, bool includeEventos);
         
    }
}