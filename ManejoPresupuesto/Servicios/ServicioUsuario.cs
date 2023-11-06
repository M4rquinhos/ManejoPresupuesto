namespace ManejoPresupuesto.Servicios
{

    public interface IServicioUsuarios
    {
        int ObtenerUsuario();
    }

    public class ServicioUsuario : IServicioUsuarios
    {

        public int ObtenerUsuario()
        {
            return 1;
        }

    }
}
