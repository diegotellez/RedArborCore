using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RedArbor.API.Models
{
    public class ActionResult
    {
        /// <summary>
        /// resultado de la transacción
        /// </summary>
        /// <param name="value"></param>
        public ActionResult(dynamic value)
        {
            if (value == null || (typeof(bool) == value.GetType() && value == false))
                Messages = new List<string> { "No hubo resultados para la solicitud" };
            else
                IsSuccessful = true;
            Result = value;
        }

        public ActionResult(string errorMessage)
        {
            ErrorMessage = errorMessage;
        }

        public ActionResult(List<string> messages)
        {
            Messages = messages;
        }

        /// <summary>
        /// Determina si el resultado de la petición se ejecutó correctamente
        /// </summary>
        public bool IsSuccessful { get; set; }
        /// <summary>
        /// Determina si hubo errores o errores inesperados en la ejecución del servicio
        /// </summary>
        public bool IsError { get; set; }
        /// <summary>
        /// Especifica el mensaje de error del servicio.
        /// </summary>
        public string ErrorMessage { get; set; }

        /// <summary>
        /// Determina los mensajes de resultado del servicio, donde se especifican validaciones, reglas, formatos, estados, etc.
        /// </summary>
        public List<string> Messages { get; set; }
        
        /// <summary>
        /// Resultado de la transacción (Lista de entidades, entidad única, bool, etc)
        /// </summary>
        public dynamic Result { get; set; }
    }
}
