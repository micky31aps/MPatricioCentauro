//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DL
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class MPatricioCentauroEntities : DbContext
    {
        public MPatricioCentauroEntities()
            : base("name=MPatricioCentauroEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<GPS_DATA> GPS_DATA { get; set; }
        public virtual DbSet<CTL_ROLES> CTL_ROLES { get; set; }
        public virtual DbSet<CTL_USERS> CTL_USERS { get; set; }
    
        public virtual int GpsDelete(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("Id", id) :
                new ObjectParameter("Id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("GpsDelete", idParameter);
        }
    
        public virtual ObjectResult<GpsGetAll_Result> GpsGetAll()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GpsGetAll_Result>("GpsGetAll");
        }
    
        public virtual ObjectResult<GpsGetById_Result> GpsGetById(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("Id", id) :
                new ObjectParameter("Id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GpsGetById_Result>("GpsGetById", idParameter);
        }
    
        public virtual int GpsAdd(Nullable<System.DateTime> dateSystem, Nullable<System.DateTime> dateEvent, Nullable<double> latitude, Nullable<double> longitude, Nullable<int> battery, Nullable<int> source, Nullable<int> tipo)
        {
            var dateSystemParameter = dateSystem.HasValue ?
                new ObjectParameter("DateSystem", dateSystem) :
                new ObjectParameter("DateSystem", typeof(System.DateTime));
    
            var dateEventParameter = dateEvent.HasValue ?
                new ObjectParameter("DateEvent", dateEvent) :
                new ObjectParameter("DateEvent", typeof(System.DateTime));
    
            var latitudeParameter = latitude.HasValue ?
                new ObjectParameter("Latitude", latitude) :
                new ObjectParameter("Latitude", typeof(double));
    
            var longitudeParameter = longitude.HasValue ?
                new ObjectParameter("Longitude", longitude) :
                new ObjectParameter("Longitude", typeof(double));
    
            var batteryParameter = battery.HasValue ?
                new ObjectParameter("Battery", battery) :
                new ObjectParameter("Battery", typeof(int));
    
            var sourceParameter = source.HasValue ?
                new ObjectParameter("Source", source) :
                new ObjectParameter("Source", typeof(int));
    
            var tipoParameter = tipo.HasValue ?
                new ObjectParameter("Tipo", tipo) :
                new ObjectParameter("Tipo", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("GpsAdd", dateSystemParameter, dateEventParameter, latitudeParameter, longitudeParameter, batteryParameter, sourceParameter, tipoParameter);
        }
    
        public virtual int GpsUpdate(Nullable<int> id, Nullable<System.DateTime> dateSystem, Nullable<System.DateTime> dateEvent, Nullable<double> latitude, Nullable<double> longitude, Nullable<int> battery, Nullable<int> source, Nullable<int> tipo)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("Id", id) :
                new ObjectParameter("Id", typeof(int));
    
            var dateSystemParameter = dateSystem.HasValue ?
                new ObjectParameter("DateSystem", dateSystem) :
                new ObjectParameter("DateSystem", typeof(System.DateTime));
    
            var dateEventParameter = dateEvent.HasValue ?
                new ObjectParameter("DateEvent", dateEvent) :
                new ObjectParameter("DateEvent", typeof(System.DateTime));
    
            var latitudeParameter = latitude.HasValue ?
                new ObjectParameter("Latitude", latitude) :
                new ObjectParameter("Latitude", typeof(double));
    
            var longitudeParameter = longitude.HasValue ?
                new ObjectParameter("Longitude", longitude) :
                new ObjectParameter("Longitude", typeof(double));
    
            var batteryParameter = battery.HasValue ?
                new ObjectParameter("Battery", battery) :
                new ObjectParameter("Battery", typeof(int));
    
            var sourceParameter = source.HasValue ?
                new ObjectParameter("Source", source) :
                new ObjectParameter("Source", typeof(int));
    
            var tipoParameter = tipo.HasValue ?
                new ObjectParameter("Tipo", tipo) :
                new ObjectParameter("Tipo", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("GpsUpdate", idParameter, dateSystemParameter, dateEventParameter, latitudeParameter, longitudeParameter, batteryParameter, sourceParameter, tipoParameter);
        }
    
        public virtual int UserDelete(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("Id", id) :
                new ObjectParameter("Id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UserDelete", idParameter);
        }
    
        public virtual int UserAdd(Nullable<int> idRole, string name, string lastName, string surName, string email, string userName, string contrasena, Nullable<int> parent, Nullable<int> estatus)
        {
            var idRoleParameter = idRole.HasValue ?
                new ObjectParameter("IdRole", idRole) :
                new ObjectParameter("IdRole", typeof(int));
    
            var nameParameter = name != null ?
                new ObjectParameter("Name", name) :
                new ObjectParameter("Name", typeof(string));
    
            var lastNameParameter = lastName != null ?
                new ObjectParameter("LastName", lastName) :
                new ObjectParameter("LastName", typeof(string));
    
            var surNameParameter = surName != null ?
                new ObjectParameter("SurName", surName) :
                new ObjectParameter("SurName", typeof(string));
    
            var emailParameter = email != null ?
                new ObjectParameter("Email", email) :
                new ObjectParameter("Email", typeof(string));
    
            var userNameParameter = userName != null ?
                new ObjectParameter("UserName", userName) :
                new ObjectParameter("UserName", typeof(string));
    
            var contrasenaParameter = contrasena != null ?
                new ObjectParameter("contrasena", contrasena) :
                new ObjectParameter("contrasena", typeof(string));
    
            var parentParameter = parent.HasValue ?
                new ObjectParameter("Parent", parent) :
                new ObjectParameter("Parent", typeof(int));
    
            var estatusParameter = estatus.HasValue ?
                new ObjectParameter("Estatus", estatus) :
                new ObjectParameter("Estatus", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UserAdd", idRoleParameter, nameParameter, lastNameParameter, surNameParameter, emailParameter, userNameParameter, contrasenaParameter, parentParameter, estatusParameter);
        }
    
        public virtual int UserUpdate(Nullable<int> id, Nullable<int> idRole, string name, string lastName, string surName, string email, string userName, string contrasena, Nullable<int> parent, Nullable<int> estatus)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("Id", id) :
                new ObjectParameter("Id", typeof(int));
    
            var idRoleParameter = idRole.HasValue ?
                new ObjectParameter("IdRole", idRole) :
                new ObjectParameter("IdRole", typeof(int));
    
            var nameParameter = name != null ?
                new ObjectParameter("Name", name) :
                new ObjectParameter("Name", typeof(string));
    
            var lastNameParameter = lastName != null ?
                new ObjectParameter("LastName", lastName) :
                new ObjectParameter("LastName", typeof(string));
    
            var surNameParameter = surName != null ?
                new ObjectParameter("SurName", surName) :
                new ObjectParameter("SurName", typeof(string));
    
            var emailParameter = email != null ?
                new ObjectParameter("Email", email) :
                new ObjectParameter("Email", typeof(string));
    
            var userNameParameter = userName != null ?
                new ObjectParameter("UserName", userName) :
                new ObjectParameter("UserName", typeof(string));
    
            var contrasenaParameter = contrasena != null ?
                new ObjectParameter("contrasena", contrasena) :
                new ObjectParameter("contrasena", typeof(string));
    
            var parentParameter = parent.HasValue ?
                new ObjectParameter("Parent", parent) :
                new ObjectParameter("Parent", typeof(int));
    
            var estatusParameter = estatus.HasValue ?
                new ObjectParameter("Estatus", estatus) :
                new ObjectParameter("Estatus", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UserUpdate", idParameter, idRoleParameter, nameParameter, lastNameParameter, surNameParameter, emailParameter, userNameParameter, contrasenaParameter, parentParameter, estatusParameter);
        }
    
        public virtual ObjectResult<UserGetAll_Result4> UserGetAll(string name, string lastName, string surName, string email)
        {
            var nameParameter = name != null ?
                new ObjectParameter("Name", name) :
                new ObjectParameter("Name", typeof(string));
    
            var lastNameParameter = lastName != null ?
                new ObjectParameter("LastName", lastName) :
                new ObjectParameter("LastName", typeof(string));
    
            var surNameParameter = surName != null ?
                new ObjectParameter("SurName", surName) :
                new ObjectParameter("SurName", typeof(string));
    
            var emailParameter = email != null ?
                new ObjectParameter("Email", email) :
                new ObjectParameter("Email", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<UserGetAll_Result4>("UserGetAll", nameParameter, lastNameParameter, surNameParameter, emailParameter);
        }
    
        public virtual ObjectResult<UserGetById_Result3> UserGetById(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("Id", id) :
                new ObjectParameter("Id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<UserGetById_Result3>("UserGetById", idParameter);
        }
    }
}
