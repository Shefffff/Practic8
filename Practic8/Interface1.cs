using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic8
{
    internal interface Interface1
    {
        // Интерфейс для корабля
        public interface IShip
        {
            string Name { get; set; }
            string Type { get; }
            int Capacity { get; set; }
            string GetInfo();
        }

        // Интерфейс для грузового транспорта
        public interface ICargoTransport
        {
            int Capacity { get; set; }
        }
    }
}
