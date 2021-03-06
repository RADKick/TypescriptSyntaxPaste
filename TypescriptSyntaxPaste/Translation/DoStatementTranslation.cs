﻿using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace RoslynTypeScript.Translation
{
    public class DoStatementTranslation : CSharpSyntaxTranslation
    {
        public new DoStatementSyntax Syntax
        {
            get { return (DoStatementSyntax)base.Syntax; }
            set { base.Syntax = value; }
        }

        public DoStatementTranslation() { }
        public DoStatementTranslation(DoStatementSyntax syntax, SyntaxTranslation parent) : base(syntax, parent)
        {
            Condition = syntax.Condition.Get<ExpressionTranslation>(this);
            Statement = syntax.Statement.Get<StatementTranslation>(this);
        }

        public ExpressionTranslation Condition { get; set; }
        public StatementTranslation Statement { get; set; }

        protected override string InnerTranslate()
        {
            return $@"do 
                 {Statement.Translate()}
                 while({Condition.Translate()});";
        }
    }
}
