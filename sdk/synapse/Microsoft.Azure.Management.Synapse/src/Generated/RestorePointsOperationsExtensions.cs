// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Synapse
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for RestorePointsOperations.
    /// </summary>
    public static partial class RestorePointsOperationsExtensions
    {
            /// <summary>
            /// Gets a restore point.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace
            /// </param>
            /// <param name='sqlPoolName'>
            /// SQL pool name
            /// </param>
            /// <param name='restorePointName'>
            /// The name of the restore point.
            /// </param>
            public static RestorePoint Get(this IRestorePointsOperations operations, string resourceGroupName, string workspaceName, string sqlPoolName, string restorePointName)
            {
                return operations.GetAsync(resourceGroupName, workspaceName, sqlPoolName, restorePointName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a restore point.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace
            /// </param>
            /// <param name='sqlPoolName'>
            /// SQL pool name
            /// </param>
            /// <param name='restorePointName'>
            /// The name of the restore point.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<RestorePoint> GetAsync(this IRestorePointsOperations operations, string resourceGroupName, string workspaceName, string sqlPoolName, string restorePointName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, workspaceName, sqlPoolName, restorePointName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes a restore point.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace
            /// </param>
            /// <param name='sqlPoolName'>
            /// SQL pool name
            /// </param>
            /// <param name='restorePointName'>
            /// The name of the restore point.
            /// </param>
            public static void Delete(this IRestorePointsOperations operations, string resourceGroupName, string workspaceName, string sqlPoolName, string restorePointName)
            {
                operations.DeleteAsync(resourceGroupName, workspaceName, sqlPoolName, restorePointName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes a restore point.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace
            /// </param>
            /// <param name='sqlPoolName'>
            /// SQL pool name
            /// </param>
            /// <param name='restorePointName'>
            /// The name of the restore point.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IRestorePointsOperations operations, string resourceGroupName, string workspaceName, string sqlPoolName, string restorePointName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, workspaceName, sqlPoolName, restorePointName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

    }
}
