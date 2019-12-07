using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace RoslynTypeScript.Translation
{
    public abstract class StatementTranslation : CSharpSyntaxTranslation
    {
        public StatementTranslation()
        {
        }

        public StatementTranslation(StatementSyntax syntax, SyntaxTranslation parent) : base(syntax, parent)
        {
        }
    }
}
