﻿using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Threading.Tasks;

namespace System.Net.FtpClient.Async
{
    /// <summary>
    /// FtpClientAsyncExtension
    /// </summary>
    [ExcludeFromCodeCoverage]
    public static class FtpClientAsyncExtension
    {
        /// <summary>
        /// Connects the asynchronous.
        /// </summary>
        /// <typeparam name="TFtpClient">The type of the FTP client.</typeparam>
        /// <param name="client">The client.</param>
        /// <param name="factory">The factory.</param>
        /// <param name="creationOptions">The creation options.</param>
        /// <param name="scheduler">The scheduler.</param>
        /// <returns></returns>
        public static Task ConnectAsync<TFtpClient>(this TFtpClient client,
            TaskFactory factory = null,
            TaskCreationOptions creationOptions = default(TaskCreationOptions),
            TaskScheduler scheduler = null)
            where TFtpClient : IFtpClient
        {
            return (factory = factory ?? Task.Factory).FromAsync(
                client.BeginConnect(null, null),
                client.EndConnect,
                creationOptions, scheduler ?? factory.Scheduler ?? TaskScheduler.Current);
        }

        /// <summary>
        /// Creates the directory asynchronous.
        /// </summary>
        /// <typeparam name="TFtpClient">The type of the FTP client.</typeparam>
        /// <param name="client">The client.</param>
        /// <param name="path">The path.</param>
        /// <param name="factory">The factory.</param>
        /// <param name="creationOptions">The creation options.</param>
        /// <param name="scheduler">The scheduler.</param>
        /// <returns></returns>
        public static Task CreateDirectoryAsync<TFtpClient>(this TFtpClient client, string path,
            TaskFactory factory = null,
            TaskCreationOptions creationOptions = default(TaskCreationOptions),
            TaskScheduler scheduler = null)
            where TFtpClient : IFtpClient
        {
            return (factory = factory ?? Task.Factory).FromAsync(
                client.BeginCreateDirectory(path, null, null),
                client.EndCreateDirectory,
                creationOptions, scheduler ?? factory.Scheduler ?? TaskScheduler.Current);
        }

        /// <summary>
        /// Creates the directory asynchronous.
        /// </summary>
        /// <typeparam name="TFtpClient">The type of the FTP client.</typeparam>
        /// <param name="client">The client.</param>
        /// <param name="path">The path.</param>
        /// <param name="force">if set to <c>true</c> [force].</param>
        /// <param name="factory">The factory.</param>
        /// <param name="creationOptions">The creation options.</param>
        /// <param name="scheduler">The scheduler.</param>
        /// <returns></returns>
        public static Task CreateDirectoryAsync<TFtpClient>(this TFtpClient client, string path, bool force,
            TaskFactory factory = null,
            TaskCreationOptions creationOptions = default(TaskCreationOptions),
            TaskScheduler scheduler = null)
            where TFtpClient : IFtpClient
        {
            return (factory = factory ?? Task.Factory).FromAsync(
                client.BeginCreateDirectory(path, force, null, null),
                client.EndCreateDirectory,
                creationOptions, scheduler ?? factory.Scheduler ?? TaskScheduler.Current);
        }

        /// <summary>
        /// Deletes the directory asynchronous.
        /// </summary>
        /// <typeparam name="TFtpClient">The type of the FTP client.</typeparam>
        /// <param name="client">The client.</param>
        /// <param name="path">The path.</param>
        /// <param name="factory">The factory.</param>
        /// <param name="creationOptions">The creation options.</param>
        /// <param name="scheduler">The scheduler.</param>
        /// <returns></returns>
        public static Task DeleteDirectoryAsync<TFtpClient>(this TFtpClient client, string path,
            TaskFactory factory = null,
            TaskCreationOptions creationOptions = default(TaskCreationOptions),
            TaskScheduler scheduler = null)
            where TFtpClient : IFtpClient
        {
            return (factory = factory ?? Task.Factory).FromAsync(
                client.BeginDeleteDirectory(path, null, null),
                client.EndDeleteDirectory,
                creationOptions, scheduler ?? factory.Scheduler ?? TaskScheduler.Current);
        }

