using System;

namespace Greetings.Models
{
    public class ErrorModel
    {
        public ErrorModel()
        {
        }

        public ErrorModel(string errorMessage)
        {
            this.ErrorMessage = errorMessage;
            this.DateTime = DateTime.Now;
        }

        public DateTime DateTime { get; set; }
        public string ErrorMessage { get; set; }
    }
}