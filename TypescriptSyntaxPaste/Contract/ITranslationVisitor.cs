using RoslynTypeScript.Translation;

namespace RoslynTypeScript.Contract
{
    public interface ITranslationVisitor
    {
        void Visit(SyntaxTranslation translation);
    }
}
