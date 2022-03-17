
using Common.Utils.Enums;
using Infraestructure.Entity.Model;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Infraestructure.Core.Data
{
    public class SeedDb
    {
        private readonly DataContext _context;

        #region Builder
        public SeedDb(DataContext context)
        {
            _context = context;
        }
        #endregion

        public async Task ExecSeedAsync()
        {
            await _context.Database.EnsureCreatedAsync();
           
            //await CheckTypeIdentificationAsync();
            await CheckTypePermissionAsync();
           
            await CheckRolAsync();
            await CheckPermissionAsync();
            await CheckRolPermissionAsync();
            await CheckUsersAsync();
          //  await CheckRolUserAsync();
            //await CheckCategory();
            
        }




        private async Task CheckUsersAsync()
        {
            if (!_context.RolUserEntity.Any())
            {
                _context.RolUserEntity.AddRange(new List<RolUserEntity>
{
                    new RolUserEntity()
                    {
                    IdRol = (int)Enums.RolUser.Estandar,
                    UserEntity = new UserEntity()
                    {
                    Name = "juan",
                    LastName = "estandar",
                    Email = "hola@gmail.com",
                    Password = "1234"
                    }
                    },

                    new RolUserEntity()
                    {
                    IdRol = (int)Enums.RolUser.Administrador,
                    UserEntity = new UserEntity()
                    {
                    Name = "luis",
                    LastName = "admin",
                    Email = "dro783249@gmail.com",
                    Password = "1234"
                    }
                    },
                    });



                    await _context.SaveChangesAsync();
                }
            }

        private async Task CheckRolAsync()
        {
            if (!_context.RolEntity.Any())
            {
                _context.RolEntity.AddRange(new List<RolEntity>
                {
                    new RolEntity
                    {
                        IdRol = (int)Enums.RolUser.Administrador,
                        Rol = "Administrador"
                    },
                    new RolEntity
                    {
                        IdRol = (int)Enums.RolUser.Estandar,
                        Rol = "Estandar"
                    }
                  
                });
                await _context.SaveChangesAsync();
            }
        }



  

        private async Task CheckTypePermissionAsync()
        {
            if (!_context.TypePermissionEntity.Any())
            {
                _context.TypePermissionEntity.AddRange(new List<TypePermissionEntity>
                {
                    new TypePermissionEntity
                    {
                        IdTypePermission=(int)Enums.TypePermission.Usuarios,
                        TypePermission="Usuarios"
                    },
                    new TypePermissionEntity
                    {
                         IdTypePermission=(int)Enums.TypePermission.Roles,
                        TypePermission="Roles"
                    },
                    new TypePermissionEntity
                    {
                         IdTypePermission=(int)Enums.TypePermission.Permisos,
                        TypePermission="Permisos"
                    },
                    new TypePermissionEntity
                    {
                         IdTypePermission=(int)Enums.TypePermission.Libreria,
                        TypePermission="Libreria"

                    },
                       new TypePermissionEntity
                    {
                         IdTypePermission=(int)Enums.TypePermission.Autores,
                        TypePermission="Autores"

                    },

                       new TypePermissionEntity
                    {

                        IdTypePermission=(int)Enums.TypePermission.Editoriales,
                        TypePermission="Editoriales"

                    },
                });
                await _context.SaveChangesAsync();
            }
        }

        private async Task CheckPermissionAsync()
        {
            if (!_context.PermissionEntity.Any())
            {
                _context.PermissionEntity.AddRange(new List<PermissionEntity>
                {
                    new PermissionEntity
                    {
                        IdPermission=(int)Enums.Permission.CrearUsuarios,
                        IdTypePermission=(int)Enums.TypePermission.Usuarios,
                        Permission="Crear Usuarios",
                        Description="Crear usuarios en el sistema"
                    },
                    new PermissionEntity
                    {
                        IdPermission=(int)Enums.Permission.ActualizarUsuarios,
                        IdTypePermission=(int)Enums.TypePermission.Usuarios,
                        Permission="Actualizar Usuarios",
                        Description="Actualizar datos de un  usuarios en el sistema"
                    },
                    new PermissionEntity
                    {
                        IdPermission=(int)Enums.Permission.EliminarUsuario,
                        IdTypePermission=(int)Enums.TypePermission.Usuarios,
                        Permission="Eliminar Usuarios",
                        Description="Eliminar un usuario del Sistema"
                    },
                    new PermissionEntity
                    {
                        IdPermission=(int)Enums.Permission.ConsultarUsuarios,
                        IdTypePermission=(int)Enums.TypePermission.Usuarios,
                        Permission="Consultar Usuarios",
                        Description="Consultar Todos Los usuarios"
                    },
                    new PermissionEntity
                    {
                        IdPermission=(int)Enums.Permission.ConsultarRoles,
                        IdTypePermission=(int)Enums.TypePermission.Roles,
                        Permission="Consultar Roles",
                        Description="Consultar Roles del sistema"
                    },
                     new PermissionEntity
                    {
                        IdPermission=(int)Enums.Permission.ActualizarRoles,
                        IdTypePermission=(int)Enums.TypePermission.Roles,
                        Permission="Actualizar Roles",
                        Description="Actualizar datos de Roles del sistema"
                    },
                      new PermissionEntity
                    {
                        IdPermission=(int)Enums.Permission.ActualizarPermisos,
                        IdTypePermission=(int)Enums.TypePermission.Permisos,
                        Permission="Actualizar Permisos",
                        Description="Actualizar datos de un permiso en el sistema"
                    },
                       new PermissionEntity
                    {
                        IdPermission=(int)Enums.Permission.ConsultarPermisos,
                        IdTypePermission=(int)Enums.TypePermission.Permisos,
                        Permission="Consultar Permisos",
                        Description="Consultar Permisos delsistema"
                    },
                        new PermissionEntity
                    {
                        IdPermission=(int)Enums.Permission.DenegarPermisos,
                        IdTypePermission=(int)Enums.TypePermission.Permisos,
                        Permission="Denegar permisos Rol",
                        Description="Denegar Permisos a un rol del sistema"
                    },

                        //AUTORES
                         new PermissionEntity
                    {
                        IdPermission=(int)Enums.Permission.ConsultarAutores,
                        IdTypePermission=(int)Enums.TypePermission.Autores,
                        Permission="Consultar Autores",
                        Description="Consultar lista de autores"
                    },
                          new PermissionEntity
                    {
                        IdPermission=(int)Enums.Permission.ActualizarAutores,
                        IdTypePermission=(int)Enums.TypePermission.Autores,
                        Permission="Actualizar Autores",
                        Description="Actualizar datos de los autores"
                    },
                                 new PermissionEntity
                    {
                        IdPermission=(int)Enums.Permission.EliminarAutores,
                        IdTypePermission=(int)Enums.TypePermission.Autores,
                        Permission="Eliminar Autores",
                        Description="Eliminar Autores del sistema"
                    },
                                 new PermissionEntity
                      {
                        IdPermission=(int)Enums.Permission.CrearAutores,
                        IdTypePermission=(int)Enums.TypePermission.Autores,
                        Permission="Crear Autores",
                        Description="Crear nuevos autores en el sistema"
                    },
                       //EDITORIALES

                                  new PermissionEntity
                    {
                        IdPermission=(int)Enums.Permission.ConsultarEditoriales,
                        IdTypePermission=(int)Enums.TypePermission.Editoriales,
                        Permission="Consultar Editoriales",
                        Description="consultar la info de las editoriales"
                    },
                                         new PermissionEntity
                    {
                        IdPermission=(int)Enums.Permission.CrearEditoriales,
                        IdTypePermission=(int)Enums.TypePermission.Editoriales,
                        Permission="Crear Editoriales",
                        Description="Crear nuevas editoriales en la DB"
                    },
                        new PermissionEntity
                    {
                        IdPermission=(int)Enums.Permission.EliminarEditoriales,
                        IdTypePermission=(int)Enums.TypePermission.Editoriales,
                        Permission="Eliminar Editoriales",
                        Description="Eliminar editoriales de la DB"
                    },

                               new PermissionEntity
                    {
                        IdPermission=(int)Enums.Permission.ActualizarEditoriales,
                        IdTypePermission=(int)Enums.TypePermission.Editoriales,
                        Permission="Actualizar Editoriales",
                        Description="Actualizar editoriales de la DB"
                    },


                    //LIBROS
                                               new PermissionEntity
                    {
                        IdPermission=(int)Enums.Permission.ConsultarLibros,
                        IdTypePermission=(int)Enums.TypePermission.Libreria,
                        Permission="Consultar Libros",
                        Description="Consultar informacion de los libros de la bd"
                    },

                                                  new PermissionEntity
                    {
                        IdPermission=(int)Enums.Permission.CrearLibro,
                        IdTypePermission=(int)Enums.TypePermission.Libreria,
                        Permission="Crear Libros",
                        Description="Crear nuevos libros en la BD"
                    },
                                                     new PermissionEntity
                    {
                        IdPermission=(int)Enums.Permission.ActualizarLibros,
                        IdTypePermission=(int)Enums.TypePermission.Libreria,
                        Permission="Actualizar  Libros",
                        Description="Actualizar libros de la BD"
                    },
                                                       new PermissionEntity
                    {
                        IdPermission=(int)Enums.Permission.EliminarLibros,
                        IdTypePermission=(int)Enums.TypePermission.Libreria,
                        Permission="Eliminar libros",
                        Description="Eliminar libros de la BD"
                    },
                });
                await _context.SaveChangesAsync(); //importantisimo esto para poder guardar datos
            }

        }

        private async Task CheckRolPermissionAsync()
        {
            if (!_context.RolPermissionEntity.Where(x => x.IdRol == (int)Enums.RolUser.Administrador).Any())
            {
                var rolesPermisosAdmin = _context.PermissionEntity.Select(x => new RolPermissionEntity
                {
                    IdRol = (int)Enums.RolUser.Administrador,
                    IdPermission = x.IdPermission
                }).ToList();

                _context.RolPermissionEntity.AddRange(rolesPermisosAdmin);

                //USUARIO ESTANDAR
                _context.RolPermissionEntity.AddRange(new List<RolPermissionEntity>
{

new RolPermissionEntity
{
IdRol = (int)Enums.RolUser.Estandar,
IdPermission = (int)Enums.Permission.ConsultarLibros
},

new RolPermissionEntity
{
IdRol = (int)Enums.RolUser.Estandar,
IdPermission = (int)Enums.Permission.ConsultarEditoriales
},

new RolPermissionEntity
{
IdRol = (int)Enums.RolUser.Estandar,
IdPermission = (int)Enums.Permission.ConsultarAutores
},


});




                await _context.SaveChangesAsync();
            }
        }
    }
}

