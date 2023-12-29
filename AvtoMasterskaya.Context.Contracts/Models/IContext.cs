using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvtoMasterskaya.Context.Contracts.Models
{
    public interface IContext
    {
        ICollection<Nakladnaya> Nakladnayas { get; }
        ICollection<Platelshik> Platelshiks { get; }
        ICollection<Postavshik> Postavshiks { get; }
        ICollection<Car> Cars { get; }
    }
}
