using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace RoslynTypeScript.Translation
{
    public class InterpolatedStringExpressionTranslation : ExpressionTranslation
    {
        public new InterpolatedStringExpressionSyntax Syntax
        {
            get { return (InterpolatedStringExpressionSyntax)base.Syntax; }
            set { base.Syntax = value; }
        }

        public InterpolatedStringExpressionTranslation() { }
        public InterpolatedStringExpressionTranslation(InterpolatedStringExpressionSyntax syntax, SyntaxTranslation parent) : base(syntax, parent)
        {

        }

        protected override string InnerTranslate()
        {
            return Syntax.ToString();
        }
    }
}
