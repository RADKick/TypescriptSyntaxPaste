﻿using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace RoslynTypeScript.Translation
{
    public class OmittedArraySizeExpressionTranslation : CSharpSyntaxTranslation
    {
        public new OmittedArraySizeExpressionSyntax Syntax
        {
            get { return (OmittedArraySizeExpressionSyntax)base.Syntax; }
            set { base.Syntax = value; }
        }
        public OmittedArraySizeExpressionTranslation() { }
        public OmittedArraySizeExpressionTranslation(OmittedArraySizeExpressionSyntax syntax, SyntaxTranslation parent) : base(syntax, parent)
        {
        }

        protected override string InnerTranslate()
        {
            return Syntax.ToString();
        }
    }
}