        /// <summary>
        /// Deletes the directory asynchronous.
        /// </summary>
        /// <typeparam name="TFtpClient">The type of the FTP client.</typeparam>
        /// <param name="client">The client.</param>
        /// <param name="path">The path.</param>
        /// <param name="force">if set to <c>true</c> [force].</param>
        /// <param name="factory">The factory.</param>
        /// <param name="creationOptions">The creation options.</param>
        /// <param name="scheduler">The scheduler.</param>
        /// <returns></returns>
        public static Task DeleteDirectoryAsync<TFtpClient>(this TFtpClient client, string path, bool force,
            TaskFactory factory = null,
            TaskCreationOptions creationOptions = default(TaskCreationOptions),
            TaskScheduler scheduler = null)
            where TFtpClient : IFtpClient
        {
            return (factory = factory ?? Task.Factory).FromAsync(
                client.BeginDeleteDirectory(path, force, null, null),
                client.EndDeleteDirectory,
                creationOptions, scheduler ?? factory.Scheduler ?? TaskScheduler.Current);
        }

        /// <summary>
        /// Deletes the directory asynchronous.
        /// </summary>
        /// <typeparam name="TFtpClient">The type of the FTP client.</typeparam>
        /// <param name="client">The client.</param>
        /// <param name="path">The path.</param>
        /// <param name="force">if set to <c>true</c> [force].</param>
        /// <param name="options">The options.</param>
        /// <param name="factory">The factory.</param>
        /// <param name="creationOptions">The creation options.</param>
        /// <param name="scheduler">The scheduler.</param>
        /// <returns></returns>
        public static Task DeleteDirectoryAsync<TFtpClient>(this TFtpClient client, string path, bool force, FtpListOption options,
            TaskFactory factory = null,
            TaskCreationOptions creationOptions = default(TaskCreationOptions),
            TaskScheduler scheduler = null)
            where TFtpClient : IFtpClient
        {
            return (factory = factory ?? Task.Factory).FromAsync(
                client.BeginDeleteDirectory(path, force, options, null, null),
                client.EndDeleteDirectory,
                creationOptions, scheduler ?? factory.Scheduler ?? TaskScheduler.Current);
        }

        /// <summary>
        /// Deletes the file asynchronous.
        /// </summary>
        /// <typeparam name="TFtpClient">The type of the FTP client.</typeparam>
        /// <param name="client">The client.</param>
        /// <param name="path">The path.</param>
        /// <param name="factory">The factory.</param>
        /// <param name="creationOptions">The creation options.</param>
        /// <param name="scheduler">The scheduler.</param>
        /// <returns></returns>
        public static Task DeleteFileAsync<TFtpClient>(this TFtpClient client, string path,
            TaskFactory factory = null,
            TaskCreationOptions creationOptions = default(TaskCreationOptions),
            TaskScheduler scheduler = null)
            where TFtpClient : IFtpClient
        {
            return (factory = factory ?? Task.Factory).FromAsync(
                client.BeginDeleteFile(path, null, null),
                client.EndDeleteFile,
                creationOptions, scheduler ?? factory.Scheduler ?? TaskScheduler.Current);
        }

        /// <summary>
        /// Dereferences the link asynchronous.
        /// </summary>
        /// <typeparam name="TFtpClient">The type of the FTP client.</typeparam>
        /// <param name="client">The client.</param>
        /// <param name="item">The item.</param>
        /// <param name="factory">The factory.</param>
        /// <param name="creationOptions">The creation options.</param>
        /// <param name="scheduler">The scheduler.</param>
        /// <returns></returns>
        public static Task<FtpListItem> DereferenceLinkAsync<TFtpClient>(this TFtpClient client, FtpListItem item,
            TaskFactory<FtpListItem> factory = null,
            TaskCreationOptions creationOptions = default(TaskCreationOptions),
            TaskScheduler scheduler = null)
            where TFtpClient : IFtpClient
        {
            return (factory = factory ?? Task<FtpListItem>.Factory).FromAsync(
                client.BeginDereferenceLink(item, null, null),
                client.EndDereferenceLink,
                creationOptions, scheduler ?? factory.Scheduler ?? TaskScheduler.Current);
        }

        /// <summary>
        /// Dereferences the link asynchronous.
        /// </summary>
        /// <typeparam name="TFtpClient">The type of the FTP client.</typeparam>
        /// <param name="client">The client.</param>
        /// <param name="item">The item.</param>
        /// <param name="recMax">The record maximum.</param>
        /// <param name="factory">The factory.</param>
        /// <param name="creationOptions">The creation options.</param>
        /// <param name="scheduler">The scheduler.</param>
        /// <returns></returns>
        public static Task<FtpListItem> DereferenceLinkAsync<TFtpClient>(this TFtpClient client, FtpListItem item, int recMax,
            TaskFactory<FtpListItem> factory = null,
            TaskCreationOptions creationOptions = default(TaskCreationOptions),
            TaskScheduler scheduler = null)
            where TFtpClient : IFtpClient
        {
            return (factory = factory ?? Task<FtpListItem>.Factory).FromAsync(
                client.BeginDereferenceLink(item, recMax, null, null),
                client.EndDereferenceLink,
                creationOptions, scheduler ?? factory.Scheduler ?? TaskScheduler.Current);
        }

