﻿using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;

namespace DevFramework.Core.CrossCuttingConcers.validation.FluentValidation
{
    public class ValidatorTool
    {
        public static void FluentValidate(IValidator validator,object entity)
        {
            var result = validator.Validate((IValidationContext)entity);//changed

            if (result.Errors.Count>0)
            {
                throw new ValidationException(result.Errors);
            }
        }
    }
}
