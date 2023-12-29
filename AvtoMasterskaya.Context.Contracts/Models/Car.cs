using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvtoMasterskaya.Context.Contracts.Models
{
    public class Car : BaseEntyty
    {
        /// <summary>
        /// Марка
        /// </summary>
        public string Marka { get; set; } = string.Empty;
        /// <summary>
        /// Модель
        /// </summary>
        public string Model { get; set; } = string.Empty;
        /// <summary>
        /// Гос.Номер
        /// </summary>
        public string Gos_Number { get; set; } = string.Empty;
        /// <summary>
        /// ViN номер
        /// </summary>
        public string ViN { get; set; } = string.Empty;
        /// <summary>
        /// Пробег
        /// </summary>
        public int Probeg { get; set; }
    }
}
