using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace RoslynTypeScript.Translation
{
    public abstract class NameTranslation : TypeTranslation
    {
        public NameTranslation() { }

        public NameTranslation(NameSyntax syntax, SyntaxTranslation parent) : base(syntax, parent)
        {
        }
    }
}
