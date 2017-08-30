using System;
using System.ServiceModel;

namespace FT.Log.Core.Source
{
    /// <summary>
    /// Контекст логирования WCF
    /// </summary>
    public class WcfLogSource : ILogSource
    {
        /// <summary>
        /// Получить имя источника
        /// </summary>
        /// <returns></returns>
        public string GetSource() =>
            OperationContext
            .Current
            ?.Host.Description.Name;
    }
}
