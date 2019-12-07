using Microsoft.CodeAnalysis;

namespace RoslynTypeScript.Translation
{
    public class GenericTranslation : CSharpSyntaxTranslation
    {

        public GenericTranslation(SyntaxNode syntax, SyntaxTranslation parent) : base(syntax, parent)
        {
        }

        protected override string InnerTranslate()
        {
            return Syntax.ToString();
        }
    }
}
