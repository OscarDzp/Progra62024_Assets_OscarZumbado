namespace Progra62024_Assets_OscarZumbado.ModelsDTOs
{
    public class UserDTO
    {
        //un DTO (data transfer object ) sirve para objectivos.

        //1. desacoplar el modelo de la funcionalidad de los controller
        //para evitar que en futuras actualizaciones de los modelos
        //puedan ocurrir errores dificiles de reparar

        //2.sirve para simplificar modelos muy complejos muy complejos y que tienen
        //composiciones recursivas, muy comunes cuando se generan
        //mediante ORM como entity framework, Dapper, Djanpo.

        //3. Por un asunto de seguridad. ya que normalemnte los equipos
        //de desarrollo de las apps y web apis estan separados, y no 
        // se quiere que los programadores de front end sepan como esta
        //estructurada la base de datos tomando como base los modelos

        public int CodigoUsuario { get; set; }

        public string Cedula { get; set; } = null!;

        public string Nombre { get; set; } = null!;

        public string Apellidos { get; set; } = null!;

        public string? Telefono { get; set; }

        public string? Direccion { get; set; }

        public string Correo { get; set; } = null!;

        //en este ejemplo no usaremos la contrase;a ya que este DTO
        //sera usado para mostrar la lista de usuarios en una UI
        //tendremos otra version de DTO que si tiene la contrasenia
        //para cuando querramos agregar un usuario
     //   public string Contrasennia { get; set; } = null!;

        public bool? Activo { get; set; }

        public int CodigoDeRol { get; set; }

        public string? RolDeUsuario { get; set; }

        public string? NotasDelUsuario { get; set; }


        //aca se puede agregar los atribs que sean necesarios

    }
}
