using RoslynTypeScript.Translation;
using System.Linq;

namespace RoslynTypeScript.VirtualTranslation
{
    public class PredicateGenericNameTranslation : BaseFunctionGenericNameTranslation
    {
        public PredicateGenericNameTranslation(GenericNameTranslation genericNameTranslation) : base(genericNameTranslation)
        {
        }

        protected override string InnerTranslate()
        {
            var firstParam = genericNameTranslation.TypeArgumentList.Arguments.GetEnumerable().First();
            return $"(_:{firstParam.Translate()})=>boolean";
        }
    }
}
