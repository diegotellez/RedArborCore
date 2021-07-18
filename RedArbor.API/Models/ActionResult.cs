using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RedArbor.API.Models
{
    public class ActionResult
    {
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

        public bool IsSuccessful { get; set; }
        public bool IsError { get; set; }
        public string ErrorMessage { get; set; }
        public List<string> Messages { get; set; }

        public dynamic Result { get; set; }
    }
}
