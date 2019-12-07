using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace RoslynTypeScript.Translation
{
    public class LiteralExpressionTranslation : ExpressionTranslation
    {
        public new LiteralExpressionSyntax Syntax
        {
            get { return (LiteralExpressionSyntax)base.Syntax; }
            set { base.Syntax = value; }
        }
        public LiteralExpressionTranslation(LiteralExpressionSyntax syntax, SyntaxTranslation parent) : base(syntax, parent)
        {
        }

        protected override string InnerTranslate()
        {
            return Syntax.ToString();
        }
    }
}
