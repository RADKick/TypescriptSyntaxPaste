﻿using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Linq;

namespace RoslynTypeScript.Translation
{
    public class AccessorListTranslation : CSharpSyntaxTranslation
    {

        public SyntaxListTranslation<AccessorDeclarationSyntax, AccessorDeclarationTranslation> Accessors { get; set; }

        public AccessorListTranslation(AccessorListSyntax syntax, SyntaxTranslation parent) : base(syntax, parent)
        {
            Accessors = syntax.Accessors.Get<AccessorDeclarationSyntax, AccessorDeclarationTranslation>(this);
        }

        public void SetModifier(SyntaxTokenListTranslation modifiers)
        {
            foreach (var item in Accessors.GetEnumerable())
            {
                item.ParentModifiers = modifiers.TokenListSyntax.Get(item);
            }
        }

        public new AccessorListSyntax Syntax
        {
            get { return (AccessorListSyntax)base.Syntax; }
            set { base.Syntax = value; }
        }

        protected override string InnerTranslate()
        {
            return Accessors.Translate();
        }

        public bool IsShorten()
        {
            return Accessors.GetEnumerable().First().IsShorten();
        }
    }
}
