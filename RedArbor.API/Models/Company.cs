using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RedArbor.API.Models
{
    /// <summary>
    /// Compañías del sistema
    /// </summary>
    public class Company
    {
        /// <summary>
        /// Llave primaria de la Compañía
        /// </summary>
        public int CompanyId { get; set; }
        /// <summary>
        /// fecha de creación
        /// </summary>
        public DateTime CreatedOn { get; set; }
        /// <summary>
        /// Fecha de eliminación
        /// </summary>
        public DateTime? DeletedOn { get; set; }
        /// <summary>
        /// Correo
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// Fax
        /// </summary>
        public string Fax { get; set; }
        /// <summary>
        /// Nombre de la compañía
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Fecha del último ingreso exitoso
        /// </summary>
        public DateTime? Lastlogin { get; set; }
        /// <summary>
        /// Clave
        /// </summary>
        public string password { get; set; }
        /// <summary>
        /// Id del portal asociado
        /// </summary>
        public int PortalId { get; set; }
        /// <summary>
        /// Id del rol
        /// </summary>
        public int RoleId { get; set; }
        /// <summary>
        /// Estado actual de la compañía
        /// </summary>
        public int Status { get; set; }
        /// <summary>
        /// Teléfono
        /// </summary>
        public string Telephone { get; set; }
        /// <summary>
        /// Fecha de la última actualización
        /// </summary>
        public DateTime? UpdatedOn { get; set; }
        /// <summary>
        /// Nombre de usuario
        /// </summary>
        public string Username { get; set; }
    }
}
