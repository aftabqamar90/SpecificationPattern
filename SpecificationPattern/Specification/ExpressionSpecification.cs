using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecificationPattern.Specification
{
    internal class ExpressionSpecification<T> : CompositeSpecification<T>
    {
        Func<T, bool> predicate;
        public ExpressionSpecification(Func<T, bool> predicate)
        {
            this.predicate = predicate;
        }
        public override bool IsSatisfiedBy(T o)
        {
            return predicate(o);
        }
    }
}
