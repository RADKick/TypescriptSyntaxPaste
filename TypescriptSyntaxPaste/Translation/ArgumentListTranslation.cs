﻿using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace RoslynTypeScript.Translation
{
    public class ArgumentListTranslation : CSharpSyntaxTranslation
    {
        public new ArgumentListSyntax Syntax
        {
            get { return (ArgumentListSyntax)base.Syntax; }
            set { base.Syntax = value; }
        }

        public SeparatedSyntaxListTranslation<ArgumentSyntax, ArgumentTranslation> Arguments { get; set; }
        public ArgumentListTranslation() { }
        public ArgumentListTranslation(ArgumentListSyntax syntax, SyntaxTranslation parent) : base(syntax, parent)
        {
            Arguments = syntax.Arguments.Get<ArgumentSyntax, ArgumentTranslation>(this);
        }


        protected override string InnerTranslate()
        {
            return string.Format("({0})", Arguments.Translate());
        }
    }
}
