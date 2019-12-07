using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace RoslynTypeScript.Translation
{
    public class BreakStatementTranslation : StatementTranslation
    {
        public new BreakStatementSyntax Syntax
        {
            get { return (BreakStatementSyntax)base.Syntax; }
            set { base.Syntax = value; }
        }

        public BreakStatementTranslation() { }
        public BreakStatementTranslation(BreakStatementSyntax syntax, SyntaxTranslation parent) : base(syntax, parent)
        {

        }

        protected override string InnerTranslate()
        {
            return Syntax.ToString();
        }
    }
}
