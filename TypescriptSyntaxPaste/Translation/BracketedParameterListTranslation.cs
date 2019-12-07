using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace RoslynTypeScript.Translation
{
    public class BracketedParameterListTranslation : BaseParameterListTranslation
    {
        public new BracketedParameterListSyntax Syntax
        {
            get { return (BracketedParameterListSyntax)base.Syntax; }
            set { base.Syntax = value; }
        }

        public BracketedParameterListTranslation() { }
        public BracketedParameterListTranslation(BracketedParameterListSyntax syntax, SyntaxTranslation parent) : base(syntax, parent)
        {

        }


        protected override string InnerTranslate()
        {
            return Syntax.ToString();
        }
    }
}
