using System;
using System.Net.FtpClient.Extensions;
using System.Threading.Tasks;

namespace System.Net.FtpClient.Async.Extensions
{
    /// <summary>
    /// XMD5Async
    /// </summary>
    public static class XMD5Async
    {
        /// <summary>
        /// Gets the xm d5 asynchronous.
        /// </summary>
        /// <param name="client">The client.</param>
        /// <param name="path">The path.</param>
        /// <param name="factory">The factory.</param>
        /// <param name="creationOptions">The creation options.</param>
        /// <param name="scheduler">The scheduler.</param>
        /// <returns></returns>
        public static Task<string> GetXMD5Async(this FtpClient client, string path,
            TaskFactory<string> factory = null,
            TaskCreationOptions creationOptions = default(TaskCreationOptions),
            TaskScheduler scheduler = null)
        {
            return (factory = factory ?? Task<string>.Factory).FromAsync(
                client.BeginGetXMD5(path, null, null),
                XMD5.EndGetXMD5,
                creationOptions, scheduler ?? factory.Scheduler);
        }
    }
}
