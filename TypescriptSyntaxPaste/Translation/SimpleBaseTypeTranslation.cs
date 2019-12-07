using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace RoslynTypeScript.Translation
{
    public class SimpleBaseTypeTranslation : BaseTypeTranslation
    {
        public new SimpleBaseTypeSyntax Syntax
        {
            get { return (SimpleBaseTypeSyntax)base.Syntax; }
            set { base.Syntax = value; }
        }
        public SimpleBaseTypeTranslation() { }
        public SimpleBaseTypeTranslation(SimpleBaseTypeSyntax syntax, SyntaxTranslation parent) : base(syntax, parent)
        {
            this.Syntax = syntax;
        }
    }
}
