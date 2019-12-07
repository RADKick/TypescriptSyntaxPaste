using Microsoft.CodeAnalysis.CSharp.Syntax;
using RoslynTypeScript.Translation;

namespace RoslynTypeScript.Contract
{
    public interface ITypeParameterConstraint
    {
        TypeParameterListTranslation TypeParameterList { get; set; }

        SyntaxListTranslation<TypeParameterConstraintClauseSyntax, TypeParameterConstraintClauseTranslation> ConstraintClauses { get; set; }
    }
}
