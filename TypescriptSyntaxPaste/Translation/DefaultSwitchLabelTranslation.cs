using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace RoslynTypeScript.Translation
{
    public class DefaultSwitchLabelTranslation : SwitchLabelTranslation
    {
        public new DefaultSwitchLabelSyntax Syntax
        {
            get { return (DefaultSwitchLabelSyntax)base.Syntax; }
            set { base.Syntax = value; }
        }

        public DefaultSwitchLabelTranslation() { }
        public DefaultSwitchLabelTranslation(DefaultSwitchLabelSyntax syntax, SyntaxTranslation parent) : base(syntax, parent)
        {

        }

        protected override string InnerTranslate()
        {
            return Syntax.ToString();
        }
    }
}
