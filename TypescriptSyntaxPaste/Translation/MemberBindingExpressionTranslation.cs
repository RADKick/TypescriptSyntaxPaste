using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace RoslynTypeScript.Translation
{
    public class MemberBindingExpressionTranslation : ExpressionTranslation
    {
        public new MemberBindingExpressionSyntax Syntax
        {
            get { return (MemberBindingExpressionSyntax)base.Syntax; }
            set { base.Syntax = value; }
        }

        public MemberBindingExpressionTranslation() { }
        public MemberBindingExpressionTranslation(MemberBindingExpressionSyntax syntax, SyntaxTranslation parent) : base(syntax, parent)
        {
            Name = syntax.Name.Get<SimpleNameTranslation>(this);

        }

        public SimpleNameTranslation Name { get; set; }

        protected override string InnerTranslate()
        {
            return $".{Name.Translate()}";
        }
    }
}
