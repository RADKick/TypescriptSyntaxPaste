using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace RoslynTypeScript.Translation
{
    public class CaseSwitchLabelTranslation : SwitchLabelTranslation
    {
        public new CaseSwitchLabelSyntax Syntax
        {
            get { return (CaseSwitchLabelSyntax)base.Syntax; }
            set { base.Syntax = value; }
        }

        public CaseSwitchLabelTranslation() { }
        public CaseSwitchLabelTranslation(CaseSwitchLabelSyntax syntax, SyntaxTranslation parent) : base(syntax, parent)
        {
            Value = syntax.Value.Get<ExpressionTranslation>(this);
        }


        public ExpressionTranslation Value { get; set; }

        protected override string InnerTranslate()
        {
            return $"case {Value.Translate()}:";
        }
    }
}
