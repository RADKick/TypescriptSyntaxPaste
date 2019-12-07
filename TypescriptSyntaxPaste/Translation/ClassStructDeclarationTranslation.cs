using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace RoslynTypeScript.Translation
{
    public abstract class ClassStructDeclarationTranslation : TypeDeclarationTranslation
    {
        public ClassStructDeclarationTranslation(TypeDeclarationSyntax syntax, SyntaxTranslation parent) : base(syntax, parent)
        {
            if (syntax.BaseList != null)
            {
                BaseList = syntax.BaseList.Get<BaseListTranslation>(this);
            }
        }

        public override void ApplyPatch()
        {
            base.ApplyPatch();
            // ConstructorPatch constructorPatch = new ConstructorPatch();
            // constructorPatch.Apply(this);
        }

        public BaseListTranslation BaseList { get; set; }

        public bool HasExplicitBase()
        {
            if (Syntax.BaseList == null)
            {
                return false;
            }

            return BaseList.GetBaseClass() != null;
        }
    }
}
