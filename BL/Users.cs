using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Users
    {
        public static ML.Result GetAll(ML.Users user)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL.MPatricioCentauroEntities context = new DL.MPatricioCentauroEntities())
                {
                    if (user.Name == null)
                    {
                        user.Name = "";
                    }
                    if (user.LastName == null)
                    {
                        user.LastName = "";
                    }
                    if (user.SurName == null)
                    {
                        user.SurName = "";
                    }
                    if (user.Email == null)
                    {
                        user.Email = "";
                    }
                    var GetAllResult = context.UserGetAll(user.Name, user.LastName, user.SurName, user.Email).ToList();
                    result.Objects = new List<object>();
                    if (GetAllResult != null)
                    {
                        foreach (var obj in GetAllResult)
                        {
                            ML.Users usuario = new ML.Users();
                            usuario.Id = obj.Id;
                            usuario.Roles = new ML.Roles();
                            usuario.Roles.IdRole = obj.IdRole;
                            usuario.Roles.RoleName = obj.RoleName;
                            usuario.Name = obj.Name;
                            usuario.LastName = obj.LastName;
                            usuario.SurName = obj.SurName;
                            usuario.Email = obj.Email;
                            usuario.UserName = obj.UserName;
                            usuario.contrasena = obj.contrasena;
                            usuario.Parent = obj.Parent.Value;
                            usuario.Estatus = obj.Estatus;
                            result.Objects.Add(usuario);
                        }
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                        result.ErrorMessage = "No se encontraron registros";
                    }
                }
            }
            catch (Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
                result.Ex = ex;
            }
            return result;
        }
        public static ML.Result GetById(int IdUser)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL.MPatricioCentauroEntities context = new DL.MPatricioCentauroEntities())
                {
                    var GetByIdResult = context.UserGetById(IdUser).FirstOrDefault();
                    if (GetByIdResult != null)
                    {
                        ML.Users usuario = new ML.Users();
                        usuario.Id = GetByIdResult.Id;
                        usuario.Roles = new ML.Roles();
                        usuario.Roles.IdRole = GetByIdResult.IdRole;
                        usuario.Roles.RoleName = GetByIdResult.RoleName;
                        usuario.Name = GetByIdResult.Name;
                        usuario.LastName = GetByIdResult.LastName;
                        usuario.SurName = GetByIdResult.SurName;
                        usuario.Email = GetByIdResult.Email;
                        usuario.UserName = GetByIdResult.UserName;
                        usuario.contrasena = GetByIdResult.contrasena;
                        usuario.Parent = GetByIdResult.Parent.Value;
                        usuario.Estatus = GetByIdResult.Estatus;
                        result.Object = usuario;
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                        result.ErrorMessage = "No se encontro ningun registro";
                    }
                }
            }
            catch (Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
                result.Ex = ex;
            }
            return result;
        }
        public static ML.Result Add(ML.Users users)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL.MPatricioCentauroEntities context = new DL.MPatricioCentauroEntities())
                {
                    var AddResult = context.UserAdd(users.Roles.IdRole, users.Name, users.LastName, users.SurName, users.Email, users.UserName, users.contrasena, users.Parent, users.Estatus);
                    if (AddResult >= 1)
                    {
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                        result.ErrorMessage = "El usuario no se inserto correctamente";
                    }
                }
            }
            catch (Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
                result.Ex = ex;
            }
            return result;
        }
        public static ML.Result Update(ML.Users users)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL.MPatricioCentauroEntities context = new DL.MPatricioCentauroEntities())
                {
                    var UpdateResult = context.UserUpdate(users.Id, users.Roles.IdRole, users.Name, users.LastName, users.SurName, users.Email, users.UserName, users.contrasena, users.Parent, users.Estatus);
                    if (UpdateResult >= 1)
                    {
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                        result.ErrorMessage = "El usuario no se modifico correctamente";
                    }
                }
            }
            catch (Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
                result.Ex = ex;
            }
            return result;
        }
        public static ML.Result Delete(ML.Users users)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL.MPatricioCentauroEntities context = new DL.MPatricioCentauroEntities())
                {
                    var DeleteResult = context.UserDelete(users.Id);
                    if (DeleteResult >= 1)
                    {
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                        result.ErrorMessage = "El usuario no se elimino correctamente";
                    }
                }
            }
            catch (Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
                result.Ex = ex;
            }
            return result;
        }
    }
}