        /// <summary>
        /// Directories the exists asynchronous.
        /// </summary>
        /// <typeparam name="TFtpClient">The type of the FTP client.</typeparam>
        /// <param name="client">The client.</param>
        /// <param name="path">The path.</param>
        /// <param name="factory">The factory.</param>
        /// <param name="creationOptions">The creation options.</param>
        /// <param name="scheduler">The scheduler.</param>
        /// <returns></returns>
        public static Task<bool> DirectoryExistsAsync<TFtpClient>(this TFtpClient client, string path,
            TaskFactory<bool> factory = null,
            TaskCreationOptions creationOptions = default(TaskCreationOptions),
            TaskScheduler scheduler = null)
            where TFtpClient : IFtpClient
        {
            return (factory = factory ?? Task<bool>.Factory).FromAsync(
                client.BeginDirectoryExists(path, null, null),
                client.EndDirectoryExists,
                creationOptions, scheduler ?? factory.Scheduler ?? TaskScheduler.Current);
        }

        /// <summary>
        /// Disconnects the asynchronous.
        /// </summary>
        /// <typeparam name="TFtpClient">The type of the FTP client.</typeparam>
        /// <param name="client">The client.</param>
        /// <param name="factory">The factory.</param>
        /// <param name="creationOptions">The creation options.</param>
        /// <param name="scheduler">The scheduler.</param>
        /// <returns></returns>
        public static Task DisconnectAsync<TFtpClient>(this TFtpClient client,
            TaskFactory factory = null,
            TaskCreationOptions creationOptions = default(TaskCreationOptions),
            TaskScheduler scheduler = null)
            where TFtpClient : IFtpClient
        {
            return (factory = factory ?? Task.Factory).FromAsync(
                client.BeginDisconnect(null, null),
                client.EndDisconnect,
                creationOptions, scheduler ?? factory.Scheduler ?? TaskScheduler.Current);
        }

        /// <summary>
        /// Executes the asynchronous.
        /// </summary>
        /// <typeparam name="TFtpClient">The type of the FTP client.</typeparam>
        /// <param name="client">The client.</param>
        /// <param name="command">The command.</param>
        /// <param name="factory">The factory.</param>
        /// <param name="creationOptions">The creation options.</param>
        /// <param name="scheduler">The scheduler.</param>
        /// <returns></returns>
        public static Task<FtpReply> ExecuteAsync<TFtpClient>(this TFtpClient client, string command,
            TaskFactory<FtpReply> factory = null,
            TaskCreationOptions creationOptions = default(TaskCreationOptions),
            TaskScheduler scheduler = null)
            where TFtpClient : IFtpClient
        {
            return (factory = factory ?? Task<FtpReply>.Factory).FromAsync(
                client.BeginExecute(command, null, null),
                client.EndExecute,
                creationOptions, scheduler ?? factory.Scheduler ?? TaskScheduler.Current);
        }

        /// <summary>
        /// Files the exists asynchronous.
        /// </summary>
        /// <typeparam name="TFtpClient">The type of the FTP client.</typeparam>
        /// <param name="client">The client.</param>
        /// <param name="path">The path.</param>
        /// <param name="factory">The factory.</param>
        /// <param name="creationOptions">The creation options.</param>
        /// <param name="scheduler">The scheduler.</param>
        /// <returns></returns>
        public static Task<bool> FileExistsAsync<TFtpClient>(this TFtpClient client, string path,
            TaskFactory<bool> factory = null,
            TaskCreationOptions creationOptions = default(TaskCreationOptions),
            TaskScheduler scheduler = null)
            where TFtpClient : IFtpClient
        {
            return (factory = factory ?? Task<bool>.Factory).FromAsync(
                client.BeginFileExists(path, null, null),
                client.EndFileExists,
                creationOptions, scheduler ?? factory.Scheduler ?? TaskScheduler.Current);
        }

