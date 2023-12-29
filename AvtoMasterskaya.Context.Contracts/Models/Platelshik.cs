using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvtoMasterskaya.Context.Contracts.Models
{
    public class Platelshik : BaseEntyty
    {
        /// <summary>
        /// Наименование
        /// </summary>
        public string Name { get; set; } = string.Empty;
        /// <summary>
        /// ИНН
        /// </summary>
        public int Inn { get; set; }
        /// <summary>
        /// КПП
        /// </summary>
        public int Kpp { get; set; }
    }
}
