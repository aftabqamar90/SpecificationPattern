using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecificationPattern.Specification
{
    public class AndSpecification<T> : CompositeSpecification<T>
    {
        ISpecification<T> leftSide;
        ISpecification<T> rightSide;
        public AndSpecification(ISpecification<T> leftSide, ISpecification<T> rightSide)
        {
            this.leftSide = leftSide;
            this.rightSide = rightSide;
        }

        public override bool IsSatisfiedBy(T o)
        {
            return leftSide.IsSatisfiedBy(o) && rightSide.IsSatisfiedBy(o);
        }
    }
}
