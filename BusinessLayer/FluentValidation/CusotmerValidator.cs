using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.FluentValidation
{
    public class CusotmerValidator : AbstractValidator<Customer>
    {
        public CusotmerValidator()
        {
            RuleFor(x => x.City).NotEmpty().WithMessage("Şehir bilgisi boş geçilemez");
            RuleFor(x => x.Name).NotEmpty().WithMessage("Ad boş geçilemez");
        }
    }
}
