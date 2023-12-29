using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvtoMasterskaya.Context.Contracts.Models
{
    public class Nakladnaya : BaseEntyty
    {
        /// <summary>
        /// Наименование
        /// </summary>
        public string Name { get; set; } = string.Empty;
        /// <summary>
        /// Сумма
        /// </summary>
        public string Summa { get; set; } = string.Empty;
    }
}
    