using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace RoslynTypeScript.Translation
{
    public class QueryExpressionTranslation : ExpressionTranslation
    {
        public new QueryExpressionSyntax Syntax
        {
            get { return (QueryExpressionSyntax)base.Syntax; }
            set { base.Syntax = value; }
        }

        public QueryExpressionTranslation() { }
        public QueryExpressionTranslation(QueryExpressionSyntax syntax, SyntaxTranslation parent) : base(syntax, parent)
        {

        }

        protected override string InnerTranslate()
        {
            return Syntax.ToString();
        }
    }
}