        /// <summary>
        /// Files the exists asynchronous.
        /// </summary>
        /// <typeparam name="TFtpClient">The type of the FTP client.</typeparam>
        /// <param name="client">The client.</param>
        /// <param name="path">The path.</param>
        /// <param name="options">The options.</param>
        /// <param name="factory">The factory.</param>
        /// <param name="creationOptions">The creation options.</param>
        /// <param name="scheduler">The scheduler.</param>
        /// <returns></returns>
        public static Task<bool> FileExistsAsync<TFtpClient>(this TFtpClient client, string path, FtpListOption options,
            TaskFactory<bool> factory = null,
            TaskCreationOptions creationOptions = default(TaskCreationOptions),
            TaskScheduler scheduler = null)
            where TFtpClient : IFtpClient
        {
            return (factory = factory ?? Task<bool>.Factory).FromAsync(
                client.BeginFileExists(path, options, null, null),
                client.EndFileExists,
                creationOptions, scheduler ?? factory.Scheduler ?? TaskScheduler.Current);
        }

        /// <summary>
        /// Gets the file size asynchronous.
        /// </summary>
        /// <typeparam name="TFtpClient">The type of the FTP client.</typeparam>
        /// <param name="client">The client.</param>
        /// <param name="path">The path.</param>
        /// <param name="factory">The factory.</param>
        /// <param name="creationOptions">The creation options.</param>
        /// <param name="scheduler">The scheduler.</param>
        /// <returns></returns>
        public static Task<long> GetFileSizeAsync<TFtpClient>(this TFtpClient client, string path,
            TaskFactory<long> factory = null,
            TaskCreationOptions creationOptions = default(TaskCreationOptions),
            TaskScheduler scheduler = null)
            where TFtpClient : IFtpClient
        {
            return (factory = factory ?? Task<long>.Factory).FromAsync(
                client.BeginGetFileSize(path, null, null),
                client.EndGetFileSize,
                creationOptions, scheduler ?? factory.Scheduler ?? TaskScheduler.Current);
        }

        /// <summary>
        /// Gets the hash asynchronous.
        /// </summary>
        /// <typeparam name="TFtpClient">The type of the FTP client.</typeparam>
        /// <param name="client">The client.</param>
        /// <param name="path">The path.</param>
        /// <param name="factory">The factory.</param>
        /// <param name="creationOptions">The creation options.</param>
        /// <param name="scheduler">The scheduler.</param>
        /// <returns></returns>
        public static Task GetHashAsync<TFtpClient>(this TFtpClient client, string path,
            TaskFactory factory = null,
            TaskCreationOptions creationOptions = default(TaskCreationOptions),
            TaskScheduler scheduler = null)
            where TFtpClient : IFtpClient
        {
            return (factory = factory ?? Task.Factory).FromAsync(
                client.BeginGetHash(path, null, null),
                client.EndGetHash,
                creationOptions, scheduler ?? factory.Scheduler ?? TaskScheduler.Current);
        }

        /// <summary>
        /// Gets the hash algorithm asynchronous.
        /// </summary>
        /// <typeparam name="TFtpClient">The type of the FTP client.</typeparam>
        /// <param name="client">The client.</param>
        /// <param name="factory">The factory.</param>
        /// <param name="creationOptions">The creation options.</param>
        /// <param name="scheduler">The scheduler.</param>
        /// <returns></returns>
        public static Task<FtpHashAlgorithm> GetHashAlgorithmAsync<TFtpClient>(this TFtpClient client,
            TaskFactory<FtpHashAlgorithm> factory = null,
            TaskCreationOptions creationOptions = default(TaskCreationOptions),
            TaskScheduler scheduler = null)
            where TFtpClient : IFtpClient
        {
            return (factory = factory ?? Task<FtpHashAlgorithm>.Factory).FromAsync(
                client.BeginGetHashAlgorithm(null, null),
                client.EndGetHashAlgorithm,
                creationOptions, scheduler ?? factory.Scheduler ?? TaskScheduler.Current);
        }

        /// <summary>
        /// Gets the listing asynchronous.
        /// </summary>
        /// <typeparam name="TFtpClient">The type of the FTP client.</typeparam>
        /// <param name="client">The client.</param>
        /// <param name="factory">The factory.</param>
        /// <param name="creationOptions">The creation options.</param>
        /// <param name="scheduler">The scheduler.</param>
        /// <returns></returns>
        public static Task<FtpListItem[]> GetListingAsync<TFtpClient>(this TFtpClient client,
            TaskFactory<FtpListItem[]> factory = null,
            TaskCreationOptions creationOptions = default(TaskCreationOptions),
            TaskScheduler scheduler = null)
            where TFtpClient : IFtpClient
        {
            return (factory = factory ?? Task<FtpListItem[]>.Factory).FromAsync(
                client.BeginGetListing(null, null),
                client.EndGetListing,
                creationOptions, scheduler ?? factory.Scheduler ?? TaskScheduler.Current);
        }

