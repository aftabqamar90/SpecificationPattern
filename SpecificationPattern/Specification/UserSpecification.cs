using SpecificationPattern.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecificationPattern.Specification
{
    public class UserSpecification : CompositeSpecification<User>
    {
        public override bool IsSatisfiedBy(User o)
        {
            return !string.IsNullOrWhiteSpace(o.Name) && !string.IsNullOrWhiteSpace(o.Gender);
        }
    }
}
