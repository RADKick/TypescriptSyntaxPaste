using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace RoslynTypeScript.Translation
{
    public class ClassOrStructConstraintTranslation : TypeParameterConstraintTranslation
    {
        public new ClassOrStructConstraintSyntax Syntax
        {
            get { return (ClassOrStructConstraintSyntax)base.Syntax; }
            set { base.Syntax = value; }
        }

        public ClassOrStructConstraintTranslation() { }
        public ClassOrStructConstraintTranslation(ClassOrStructConstraintSyntax syntax, SyntaxTranslation parent) : base(syntax, parent)
        {

        }


        protected override string InnerTranslate()
        {
            return Syntax.ToString();
        }
    }
}
