namespace _3ai.solutions.Core.Interfaces
{
    public interface IStorageService
    {
        public Task<byte[]> GetAsync(string remotePath, CancellationToken token = default);
        public Task<bool> DeleteAsync(string remotePath, CancellationToken token = default);
        public Task<string> AddAsync(string relativePath, byte[] data, string contentType, CancellationToken token = default);
        public string GetURI(string remotePath);
        public string GetAccessURL(string remotePath, string ip);
        public Task<bool> ZipAsync(string remotePaths, CancellationToken token = default);
    }
}