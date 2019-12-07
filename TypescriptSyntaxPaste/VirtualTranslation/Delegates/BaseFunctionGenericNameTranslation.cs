using Microsoft.CodeAnalysis.CSharp.Syntax;
using RoslynTypeScript.Translation;

namespace RoslynTypeScript.VirtualTranslation
{
    public class BaseFunctionGenericNameTranslation : GenericNameTranslation
    {
        protected GenericNameTranslation genericNameTranslation;

        public BaseFunctionGenericNameTranslation(GenericNameTranslation genericNameTranslation)
        {
            this.genericNameTranslation = genericNameTranslation;
            this.Parent = genericNameTranslation.Parent;
        }

        public SeparatedSyntaxListTranslation<TypeSyntax, TypeTranslation> Arguments { get; set; }
        public TypeTranslation ReturnType { get; set; }

        protected string GetFakeParamName(string previous)
        {
            return (previous ?? "") + "_";
        }
    }
}
