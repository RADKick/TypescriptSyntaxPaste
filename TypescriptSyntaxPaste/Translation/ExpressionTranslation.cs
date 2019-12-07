using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace RoslynTypeScript.Translation
{
    public abstract class ExpressionTranslation : CSharpSyntaxTranslation
    {
        public ExpressionTranslation() { }
        public ExpressionTranslation(ExpressionSyntax syntax, SyntaxTranslation parent) : base(syntax, parent)
        {
        }
    }
}
