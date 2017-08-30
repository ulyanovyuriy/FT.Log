using System;
using System.Collections.Generic;

namespace FT.Log.Core.Source
{
    /// <summary>
    /// Переключаемый контекст логирования
    /// </summary>
    public sealed class SwitchLogSource : ILogSource
    {
        /// <summary>
        /// список контекстов
        /// </summary>
        private readonly SortedList<int, ILogSource> _list = new SortedList<int, ILogSource>();

        /// <summary>
        /// Список контекстов
        /// </summary>
        public SortedList<int, ILogSource> List => _list;

        /// <summary>
        /// Добавить
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public SwitchLogSource Add(ILogSource context, int priority)
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
