using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace RoslynTypeScript.Translation
{
    public class GotoStatementTranslation : StatementTranslation
    {
        public new GotoStatementSyntax Syntax
        {
            get { return (GotoStatementSyntax)base.Syntax; }
            set { base.Syntax = value; }
        }

        public GotoStatementTranslation() { }
        public GotoStatementTranslation(GotoStatementSyntax syntax, SyntaxTranslation parent) : base(syntax, parent)
        {

        }

        public ExpressionTranslation Expression { get; set; }

        protected override string InnerTranslate()
        {

            return Syntax.ToString();
        }
    }
}
