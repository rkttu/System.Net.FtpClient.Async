using System;
using System.Net.FtpClient.Extensions;
using System.Threading.Tasks;

namespace System.Net.FtpClient.Async.Extensions
{
    /// <summary>
    /// XSHA512Async
    /// </summary>
    public static class XSHA512Async
    {
        /// <summary>
        /// Gets the XSH a512 asynchronous.
        /// </summary>
        /// <param name="client">The client.</param>
        /// <param name="path">The path.</param>
        /// <param name="factory">The factory.</param>
        /// <param name="creationOptions">The creation options.</param>
        /// <param name="scheduler">The scheduler.</param>
        /// <returns></returns>
        public static Task<string> GetXSHA512Async(this FtpClient client, string path,
            TaskFactory<string> factory = null,
            TaskCreationOptions creationOptions = default(TaskCreationOptions),
            TaskScheduler scheduler = null)
        {
            return (factory = factory ?? Task<string>.Factory).FromAsync(
                client.BeginGetXSHA512(path, null, null),
                XSHA512.EndGetXSHA512,
                creationOptions, scheduler ?? factory.Scheduler ?? TaskScheduler.Current);
        }
    }
}
