using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FT.Log.Core.Context
{
    /// <summary>
    /// Контекст логирования Службы
    /// </summary>
    public class ServiceLogContext : ILogContext
    {
        /// <summary>
        /// Получить имя источника
        /// </summary>
        /// <returns></returns>
        public string GetSource()
        {
            throw new NotImplementedException();
        }
    }
}
