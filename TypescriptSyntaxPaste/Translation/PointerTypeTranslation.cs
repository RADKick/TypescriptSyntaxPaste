using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace RoslynTypeScript.Translation
{
    public class PointerTypeTranslation : TypeTranslation
    {
        public new PointerTypeSyntax Syntax
        {
            get { return (PointerTypeSyntax)base.Syntax; }
            set { base.Syntax = value; }
        }

        public PointerTypeTranslation() { }
        public PointerTypeTranslation(PointerTypeSyntax syntax, SyntaxTranslation parent) : base(syntax, parent)
        {

        }

        protected override string InnerTranslate()
        {
            return Syntax.ToString();
        }
    }
}
