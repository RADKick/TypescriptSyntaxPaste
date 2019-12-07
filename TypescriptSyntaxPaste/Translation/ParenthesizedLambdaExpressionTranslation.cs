﻿using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace RoslynTypeScript.Translation
{
    public class ParenthesizedLambdaExpressionTranslation : ExpressionTranslation
    {
        public new ParenthesizedLambdaExpressionSyntax Syntax
        {
            get { return (ParenthesizedLambdaExpressionSyntax)base.Syntax; }
            set { base.Syntax = value; }
        }

        public ParenthesizedLambdaExpressionTranslation() { }
        public ParenthesizedLambdaExpressionTranslation(ParenthesizedLambdaExpressionSyntax syntax, SyntaxTranslation parent) : base(syntax, parent)
        {
            Body = syntax.Body.Get<CSharpSyntaxTranslation>(this);
            ParameterList = syntax.ParameterList.Get<ParameterListTranslation>(this);
        }

        public CSharpSyntaxTranslation Body { get; set; }
        public ParameterListTranslation ParameterList { get; set; }

        protected override string InnerTranslate()
        {
            return $"{ParameterList.Translate()} => {Body.Translate()}";
        }
    }
}
