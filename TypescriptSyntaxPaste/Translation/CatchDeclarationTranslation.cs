using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace RoslynTypeScript.Translation
{
    public class CatchDeclarationTranslation : CSharpSyntaxTranslation
    {
        public new CatchDeclarationSyntax Syntax
        {
            get { return (CatchDeclarationSyntax)base.Syntax; }
            set { base.Syntax = value; }
        }

        public CatchDeclarationTranslation() { }
        public CatchDeclarationTranslation(CatchDeclarationSyntax syntax, SyntaxTranslation parent) : base(syntax, parent)
        {

        }


        protected override string InnerTranslate()
        {
            return Syntax.ToString();
        }
    }
}
