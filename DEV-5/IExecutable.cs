using System.Collections.Generic;

namespace DEV_5
{
    interface IExecutable
    {
        void Execute(CarsHouse carsHouse, string additionalParameter = null);
    }
}