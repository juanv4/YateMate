using YateMate.Aplicacion.Entidades;
namespace YateMate.Aplicacion.Interfaces;

public interface IRepositorioOferta
{
    List<Publicacion> ListarTruequesDisponibles();
    void HacerOferta(Oferta oferta);
    void EliminarOferta(int id);
    
}