// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.IO;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Analytics.Synapse.Artifacts.Models;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.Analytics.Synapse.Artifacts
{
    internal partial class LibraryRestClient
    {
        private string endpoint;
        private string apiVersion;
        private ClientDiagnostics _clientDiagnostics;
        private HttpPipeline _pipeline;

        /// <summary> Initializes a new instance of LibraryRestClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="endpoint"> The workspace development endpoint, for example https://myworkspace.dev.azuresynapse.net. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="endpoint"/> or <paramref name="apiVersion"/> is null. </exception>
        public LibraryRestClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string endpoint, string apiVersion = "2019-06-01-preview")
        {
            if (endpoint == null)
            {
                throw new ArgumentNullException(nameof(endpoint));
            }
            if (apiVersion == null)
            {
                throw new ArgumentNullException(nameof(apiVersion));
            }

            this.endpoint = endpoint;
            this.apiVersion = apiVersion;
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        internal HttpMessage CreateListRequest()
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(endpoint, false);
            uri.AppendPath("/libraries", false);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Lists Library. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response<LibraryListResponse>> ListAsync(CancellationToken cancellationToken = default)
        {
            using var message = CreateListRequest();
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        LibraryListResponse value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = LibraryListResponse.DeserializeLibraryListResponse(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Lists Library. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<LibraryListResponse> List(CancellationToken cancellationToken = default)
        {
            using var message = CreateListRequest();
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        LibraryListResponse value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = LibraryListResponse.DeserializeLibraryListResponse(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateFlushRequest(string libraryName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(endpoint, false);
            uri.AppendPath("/libraries/", false);
            uri.AppendPath(libraryName, true);
            uri.AppendPath("/flush", false);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Flush Library. </summary>
        /// <param name="libraryName"> file name to upload. Minimum length of the filename should be 1 excluding the extension length. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="libraryName"/> is null. </exception>
        public async Task<Response> FlushAsync(string libraryName, CancellationToken cancellationToken = default)
        {
            if (libraryName == null)
            {
                throw new ArgumentNullException(nameof(libraryName));
            }

            using var message = CreateFlushRequest(libraryName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 202:
                    return message.Response;
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Flush Library. </summary>
        /// <param name="libraryName"> file name to upload. Minimum length of the filename should be 1 excluding the extension length. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="libraryName"/> is null. </exception>
        public Response Flush(string libraryName, CancellationToken cancellationToken = default)
        {
            if (libraryName == null)
            {
                throw new ArgumentNullException(nameof(libraryName));
            }

            using var message = CreateFlushRequest(libraryName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 202:
                    return message.Response;
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetOperationResultRequest(string operationId)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(endpoint, false);
            uri.AppendPath("/libraryOperationResults/", false);
            uri.AppendPath(operationId, true);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Get Operation result for Library. </summary>
        /// <param name="operationId"> operation id for which status is requested. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="operationId"/> is null. </exception>
        public async Task<Response<object>> GetOperationResultAsync(string operationId, CancellationToken cancellationToken = default)
        {
            if (operationId == null)
            {
                throw new ArgumentNullException(nameof(operationId));
            }

            using var message = CreateGetOperationResultRequest(operationId);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        LibraryResource value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = LibraryResource.DeserializeLibraryResource(document.RootElement);
                        return Response.FromValue<object>(value, message.Response);
                    }
                case 202:
                    {
                        OperationResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = OperationResult.DeserializeOperationResult(document.RootElement);
                        return Response.FromValue<object>(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Get Operation result for Library. </summary>
        /// <param name="operationId"> operation id for which status is requested. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="operationId"/> is null. </exception>
        public Response<object> GetOperationResult(string operationId, CancellationToken cancellationToken = default)
        {
            if (operationId == null)
            {
                throw new ArgumentNullException(nameof(operationId));
            }

            using var message = CreateGetOperationResultRequest(operationId);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        LibraryResource value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = LibraryResource.DeserializeLibraryResource(document.RootElement);
                        return Response.FromValue<object>(value, message.Response);
                    }
                case 202:
                    {
                        OperationResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = OperationResult.DeserializeOperationResult(document.RootElement);
                        return Response.FromValue<object>(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateDeleteRequest(string libraryName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Delete;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(endpoint, false);
            uri.AppendPath("/libraries/", false);
            uri.AppendPath(libraryName, true);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Delete Library. </summary>
        /// <param name="libraryName"> file name to upload. Minimum length of the filename should be 1 excluding the extension length. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="libraryName"/> is null. </exception>
        public async Task<Response> DeleteAsync(string libraryName, CancellationToken cancellationToken = default)
        {
            if (libraryName == null)
            {
                throw new ArgumentNullException(nameof(libraryName));
            }

            using var message = CreateDeleteRequest(libraryName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 202:
                case 409:
                    return message.Response;
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Delete Library. </summary>
        /// <param name="libraryName"> file name to upload. Minimum length of the filename should be 1 excluding the extension length. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="libraryName"/> is null. </exception>
        public Response Delete(string libraryName, CancellationToken cancellationToken = default)
        {
            if (libraryName == null)
            {
                throw new ArgumentNullException(nameof(libraryName));
            }

            using var message = CreateDeleteRequest(libraryName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 202:
                case 409:
                    return message.Response;
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetRequest(string libraryName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(endpoint, false);
            uri.AppendPath("/libraries/", false);
            uri.AppendPath(libraryName, true);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Get Library. </summary>
        /// <param name="libraryName"> file name to upload. Minimum length of the filename should be 1 excluding the extension length. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="libraryName"/> is null. </exception>
        public async Task<Response<LibraryResource>> GetAsync(string libraryName, CancellationToken cancellationToken = default)
        {
            if (libraryName == null)
            {
                throw new ArgumentNullException(nameof(libraryName));
            }

            using var message = CreateGetRequest(libraryName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        LibraryResource value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = LibraryResource.DeserializeLibraryResource(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 304:
                    return Response.FromValue<LibraryResource>(null, message.Response);
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Get Library. </summary>
        /// <param name="libraryName"> file name to upload. Minimum length of the filename should be 1 excluding the extension length. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="libraryName"/> is null. </exception>
        public Response<LibraryResource> Get(string libraryName, CancellationToken cancellationToken = default)
        {
            if (libraryName == null)
            {
                throw new ArgumentNullException(nameof(libraryName));
            }

            using var message = CreateGetRequest(libraryName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        LibraryResource value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = LibraryResource.DeserializeLibraryResource(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 304:
                    return Response.FromValue<LibraryResource>(null, message.Response);
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateCreateOrAppendRequest(string libraryName, Stream content, string comp, long? xMsBlobConditionAppendpos)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(endpoint, false);
            uri.AppendPath("/libraries/", false);
            uri.AppendPath(libraryName, true);
            uri.AppendQuery("api-version", apiVersion, true);
            if (comp != null)
            {
                uri.AppendQuery("comp", comp, true);
            }
            request.Uri = uri;
            if (xMsBlobConditionAppendpos != null)
            {
                request.Headers.Add("x-ms-blob-condition-appendpos", xMsBlobConditionAppendpos.Value);
            }
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/octet-stream");
            request.Content = RequestContent.Create(content);
            return message;
        }

        /// <summary> Creates a library with the library name. Use query param &apos;comp=appendblock&apos; to append the data to the library resource created using the create operation. </summary>
        /// <param name="libraryName"> file name to upload. Minimum length of the filename should be 1 excluding the extension length. </param>
        /// <param name="content"> Library file chunk. Use this content in with append operation. </param>
        /// <param name="comp"> If this param is specified with value appendblock, the api will append the data chunk provided in body to the library created. </param>
        /// <param name="xMsBlobConditionAppendpos"> Set this header to a byte offset at which the block is expected to be appended. The request succeeds only if the current offset matches this value. Otherwise, the request fails with the AppendPositionConditionNotMet error (HTTP status code 412 – Precondition Failed). </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="libraryName"/> or <paramref name="content"/> is null. </exception>
        public async Task<Response> CreateOrAppendAsync(string libraryName, Stream content, string comp = null, long? xMsBlobConditionAppendpos = null, CancellationToken cancellationToken = default)
        {
            if (libraryName == null)
            {
                throw new ArgumentNullException(nameof(libraryName));
            }
            if (content == null)
            {
                throw new ArgumentNullException(nameof(content));
            }

            using var message = CreateCreateOrAppendRequest(libraryName, content, comp, xMsBlobConditionAppendpos);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 201:
                case 202:
                case 412:
                    return message.Response;
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Creates a library with the library name. Use query param &apos;comp=appendblock&apos; to append the data to the library resource created using the create operation. </summary>
        /// <param name="libraryName"> file name to upload. Minimum length of the filename should be 1 excluding the extension length. </param>
        /// <param name="content"> Library file chunk. Use this content in with append operation. </param>
        /// <param name="comp"> If this param is specified with value appendblock, the api will append the data chunk provided in body to the library created. </param>
        /// <param name="xMsBlobConditionAppendpos"> Set this header to a byte offset at which the block is expected to be appended. The request succeeds only if the current offset matches this value. Otherwise, the request fails with the AppendPositionConditionNotMet error (HTTP status code 412 – Precondition Failed). </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="libraryName"/> or <paramref name="content"/> is null. </exception>
        public Response CreateOrAppend(string libraryName, Stream content, string comp = null, long? xMsBlobConditionAppendpos = null, CancellationToken cancellationToken = default)
        {
            if (libraryName == null)
            {
                throw new ArgumentNullException(nameof(libraryName));
            }
            if (content == null)
            {
                throw new ArgumentNullException(nameof(content));
            }

            using var message = CreateCreateOrAppendRequest(libraryName, content, comp, xMsBlobConditionAppendpos);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 201:
                case 202:
                case 412:
                    return message.Response;
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListNextPageRequest(string nextLink)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(endpoint, false);
            uri.AppendRawNextLink(nextLink, false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Lists Library. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/> is null. </exception>
        public async Task<Response<LibraryListResponse>> ListNextPageAsync(string nextLink, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }

            using var message = CreateListNextPageRequest(nextLink);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        LibraryListResponse value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = LibraryListResponse.DeserializeLibraryListResponse(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Lists Library. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/> is null. </exception>
        public Response<LibraryListResponse> ListNextPage(string nextLink, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }

            using var message = CreateListNextPageRequest(nextLink);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        LibraryListResponse value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = LibraryListResponse.DeserializeLibraryListResponse(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }
    }
}
