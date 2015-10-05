using System.Text.RegularExpressions;
using SharpCompiler.Exceptions;

namespace Strategy.Validators
{
    public class CodeLengthValidator : ICodeValidationStrategy
    {
        public void Validate(string code)
        {
            var regex = @"[\s\S]{20,}";
            if (!Regex.IsMatch(code, regex))
            {
                throw new CompilationException("Code is less than 20 chars!");
            }
        }
    }
}
