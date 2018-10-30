using System.Collections.Generic;

namespace DEV_5
{
    interface IExecutable
    {
        void Execute(List<Car> Cars, string additionalParameter);
    }
}