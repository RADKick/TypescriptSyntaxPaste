﻿using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace RoslynTypeScript.Translation
{
    public class CheckedExpressionTranslation : ExpressionTranslation
    {
        public new CheckedExpressionSyntax Syntax
        {
            get { return (CheckedExpressionSyntax)base.Syntax; }
            set { base.Syntax = value; }
        }

        public CheckedExpressionTranslation() { }
        public CheckedExpressionTranslation(CheckedExpressionSyntax syntax, SyntaxTranslation parent) : base(syntax, parent)
        {
            Expression = syntax.Expression.Get<ExpressionTranslation>(this);
        }

        public ExpressionTranslation Expression { get; set; }

        protected override string InnerTranslate()
        {
            return $"({Expression.Translate()})";
        }
    }
}
