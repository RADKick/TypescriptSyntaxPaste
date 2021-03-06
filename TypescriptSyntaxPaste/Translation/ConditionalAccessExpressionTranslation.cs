﻿using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace RoslynTypeScript.Translation
{
    public class ConditionalAccessExpressionTranslation : ExpressionTranslation
    {
        public new ConditionalAccessExpressionSyntax Syntax
        {
            get { return (ConditionalAccessExpressionSyntax)base.Syntax; }
            set { base.Syntax = value; }
        }

        public ConditionalAccessExpressionTranslation() { }
        public ConditionalAccessExpressionTranslation(ConditionalAccessExpressionSyntax syntax, SyntaxTranslation parent) : base(syntax, parent)
        {
            Expression = syntax.Expression.Get<ExpressionTranslation>(this);
            WhenNotNull = syntax.WhenNotNull.Get<ExpressionTranslation>(this);

        }

        public ExpressionTranslation Expression { get; set; }
        public ExpressionTranslation WhenNotNull { get; set; }

        protected override string InnerTranslate()
        {
            return $"{Expression.Translate()}?{WhenNotNull.Translate()}";
        }
    }
}
