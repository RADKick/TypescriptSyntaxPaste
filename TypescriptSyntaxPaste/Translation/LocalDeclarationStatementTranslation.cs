using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace RoslynTypeScript.Translation
{
    public class LocalDeclarationStatementTranslation : StatementTranslation
    {
        public new LocalDeclarationStatementSyntax Syntax
        {
            get { return (LocalDeclarationStatementSyntax)base.Syntax; }
            set { base.Syntax = value; }
        }

        public VariableDeclarationTranslation Declaration { get; set; }

        public LocalDeclarationStatementTranslation(LocalDeclarationStatementSyntax syntax, SyntaxTranslation parent) : base(syntax, parent)
        {
            Declaration = syntax.Declaration.Get<VariableDeclarationTranslation>(this);
        }

        protected override string InnerTranslate()
        {
            return string.Format("{0};", Declaration.Translate());
        }
    }
}
