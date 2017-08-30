using System;
using System.Collections.Generic;

namespace FT.Log.Core.Context
{
    /// <summary>
    /// Переключаемый контекст логирования
    /// </summary>
    public sealed class SwitchLogContext : ILogContext
    {
        /// <summary>
        /// список контекстов
        /// </summary>
        private readonly SortedList<int, ILogContext> _list = new SortedList<int, ILogContext>();

        /// <summary>
        /// Список контекстов
        /// </summary>
        public SortedList<int, ILogContext> List => _list;

        /// <summary>
        /// Добавить
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public SwitchLogContext Add(ILogContext context, int priority)
        {
            if (context == null) throw new ArgumentNullException(nameof(context));
            List.Add(priority, context);
            return this;
        }
        /// <summary>
        /// Получить имя источника
        /// </summary>
        /// <returns></returns>
        public string GetSource()
        {
            foreach (var context in List)
            {
                var source = context.Value.GetSource();
                if (source != null)
                    return source;
            }

            return null;
        }
    }
}
