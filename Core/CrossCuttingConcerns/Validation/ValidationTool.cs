using FluentValidation;

namespace Core.CrossCuttingConcerns.Validation
{
    public static class ValidationTool
    {
        public static void Validate(IValidator validator, object entity)
        {
            var context = new ValidationContext<object>(entity);

            var result = validator
                .ValidateAsync(context)
                .GetAwaiter()
                .GetResult();
            if (!result.IsValid)
            {
                throw new ValidationException(result.Errors);
            }
        }
    }
}
