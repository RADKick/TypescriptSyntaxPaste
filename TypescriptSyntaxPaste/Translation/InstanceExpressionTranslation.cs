using Microsoft.CodeAnalysis.CSharp.Syntax;
using RoslynTypeScript.Translation;

namespace RoslynTypeScript
{
    public abstract class InstanceExpressionTranslation : ExpressionTranslation
    {
        public InstanceExpressionTranslation(InstanceExpressionSyntax syntax, SyntaxTranslation parent) : base(syntax, parent)
        {
        }
    }
}
