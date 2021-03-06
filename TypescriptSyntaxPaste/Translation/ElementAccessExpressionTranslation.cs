﻿using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace RoslynTypeScript.Translation
{
    public class ElementAccessExpressionTranslation : ExpressionTranslation
    {
        public new ElementAccessExpressionSyntax Syntax
        {
            get { return (ElementAccessExpressionSyntax)base.Syntax; }
            set { base.Syntax = value; }
        }
        public ElementAccessExpressionTranslation() { }
        public ElementAccessExpressionTranslation(ElementAccessExpressionSyntax syntax, SyntaxTranslation parent) : base(syntax, parent)
        {
            ArgumentList = syntax.ArgumentList.Get<BracketedArgumentListTranslation>(this);
            Expression = syntax.Expression.Get<ExpressionTranslation>(this);
        }

        public BracketedArgumentListTranslation ArgumentList { get; set; }
        public ExpressionTranslation Expression { get; set; }

        protected override string InnerTranslate()
        {
            return NormalTranslate();
        }

        private string NormalTranslate()
        {
            return $"{Expression.Translate()}{ArgumentList.Translate()}";
        }
    }
}
