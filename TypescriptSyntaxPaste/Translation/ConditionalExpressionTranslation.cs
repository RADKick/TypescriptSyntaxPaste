﻿using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace RoslynTypeScript.Translation
{
    public class ConditionalExpressionTranslation : ExpressionTranslation
    {
        public new ConditionalExpressionSyntax Syntax
        {
            get { return (ConditionalExpressionSyntax)base.Syntax; }
            set { base.Syntax = value; }
        }

        public ConditionalExpressionTranslation() { }
        public ConditionalExpressionTranslation(ConditionalExpressionSyntax syntax, SyntaxTranslation parent) : base(syntax, parent)
        {
            Condition = syntax.Condition.Get<ExpressionTranslation>(this);
            WhenFalse = syntax.WhenFalse.Get<ExpressionTranslation>(this);
            WhenTrue = syntax.WhenTrue.Get<ExpressionTranslation>(this);
        }

        public ExpressionTranslation Condition { get; set; }
        public ExpressionTranslation WhenFalse { get; set; }
        public ExpressionTranslation WhenTrue { get; set; }

        protected override string InnerTranslate()
        {
            return $"{Condition.Translate()} ? {WhenTrue.Translate()} : {WhenFalse.Translate()}";
        }
    }
}
