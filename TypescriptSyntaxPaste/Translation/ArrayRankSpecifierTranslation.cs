﻿using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace RoslynTypeScript.Translation
{
    public class ArrayRankSpecifierTranslation : CSharpSyntaxTranslation
    {
        public new ArrayRankSpecifierSyntax Syntax
        {
            get { return (ArrayRankSpecifierSyntax)base.Syntax; }
            set { base.Syntax = value; }
        }
        public ArrayRankSpecifierTranslation() { }
        public ArrayRankSpecifierTranslation(ArrayRankSpecifierSyntax syntax, SyntaxTranslation parent) : base(syntax, parent)
        {

            Sizes = syntax.Sizes.Get<ExpressionSyntax, ExpressionTranslation>(this);
        }

        public SeparatedSyntaxListTranslation<ExpressionSyntax, ExpressionTranslation> Sizes { get; set; }

        protected override string InnerTranslate()
        {
            return $"[{Sizes.Translate()}]";
        }
    }
}
