﻿using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class CityValidator:AbstractValidator<City>
    {
        public CityValidator()
        {
            RuleFor(c=>c.PrivateCode).NotEmpty().WithMessage("Private Code cannot be empty");
            RuleFor(c => c.CityName).NotEmpty().WithMessage("City name cannot be empty");
        }
    }
}
