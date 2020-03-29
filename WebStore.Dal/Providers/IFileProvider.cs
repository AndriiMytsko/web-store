namespace WebStore.Dal.Providers
{
    public interface IFileProvider
    {
        byte[] GetFile(string fileName);
        void WriteToExel<T>(T obj, string fileName);
    }
}
