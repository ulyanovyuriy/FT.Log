namespace FT.Log.Core
{
    /// <summary>
    /// Контекст логирования
    /// </summary>
    public interface ILogSource
    {
        /// <summary>
        /// получить имя источник логирования
        /// </summary>
        /// <returns></returns>
        string GetSource();
    }
}
