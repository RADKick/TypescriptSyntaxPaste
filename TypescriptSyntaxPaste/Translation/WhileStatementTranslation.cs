using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace RoslynTypeScript.Translation
{
    public class WhileStatementTranslation : CSharpSyntaxTranslation
    {
        public new WhileStatementSyntax Syntax
        {
            get { return (WhileStatementSyntax)base.Syntax; }
            set { base.Syntax = value; }
        }

        public WhileStatementTranslation() { }
        public WhileStatementTranslation(WhileStatementSyntax syntax, SyntaxTranslation parent) : base(syntax, parent)
        {
            Condition = syntax.Condition.Get<ExpressionTranslation>(this);
            Statement = syntax.Statement.Get<StatementTranslation>(this);
        }

        public ExpressionTranslation Condition { get; set; }
        public StatementTranslation Statement { get; set; }

        protected override string InnerTranslate()
        {
            return $"while ({Condition.Translate()})"
                + $"\n {Statement.Translate()}";
        }
    }
}
