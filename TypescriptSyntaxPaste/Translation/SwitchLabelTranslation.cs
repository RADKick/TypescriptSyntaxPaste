using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace RoslynTypeScript.Translation
{
    public abstract class SwitchLabelTranslation : CSharpSyntaxTranslation
    {
        public new SwitchLabelSyntax Syntax
        {
            get { return (SwitchLabelSyntax)base.Syntax; }
            set { base.Syntax = value; }
        }

        public SwitchLabelTranslation() { }
        public SwitchLabelTranslation(SwitchLabelSyntax syntax, SyntaxTranslation parent) : base(syntax, parent)
        {

        }

        protected override string InnerTranslate()
        {
            return Syntax.ToString();
        }
    }
}