        /// <summary>
        /// Gets the listing asynchronous.
        /// </summary>
        /// <typeparam name="TFtpClient">The type of the FTP client.</typeparam>
        /// <param name="client">The client.</param>
        /// <param name="path">The path.</param>
        /// <param name="factory">The factory.</param>
        /// <param name="creationOptions">The creation options.</param>
        /// <param name="scheduler">The scheduler.</param>
        /// <returns></returns>
        public static Task<FtpListItem[]> GetListingAsync<TFtpClient>(this TFtpClient client, string path,
            TaskFactory<FtpListItem[]> factory = null,
            TaskCreationOptions creationOptions = default(TaskCreationOptions),
            TaskScheduler scheduler = null)
            where TFtpClient : IFtpClient
        {
            return (factory = factory ?? Task<FtpListItem[]>.Factory).FromAsync(
                client.BeginGetListing(path, null, null),
                client.EndGetListing,
                creationOptions, scheduler ?? factory.Scheduler ?? TaskScheduler.Current);
        }

        /// <summary>
        /// Gets the listing asynchronous.
        /// </summary>
        /// <typeparam name="TFtpClient">The type of the FTP client.</typeparam>
        /// <param name="client">The client.</param>
        /// <param name="path">The path.</param>
        /// <param name="options">The options.</param>
        /// <param name="factory">The factory.</param>
        /// <param name="creationOptions">The creation options.</param>
        /// <param name="scheduler">The scheduler.</param>
        /// <returns></returns>
        public static Task<FtpListItem[]> GetListingAsync<TFtpClient>(this TFtpClient client, string path, FtpListOption options,
            TaskFactory<FtpListItem[]> factory = null,
            TaskCreationOptions creationOptions = default(TaskCreationOptions),
            TaskScheduler scheduler = null)
            where TFtpClient : IFtpClient
        {
            return (factory = factory ?? Task<FtpListItem[]>.Factory).FromAsync(
                client.BeginGetListing(path, options, null, null),
                client.EndGetListing,
                creationOptions, scheduler ?? factory.Scheduler ?? TaskScheduler.Current);
        }

        /// <summary>
        /// Gets the modified time asynchronous.
        /// </summary>
        /// <typeparam name="TFtpClient">The type of the FTP client.</typeparam>
        /// <param name="client">The client.</param>
        /// <param name="path">The path.</param>
        /// <param name="factory">The factory.</param>
        /// <param name="creationOptions">The creation options.</param>
        /// <param name="scheduler">The scheduler.</param>
        /// <returns></returns>
        public static Task<DateTime> GetModifiedTimeAsync<TFtpClient>(this TFtpClient client, string path,
            TaskFactory<DateTime> factory = null,
            TaskCreationOptions creationOptions = default(TaskCreationOptions),
            TaskScheduler scheduler = null)
            where TFtpClient : IFtpClient
        {
            return (factory = factory ?? Task<DateTime>.Factory).FromAsync(
                client.BeginGetModifiedTime(path, null, null),
                client.EndGetModifiedTime,
                creationOptions, scheduler ?? factory.Scheduler ?? TaskScheduler.Current);
        }

        /// <summary>
        /// Gets the name listing asynchronous.
        /// </summary>
        /// <typeparam name="TFtpClient">The type of the FTP client.</typeparam>
        /// <param name="client">The client.</param>
        /// <param name="factory">The factory.</param>
        /// <param name="creationOptions">The creation options.</param>
        /// <param name="scheduler">The scheduler.</param>
        /// <returns></returns>
        public static Task<string[]> GetNameListingAsync<TFtpClient>(this TFtpClient client,
            TaskFactory<string[]> factory = null,
            TaskCreationOptions creationOptions = default(TaskCreationOptions),
            TaskScheduler scheduler = null)
            where TFtpClient : IFtpClient
        {
            return (factory = factory ?? Task<string[]>.Factory).FromAsync(
                client.BeginGetNameListing(null, null),
                client.EndGetNameListing,
                creationOptions, scheduler ?? factory.Scheduler ?? TaskScheduler.Current);
        }

        /// <summary>
        /// Gets the name listing asynchronous.
        /// </summary>
        /// <typeparam name="TFtpClient">The type of the FTP client.</typeparam>
        /// <param name="client">The client.</param>
        /// <param name="path">The path.</param>
        /// <param name="factory">The factory.</param>
        /// <param name="creationOptions">The creation options.</param>
        /// <param name="scheduler">The scheduler.</param>
        /// <returns></returns>
        public static Task<string[]> GetNameListingAsync<TFtpClient>(this TFtpClient client, string path,
            TaskFactory<string[]> factory = null,
            TaskCreationOptions creationOptions = default(TaskCreationOptions),
            TaskScheduler scheduler = null)
            where TFtpClient : IFtpClient
        {
            return (factory = factory ?? Task<string[]>.Factory).FromAsync(
                client.BeginGetNameListing(path, null, null),
                client.EndGetNameListing,
                creationOptions, scheduler ?? factory.Scheduler ?? TaskScheduler.Current);
        }

