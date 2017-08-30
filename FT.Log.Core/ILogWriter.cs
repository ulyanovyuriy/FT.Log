namespace FT.Log.Core
{
    public interface ILogWriter
    {
        void Write(ILogSource source, ILogMessage message);
    }
}
