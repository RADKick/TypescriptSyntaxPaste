﻿using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Linq;
using TypescriptSyntaxPaste.VSIX;

namespace TypescriptSyntaxPaste
{

    public class TypeNameReplacement
    {
        public static CSharpSyntaxNode Replace(TypeNameReplacementData[] replacedTypeNameArray, CSharpSyntaxNode syntaxNode)
        {
            var typeNodes = syntaxNode.DescendantNodes()
                .OfType<TypeSyntax>()
                .Where(f => replacedTypeNameArray.Any(r => r.OldTypeName == f.ToString()));


            return syntaxNode.ReplaceNodes(typeNodes, (n1, n2) =>
            {
                var name = n1.ToString();
                var newName = replacedTypeNameArray.First(f => f.OldTypeName == name).NewTypeName;
                var newType = SyntaxFactory.ParseTypeName(newName);

                return newType;
            });

        }

    }
}
