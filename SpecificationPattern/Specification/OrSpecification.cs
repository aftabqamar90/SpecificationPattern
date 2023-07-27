using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecificationPattern.Specification
{
    public class OrSpecification<T> : CompositeSpecification<T>
    {
        ISpecification<T> leftSide;
        ISpecification<T> rightSide;
        public OrSpecification(ISpecification<T> leftSide, ISpecification<T> rightSide)
        {
            this.leftSide = leftSide;
            this.rightSide = rightSide;
        }

        public override bool IsSatisfiedBy(T o)
        {
            return leftSide.IsSatisfiedBy(o) || rightSide.IsSatisfiedBy(o);
        }
    }
}
