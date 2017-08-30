using System;
using System.ServiceModel;

namespace FT.Log.Core.Context
{
    /// <summary>
    /// Контекст логирования WCF
    /// </summary>
    public class WcfLogContext : ILogContext
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
