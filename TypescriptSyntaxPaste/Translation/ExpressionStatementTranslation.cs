using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace RoslynTypeScript.Translation
{
    public class ExpressionStatementTranslation : StatementTranslation
    {
        public new ExpressionStatementSyntax Syntax
        {
            get { return (ExpressionStatementSyntax)base.Syntax; }
            set { base.Syntax = value; }
        }
        public ExpressionTranslation Expression { get; set; }
        public ExpressionStatementTranslation(ExpressionStatementSyntax syntax, SyntaxTranslation parent) : base(syntax, parent)
        {
            Expression = syntax.Expression.Get<ExpressionTranslation>(this);
        }

        protected override string InnerTranslate()
        {
            return string.Format("{0};", Expression.Translate());
        }
    }
}