        /// <summary>
        /// Gets the object information asynchronous.
        /// </summary>
        /// <typeparam name="TFtpClient">The type of the FTP client.</typeparam>
        /// <param name="client">The client.</param>
        /// <param name="path">The path.</param>
        /// <param name="factory">The factory.</param>
        /// <param name="creationOptions">The creation options.</param>
        /// <param name="scheduler">The scheduler.</param>
        /// <returns></returns>
        public static Task<FtpListItem> GetObjectInfoAsync<TFtpClient>(this TFtpClient client, string path,
            TaskFactory<FtpListItem> factory = null,
            TaskCreationOptions creationOptions = default(TaskCreationOptions),
            TaskScheduler scheduler = null)
            where TFtpClient : IFtpClient
        {
            return (factory = factory ?? Task<FtpListItem>.Factory).FromAsync(
                client.BeginGetObjectInfo(path, null, null),
                client.EndGetObjectInfo,
                creationOptions, scheduler ?? factory.Scheduler ?? TaskScheduler.Current);
        }

        /// <summary>
        /// Gets the working directory asynchronous.
        /// </summary>
        /// <typeparam name="TFtpClient">The type of the FTP client.</typeparam>
        /// <param name="client">The client.</param>
        /// <param name="factory">The factory.</param>
        /// <param name="creationOptions">The creation options.</param>
        /// <param name="scheduler">The scheduler.</param>
        /// <returns></returns>
        public static Task<string> GetWorkingDirectoryAsync<TFtpClient>(this TFtpClient client,
            TaskFactory<string> factory = null,
            TaskCreationOptions creationOptions = default(TaskCreationOptions),
            TaskScheduler scheduler = null)
            where TFtpClient : IFtpClient
        {
            return (factory = factory ?? Task<string>.Factory).FromAsync(
                client.BeginGetWorkingDirectory(null, null),
                client.EndGetWorkingDirectory,
                creationOptions, scheduler ?? factory.Scheduler ?? TaskScheduler.Current);
        }

        /// <summary>
        /// Opens the append asynchronous.
        /// </summary>
        /// <typeparam name="TFtpClient">The type of the FTP client.</typeparam>
        /// <param name="client">The client.</param>
        /// <param name="path">The path.</param>
        /// <param name="factory">The factory.</param>
        /// <param name="creationOptions">The creation options.</param>
        /// <param name="scheduler">The scheduler.</param>
        /// <returns></returns>
        public static Task<Stream> OpenAppendAsync<TFtpClient>(this TFtpClient client, string path,
            TaskFactory<Stream> factory = null,
            TaskCreationOptions creationOptions = default(TaskCreationOptions),
            TaskScheduler scheduler = null)
            where TFtpClient : IFtpClient
        {
            return (factory = factory ?? Task<Stream>.Factory).FromAsync(
                client.BeginOpenAppend(path, null, null),
                client.EndOpenAppend,
                creationOptions, scheduler ?? factory.Scheduler ?? TaskScheduler.Current);
        }

        /// <summary>
        /// Opens the append asynchronous.
        /// </summary>
        /// <typeparam name="TFtpClient">The type of the FTP client.</typeparam>
        /// <param name="client">The client.</param>
        /// <param name="path">The path.</param>
        /// <param name="type">The type.</param>
        /// <param name="factory">The factory.</param>
        /// <param name="creationOptions">The creation options.</param>
        /// <param name="scheduler">The scheduler.</param>
        /// <returns></returns>
        public static Task<Stream> OpenAppendAsync<TFtpClient>(this TFtpClient client, string path, FtpDataType type,
            TaskFactory<Stream> factory = null,
            TaskCreationOptions creationOptions = default(TaskCreationOptions),
            TaskScheduler scheduler = null)
            where TFtpClient : IFtpClient
        {
            return (factory = factory ?? Task<Stream>.Factory).FromAsync(
                client.BeginOpenAppend(path, type, null, null),
                client.EndOpenAppend,
                creationOptions, scheduler ?? factory.Scheduler ?? TaskScheduler.Current);
        }

