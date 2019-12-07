using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace RoslynTypeScript.Translation
{
    public class EnumMemberDeclarationTranslation : MemberDeclarationTranslation
    {
        public new EnumMemberDeclarationSyntax Syntax
        {
            get { return (EnumMemberDeclarationSyntax)base.Syntax; }
            set { base.Syntax = value; }
        }
        public EnumMemberDeclarationTranslation() { }
        public EnumMemberDeclarationTranslation(EnumMemberDeclarationSyntax syntax, SyntaxTranslation parent) : base(syntax, parent)
        {
        }


        protected override string InnerTranslate()
        {
            return Syntax.ToString();
        }
    }
}
