using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Gps
    {
        public static ML.Result GetAll()
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL.MPatricioCentauroEntities context = new DL.MPatricioCentauroEntities())
                {
                    var GetAllResult = context.GpsGetAll().ToList();
                    result.Objects = new List<object>();
                    if (GetAllResult != null)
                    {
                        foreach (var obj in GetAllResult)
                        {
                            ML.Gps gps = new ML.Gps();
                            gps.Id = obj.Id;
                            gps.DateSystem = obj.DateSystem;
                            gps.DateEvent = obj.DateEvent.Value;
                            gps.Latitude = obj.Latitude.Value;
                            gps.Longitude = obj.Longitude.Value;
                            gps.Battery = obj.Battery.Value;
                            gps.Source = obj.Source.Value;
                            gps.Tipo = obj.Tipo.Value;
                            result.Objects.Add(gps);
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
            }
            return result;
        }
        public static ML.Result GetById(int IdGps)
        {
            ML.Result result = new ML.Result();
            try
            {
                using(DL.MPatricioCentauroEntities context = new DL.MPatricioCentauroEntities())
                {
                    var GetByIdResult = context.GpsGetById(IdGps).FirstOrDefault();
                    result.Object = new List<object>();
                    if (GetByIdResult != null)
                    {
                        ML.Gps gps = new ML.Gps();
                        gps.Id = GetByIdResult.Id;
                        gps.DateSystem = GetByIdResult.DateSystem;
                        gps.DateEvent = GetByIdResult.DateEvent.Value;
                        gps.Latitude = GetByIdResult.Latitude.Value;
                        gps.Longitude = GetByIdResult.Longitude.Value;
                        gps.Battery = GetByIdResult.Battery.Value;
                        gps.Source = GetByIdResult.Source.Value;
                        gps.Tipo = GetByIdResult.Tipo.Value;
                        result.Object = gps;
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                        result.ErrorMessage = "No se encontro el registro";
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
        public static ML.Result Add(ML.Gps gps)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL.MPatricioCentauroEntities context = new DL.MPatricioCentauroEntities())
                {
                    var AddResult = context.GpsAdd(gps.DateSystem, gps.DateEvent, gps.Latitude, gps.Longitude, gps.Battery, gps.Source, gps.Tipo);
                    if (AddResult >= 1)
                    {
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                        result.ErrorMessage = "No se inserto el registro correctamente";
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
        public static ML.Result Update(ML.Gps gps)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL.MPatricioCentauroEntities context = new DL.MPatricioCentauroEntities())
                {
                    var UpdateResult = context.GpsUpdate(gps.Id, gps.DateSystem, gps.DateEvent, gps.Latitude, gps.Longitude, gps.Battery, gps.Source, gps.Tipo);
                    if (UpdateResult >= 1)
                    {
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                        result.ErrorMessage = "No se modifico el registro correctamente";
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
        public static ML.Result Delete(ML.Gps gps)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL.MPatricioCentauroEntities context = new DL.MPatricioCentauroEntities())
                {
                    var DeleteResult = context.GpsDelete(gps.Id);
                    if (DeleteResult >= 1)
                    {
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                        result.ErrorMessage = "El registro no se elimino correctamente";
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