        /// <summary>
        /// Opens the read asynchronous.
        /// </summary>
        /// <typeparam name="TFtpClient">The type of the FTP client.</typeparam>
        /// <param name="client">The client.</param>
        /// <param name="path">The path.</param>
        /// <param name="factory">The factory.</param>
        /// <param name="creationOptions">The creation options.</param>
        /// <param name="scheduler">The scheduler.</param>
        /// <returns></returns>
        public static Task<Stream> OpenReadAsync<TFtpClient>(this TFtpClient client, string path,
            TaskFactory<Stream> factory = null,
            TaskCreationOptions creationOptions = default(TaskCreationOptions),
            TaskScheduler scheduler = null)
            where TFtpClient : IFtpClient
        {
            return (factory = factory ?? Task<Stream>.Factory).FromAsync(
                client.BeginOpenRead(path, null, null),
                client.EndOpenRead,
                creationOptions, scheduler ?? factory.Scheduler ?? TaskScheduler.Current);
        }

        /// <summary>
        /// Opens the read asynchronous.
        /// </summary>
        /// <typeparam name="TFtpClient">The type of the FTP client.</typeparam>
        /// <param name="client">The client.</param>
        /// <param name="path">The path.</param>
        /// <param name="restart">The restart.</param>
        /// <param name="factory">The factory.</param>
        /// <param name="creationOptions">The creation options.</param>
        /// <param name="scheduler">The scheduler.</param>
        /// <returns></returns>
        public static Task<Stream> OpenReadAsync<TFtpClient>(this TFtpClient client, string path, long restart,
            TaskFactory<Stream> factory = null,
            TaskCreationOptions creationOptions = default(TaskCreationOptions),
            TaskScheduler scheduler = null)
            where TFtpClient : IFtpClient
        {
            return (factory = factory ?? Task<Stream>.Factory).FromAsync(
                client.BeginOpenRead(path, restart, null, null),
                client.EndOpenRead,
                creationOptions, scheduler ?? factory.Scheduler ?? TaskScheduler.Current);
        }

        /// <summary>
        /// Opens the read asynchronous.
        /// </summary>
        /// <typeparam name="TFtpClient">The type of the FTP client.</typeparam>
        /// <param name="client">The client.</param>
        /// <param name="path">The path.</param>
        /// <param name="type">The type.</param>
        /// <param name="factory">The factory.</param>
        /// <param name="creationOptions">The creation options.</param>
        /// <param name="scheduler">The scheduler.</param>
        /// <returns></returns>
        public static Task<Stream> OpenReadAsync<TFtpClient>(this TFtpClient client, string path, FtpDataType type,
            TaskFactory<Stream> factory = null,
            TaskCreationOptions creationOptions = default(TaskCreationOptions),
            TaskScheduler scheduler = null)
            where TFtpClient : IFtpClient
        {
            return (factory = factory ?? Task<Stream>.Factory).FromAsync(
                client.BeginOpenRead(path, type, null, null),
                client.EndOpenRead,
                creationOptions, scheduler ?? factory.Scheduler ?? TaskScheduler.Current);
        }

        /// <summary>
        /// Opens the read asynchronous.
        /// </summary>
        /// <typeparam name="TFtpClient">The type of the FTP client.</typeparam>
        /// <param name="client">The client.</param>
        /// <param name="path">The path.</param>
        /// <param name="type">The type.</param>
        /// <param name="restart">The restart.</param>
        /// <param name="factory">The factory.</param>
        /// <param name="creationOptions">The creation options.</param>
        /// <param name="scheduler">The scheduler.</param>
        /// <returns></returns>
        public static Task<Stream> OpenReadAsync<TFtpClient>(this TFtpClient client, string path, FtpDataType type, long restart,
            TaskFactory<Stream> factory = null,
            TaskCreationOptions creationOptions = default(TaskCreationOptions),
            TaskScheduler scheduler = null)
            where TFtpClient : IFtpClient
        {
            return (factory = factory ?? Task<Stream>.Factory).FromAsync(
                client.BeginOpenRead(path, type, restart, null, null),
                client.EndOpenRead,
                creationOptions, scheduler ?? factory.Scheduler ?? TaskScheduler.Current);
        }

