using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace RoslynTypeScript.Translation
{
    public class EmptyStatementTranslation : StatementTranslation
    {
        public new EmptyStatementSyntax Syntax
        {
            get { return (EmptyStatementSyntax)base.Syntax; }
            set { base.Syntax = value; }
        }

        public EmptyStatementTranslation() { }
        public EmptyStatementTranslation(EmptyStatementSyntax syntax, SyntaxTranslation parent) : base(syntax, parent)
        {

        }

        protected override string InnerTranslate()
        {
            return Syntax.ToString();
        }
    }
}
