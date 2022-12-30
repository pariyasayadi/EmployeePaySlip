using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePaySlip2.Interfaces
{
    public interface ISalaryIncrease
    {
       Task<bool> Increase();
    }
}