        /// <summary>
        /// Opens the write asynchronous.
        /// </summary>
        /// <typeparam name="TFtpClient">The type of the FTP client.</typeparam>
        /// <param name="client">The client.</param>
        /// <param name="path">The path.</param>
        /// <param name="factory">The factory.</param>
        /// <param name="creationOptions">The creation options.</param>
        /// <param name="scheduler">The scheduler.</param>
        /// <returns></returns>
        public static Task<Stream> OpenWriteAsync<TFtpClient>(this TFtpClient client, string path,
            TaskFactory<Stream> factory = null,
            TaskCreationOptions creationOptions = default(TaskCreationOptions),
            TaskScheduler scheduler = null)
            where TFtpClient : IFtpClient
        {
            return (factory = factory ?? Task<Stream>.Factory).FromAsync(
                client.BeginOpenWrite(path, null, null),
                client.EndOpenWrite,
                creationOptions, scheduler ?? factory.Scheduler ?? TaskScheduler.Current);
        }

        /// <summary>
        /// Opens the write asynchronous.
        /// </summary>
        /// <typeparam name="TFtpClient">The type of the FTP client.</typeparam>
        /// <param name="client">The client.</param>
        /// <param name="path">The path.</param>
        /// <param name="type">The type.</param>
        /// <param name="factory">The factory.</param>
        /// <param name="creationOptions">The creation options.</param>
        /// <param name="scheduler">The scheduler.</param>
        /// <returns></returns>
        public static Task<Stream> OpenWriteAsync<TFtpClient>(this TFtpClient client, string path, FtpDataType type,
            TaskFactory<Stream> factory = null,
            TaskCreationOptions creationOptions = default(TaskCreationOptions),
            TaskScheduler scheduler = null)
            where TFtpClient : IFtpClient
        {
            return (factory = factory ?? Task<Stream>.Factory).FromAsync(
                client.BeginOpenWrite(path, type, null, null),
                client.EndOpenWrite,
                creationOptions, scheduler ?? factory.Scheduler ?? TaskScheduler.Current);
        }

        /// <summary>
        /// Renames the asynchronous.
        /// </summary>
        /// <typeparam name="TFtpClient">The type of the FTP client.</typeparam>
        /// <param name="client">The client.</param>
        /// <param name="path">The path.</param>
        /// <param name="dest">The dest.</param>
        /// <param name="factory">The factory.</param>
        /// <param name="creationOptions">The creation options.</param>
        /// <param name="scheduler">The scheduler.</param>
        /// <returns></returns>
        public static Task RenameAsync<TFtpClient>(this TFtpClient client, string path, string dest,
            TaskFactory factory = null,
            TaskCreationOptions creationOptions = default(TaskCreationOptions),
            TaskScheduler scheduler = null)
            where TFtpClient : IFtpClient
        {
            return (factory = factory ?? Task.Factory).FromAsync(
                client.BeginRename(path, dest, null, null),
                client.EndRename,
                creationOptions, scheduler ?? factory.Scheduler ?? TaskScheduler.Current);
        }

        /// <summary>
        /// Sets the hash algorithm asynchronous.
        /// </summary>
        /// <typeparam name="TFtpClient">The type of the FTP client.</typeparam>
        /// <param name="client">The client.</param>
        /// <param name="type">The type.</param>
        /// <param name="factory">The factory.</param>
        /// <param name="creationOptions">The creation options.</param>
        /// <param name="scheduler">The scheduler.</param>
        /// <returns></returns>
        public static Task SetHashAlgorithmAsync<TFtpClient>(this TFtpClient client, FtpHashAlgorithm type,
            TaskFactory factory = null,
            TaskCreationOptions creationOptions = default(TaskCreationOptions),
            TaskScheduler scheduler = null)
            where TFtpClient : IFtpClient
        {
            return (factory = factory ?? Task.Factory).FromAsync(
                client.BeginSetHashAlgorithm(type, null, null),
                client.EndSetHashAlgorithm,
                creationOptions, scheduler ?? factory.Scheduler ?? TaskScheduler.Current);
        }

        /// <summary>
        /// Sets the working directory asynchronous.
        /// </summary>
        /// <typeparam name="TFtpClient">The type of the FTP client.</typeparam>
        /// <param name="client">The client.</param>
        /// <param name="path">The path.</param>
        /// <param name="factory">The factory.</param>
        /// <param name="creationOptions">The creation options.</param>
        /// <param name="scheduler">The scheduler.</param>
        /// <returns></returns>
        public static Task SetWorkingDirectoryAsync<TFtpClient>(this TFtpClient client, string path,
            TaskFactory factory = null,
            TaskCreationOptions creationOptions = default(TaskCreationOptions),
            TaskScheduler scheduler = null)
            where TFtpClient : IFtpClient
        {
            return (factory = factory ?? Task.Factory).FromAsync(
                client.BeginSetWorkingDirectory(path, null, null),
                client.EndSetWorkingDirectory,
                creationOptions, scheduler ?? factory.Scheduler ?? TaskScheduler.Current);
        }
    }
}
