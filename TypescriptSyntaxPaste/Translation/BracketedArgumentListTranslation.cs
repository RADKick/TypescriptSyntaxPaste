using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace RoslynTypeScript.Translation
{
    public class BracketedArgumentListTranslation : BaseArgumentListTranslation
    {
        public new BracketedArgumentListSyntax Syntax
        {
            get { return (BracketedArgumentListSyntax)base.Syntax; }
            set { base.Syntax = value; }
        }
        public BracketedArgumentListTranslation(BracketedArgumentListSyntax syntax, SyntaxTranslation parent) : base(syntax, parent)
        {

        }

        protected override string InnerTranslate()
        {
            return $"[{Arguments.Translate()}]";
        }
    }
}
