using System;
using System.Net.FtpClient.Extensions;
using System.Threading.Tasks;

namespace System.Net.FtpClient.Async.Extensions
{
    /// <summary>
    /// XCRCAsync
    /// </summary>
    public static class XCRCAsync
    {
        /// <summary>
        /// Gets the XCRC asynchronous.
        /// </summary>
        /// <param name="client">The client.</param>
        /// <param name="path">The path.</param>
        /// <param name="factory">The factory.</param>
        /// <param name="creationOptions">The creation options.</param>
        /// <param name="scheduler">The scheduler.</param>
        /// <returns></returns>
        public static Task<string> GetXCRCAsync(this FtpClient client, string path,
            TaskFactory<string> factory = null,
            TaskCreationOptions creationOptions = default(TaskCreationOptions),
            TaskScheduler scheduler = null)
        {
            return (factory = factory ?? Task<string>.Factory).FromAsync(
                client.BeginGetXCRC(path, null, null),
                XCRC.EndGetXCRC,
                creationOptions, scheduler ?? factory.Scheduler);
        }
    }
}
