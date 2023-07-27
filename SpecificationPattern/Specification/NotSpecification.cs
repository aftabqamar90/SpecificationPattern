using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecificationPattern.Specification
{
    public class NotSpecification<T> : CompositeSpecification<T>
    {
        ISpecification<T> otherSpecification;
        public NotSpecification(ISpecification<T> otherSpecification)
        {
            this.otherSpecification = otherSpecification;
        }

        public override bool IsSatisfiedBy(T o)
        {
            return !otherSpecification.IsSatisfiedBy(o);
        }
    }
}
