using System;
using System.Diagnostics.CodeAnalysis;
using System.Threading.Tasks;

namespace System.Net.FtpClient.Extensions.Async
{
    /// <summary>
    /// ChecksumExtension
    /// </summary>
    [ExcludeFromCodeCoverage]
    public static class ChecksumExtensionAsync
    {
        /// <summary>
        /// Gets the checksum asynchronous.
        /// </summary>
        /// <param name="client">The client.</param>
        /// <param name="path">The path.</param>
        /// <param name="factory">The factory.</param>
        /// <param name="creationOptions">The creation options.</param>
        /// <param name="scheduler">The scheduler.</param>
        /// <returns></returns>
        public static Task<FtpHash> GetChecksumAsync(this FtpClient client, string path,
            TaskFactory<FtpHash> factory = null,
            TaskCreationOptions creationOptions = default(TaskCreationOptions),
            TaskScheduler scheduler = null)
        {
            return (factory = factory ?? Task<FtpHash>.Factory).FromAsync(
                client.BeginGetChecksum(path, null, null),
                ChecksumExtension.EndGetChecksum,
                creationOptions, scheduler ?? factory.Scheduler ?? TaskScheduler.Current);
        }
    }
}
