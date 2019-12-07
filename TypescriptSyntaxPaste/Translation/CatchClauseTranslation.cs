using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace RoslynTypeScript.Translation
{
    public class CatchClauseTranslation : CSharpSyntaxTranslation
    {
        public new CatchClauseSyntax Syntax
        {
            get { return (CatchClauseSyntax)base.Syntax; }
            set { base.Syntax = value; }
        }

        public CatchClauseTranslation() { }
        public CatchClauseTranslation(CatchClauseSyntax syntax, SyntaxTranslation parent) : base(syntax, parent)
        {
            Block = syntax.Block.Get<BlockTranslation>(this);
            Declaration = syntax.Declaration.Get<CatchDeclarationTranslation>(this);
        }

        public BlockTranslation Block { get; set; }
        public CatchDeclarationTranslation Declaration { get; set; }

        protected override string InnerTranslate()
        {
            string errName = Declaration?.Syntax.Identifier.ToString();
            if (string.IsNullOrEmpty(errName))
            {
                errName = "err";
            }

            return $@"catch({errName})
                {Block.Translate()}";
        }
    }
}
