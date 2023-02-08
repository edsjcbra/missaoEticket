﻿namespace Eticket.Models.Error
{
    public class CustomValidatorFailure
    {
        public CustomValidatorFailure(string propertyName, string errorMessage)
        {
            PropertyName= propertyName;
            ErrorMessage= errorMessage;
        }

        public string PropertyName { get; set; }
        public string ErrorMessage { get; set; }

    }
}
