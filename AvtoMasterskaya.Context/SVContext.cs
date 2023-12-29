using AvtoMasterskaya.Context.Contracts.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvtoMasterskaya.Context
{
    public class SVContext : IContext
    {
        private ICollection<Nakladnaya> nakladnayas;
        private ICollection<Platelshik> platelshiks;
        private ICollection<Postavshik> postavshiks;
        private ICollection<Car> cars;
        public SVContext()
        {
            nakladnayas = new HashSet<Nakladnaya>();
            platelshiks = new HashSet<Platelshik>();
            postavshiks = new HashSet<Postavshik>();
            cars = new HashSet<Car>();
            Seed();
        }
        public ICollection<Nakladnaya> Nakladnayas => nakladnayas;
        public ICollection<Platelshik> Platelshiks => platelshiks;
        public ICollection<Postavshik> Postavshiks => postavshiks;
        public ICollection<Car> Cars => cars;

        private void Seed()
        {
            /// <summary>
            /// Информация накладной
            /// </summary>
            Nakladnayas.Add(new Nakladnaya
            {
                Id = Guid.NewGuid(),
                Name = "Мойка",
                Summa = "1600руб"
            });
            Nakladnayas.Add(new Nakladnaya
            {
                Id = Guid.NewGuid(),
                Name = "Замена тормозной жидкости",
                Summa = "2000руб"
            });
            Platelshiks.Add(new Platelshik
            {
                Id = Guid.NewGuid(),
                Name = "ОАО Баев и Ко",
                Inn = 0461111103,
                Kpp = 771001001
            });
            Platelshiks.Add(new Platelshik
            {
                Id = Guid.NewGuid(),
                Name = "ООО Гамма",
                Inn = 123456789,
                Kpp = 112230011
            });
            Postavshiks.Add(new Postavshik
            {
                Id = Guid.NewGuid(),
                Name = "ООО Ветерок",
                Inn = 444550011,
                Kpp = 123224455,
                Adres = "г.Москва,ул., Симферопольский дом 78, кв.1",
                Number = 891134512
            });
            Postavshiks.Add(new Postavshik
            {
                Id = Guid.NewGuid(),
                Name = "ООО Альфа",
                Inn = 332114441,
                Kpp = 662326632,
                Adres = "г.Санкт-Петербург, ул., Лисичанская дом 41, кв.10",
                Number = 899900022
            });
            Cars.Add(new Car
            {
                Id = Guid.NewGuid(),
                Marka = "BMW",
                Model = "M5",
                Gos_Number = "В777ОР",
                ViN = "Т331РВ11",
                Probeg = 20000
            });
            Cars.Add(new Car
            {
                Id = Guid.NewGuid(),
                Marka = "Mercedes-Benz",
                Model = "GLC",
                Gos_Number = "М000ЭР",
                ViN = "АР1223В00",
                Probeg = 45000
            });
        }
    }
}
