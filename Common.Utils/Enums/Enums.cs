using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Utils.Enums
{
   public class Enums
    {

       
      

        public enum TypePermission
        {
            Usuarios=1,
            Roles=2,
            Permisos=3,
            Libreria=4,
            Autores=5,
            Editoriales=6
           
        
        }

        public enum Permission
        {
            //usuarios
            CrearUsuarios = 1,
            ActualizarUsuarios = 2,
            EliminarUsuario = 3,
            ConsultarUsuarios = 4,

            //Roles
            ActualizarRoles = 5,
            ConsultarRoles = 6,

            //Permisos
            ActualizarPermisos = 7,
            ConsultarPermisos = 8,
            DenegarPermisos = 9,



            //Libreria
            CrearLibro = 10,
            ConsultarLibros = 11,
            EliminarLibros = 12,
            ActualizarLibros = 13,

            //Autores
            CrearAutores = 14,
            ConsultarAutores = 15,
            EliminarAutores = 16,
            ActualizarAutores = 17,

            //Editoriales
            CrearEditoriales = 18,
            ConsultarEditoriales = 19,
            EliminarEditoriales = 20,
            ActualizarEditoriales = 21,
        }

        public enum RolUser
        {
            Administrador=1,
            Estandar=2
          
             

        }

    }
}
