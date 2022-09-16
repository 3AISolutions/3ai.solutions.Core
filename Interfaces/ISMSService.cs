namespace _3ai.solutions.Core.Interfaces
{
    public interface ISMSService
    {
        public Task<bool> SendSMSAsync(string message, string number, CancellationToken token = default);
    }
}