using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace PWS_6
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени интерфейса "IWcfDataService1" в коде и файле конфигурации.
    [ServiceContract]
    public interface IWcfDataService1
    {
        [OperationContract]
        void DoWork();
    }
}
