using _3ai.solutions.Core.Models;
namespace _3ai.solutions.Core.Interfaces
{
    public interface ISMSService
    {
        public Task<Result> SendSMSAsync(string message, string number, CancellationToken token = default);
        public Task<Result> SendSMSAsync(string message, string number, string senderId, CancellationToken token = default);
        public Task<Result> SendSMSAsync(string message, string number, string senderId, string smsType, CancellationToken token = default);
    }
}
