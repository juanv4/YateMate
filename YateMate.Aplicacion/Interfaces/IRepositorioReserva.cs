using YateMate.Aplicacion.Entidades;

namespace YateMate.Aplicacion.Interfaces;

public interface IRepositorioReserva
{
    void HacerReserva(Reserva reserva, Subalquiler? subalquiler);
    void CancelarReserva(int id);
    void ModificarReserva(Reserva reserva);
    List<Reserva> ListarReservasDe(string usuarioId);
    List<Reserva> ListarReservasDeSubalquiler(int subalquilerId);
    Reserva? ObtenerReserva(int id);
    ApplicationUser? ObtenerDuenioReserva(string id);
    List<Reserva> ObtenerReservasDeSubalquiler(int id);
}