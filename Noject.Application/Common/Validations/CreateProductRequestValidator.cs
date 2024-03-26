using Noject.Application.Common.RequestModel;
using FluentValidation;
using FluentValidation.AspNetCore;

namespace Noject.Application.Common.Validations
{
    public class CreateProductRequestValidator : AbstractValidator<ProductRequestModel>
    {
        public CreateProductRequestValidator()
        {
            RuleFor(x => x.Description).MinimumLength(20);
            RuleFor(x => x.ProductId).NotNull();
        }
    }
}