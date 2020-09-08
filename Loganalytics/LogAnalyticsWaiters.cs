/*
 * Copyright (c) 2020, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.

using System.Linq;
using Oci.Common.Waiters;
using Oci.LoganalyticsService.Models;
using Oci.LoganalyticsService.Requests;
using Oci.LoganalyticsService.Responses;

namespace Oci.LoganalyticsService
{
    /// <summary>
    /// Contains collection of helper methods to produce Oci.Common.Waiters for different resources of LogAnalytics.
    /// </summary>
    public class LogAnalyticsWaiters
    {
        private readonly LogAnalyticsClient client;

        public  LogAnalyticsWaiters(LogAnalyticsClient client)
        {
            this.client = client;
        }

        /// <summary>
        /// Creates a waiter using default wait configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetLogAnalyticsEntityRequest, GetLogAnalyticsEntityResponse> ForLogAnalyticsEntity(GetLogAnalyticsEntityRequest request, params EntityLifecycleStates[] targetStates)
        {
            return this.ForLogAnalyticsEntity(request, WaiterConfiguration.DefaultWaiterConfiguration, targetStates);
        }

        /// <summary>
        /// Creates a waiter using the provided configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="config">Wait Configuration</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetLogAnalyticsEntityRequest, GetLogAnalyticsEntityResponse> ForLogAnalyticsEntity(GetLogAnalyticsEntityRequest request, WaiterConfiguration config, params EntityLifecycleStates[] targetStates)
        {
            var agent = new WaiterAgent<GetLogAnalyticsEntityRequest, GetLogAnalyticsEntityResponse>(
                request,
                request => client.GetLogAnalyticsEntity(request),
                response => targetStates.Contains(response.LogAnalyticsEntity.LifecycleState.Value),
                targetStates.Contains(EntityLifecycleStates.Deleted)
            );
            return new Waiter<GetLogAnalyticsEntityRequest, GetLogAnalyticsEntityResponse>(config, agent);
        }
        /// <summary>
        /// Creates a waiter using default wait configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetLogAnalyticsEntityTypeRequest, GetLogAnalyticsEntityTypeResponse> ForLogAnalyticsEntityType(GetLogAnalyticsEntityTypeRequest request, params EntityLifecycleStates[] targetStates)
        {
            return this.ForLogAnalyticsEntityType(request, WaiterConfiguration.DefaultWaiterConfiguration, targetStates);
        }

        /// <summary>
        /// Creates a waiter using the provided configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="config">Wait Configuration</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetLogAnalyticsEntityTypeRequest, GetLogAnalyticsEntityTypeResponse> ForLogAnalyticsEntityType(GetLogAnalyticsEntityTypeRequest request, WaiterConfiguration config, params EntityLifecycleStates[] targetStates)
        {
            var agent = new WaiterAgent<GetLogAnalyticsEntityTypeRequest, GetLogAnalyticsEntityTypeResponse>(
                request,
                request => client.GetLogAnalyticsEntityType(request),
                response => targetStates.Contains(response.LogAnalyticsEntityType.LifecycleState.Value),
                targetStates.Contains(EntityLifecycleStates.Deleted)
            );
            return new Waiter<GetLogAnalyticsEntityTypeRequest, GetLogAnalyticsEntityTypeResponse>(config, agent);
        }
        /// <summary>
        /// Creates a waiter using default wait configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetLogAnalyticsObjectCollectionRuleRequest, GetLogAnalyticsObjectCollectionRuleResponse> ForLogAnalyticsObjectCollectionRule(GetLogAnalyticsObjectCollectionRuleRequest request, params LogAnalyticsObjectCollectionRule.LifecycleStateEnum[] targetStates)
        {
            return this.ForLogAnalyticsObjectCollectionRule(request, WaiterConfiguration.DefaultWaiterConfiguration, targetStates);
        }

        /// <summary>
        /// Creates a waiter using the provided configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="config">Wait Configuration</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetLogAnalyticsObjectCollectionRuleRequest, GetLogAnalyticsObjectCollectionRuleResponse> ForLogAnalyticsObjectCollectionRule(GetLogAnalyticsObjectCollectionRuleRequest request, WaiterConfiguration config, params LogAnalyticsObjectCollectionRule.LifecycleStateEnum[] targetStates)
        {
            var agent = new WaiterAgent<GetLogAnalyticsObjectCollectionRuleRequest, GetLogAnalyticsObjectCollectionRuleResponse>(
                request,
                request => client.GetLogAnalyticsObjectCollectionRule(request),
                response => targetStates.Contains(response.LogAnalyticsObjectCollectionRule.LifecycleState.Value),
                targetStates.Contains(LogAnalyticsObjectCollectionRule.LifecycleStateEnum.Deleted)
            );
            return new Waiter<GetLogAnalyticsObjectCollectionRuleRequest, GetLogAnalyticsObjectCollectionRuleResponse>(config, agent);
        }
        /// <summary>
        /// Creates a waiter using default wait configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetScheduledTaskRequest, GetScheduledTaskResponse> ForScheduledTask(GetScheduledTaskRequest request, params ScheduledTask.LifecycleStateEnum[] targetStates)
        {
            return this.ForScheduledTask(request, WaiterConfiguration.DefaultWaiterConfiguration, targetStates);
        }

        /// <summary>
        /// Creates a waiter using the provided configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="config">Wait Configuration</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetScheduledTaskRequest, GetScheduledTaskResponse> ForScheduledTask(GetScheduledTaskRequest request, WaiterConfiguration config, params ScheduledTask.LifecycleStateEnum[] targetStates)
        {
            var agent = new WaiterAgent<GetScheduledTaskRequest, GetScheduledTaskResponse>(
                request,
                request => client.GetScheduledTask(request),
                response => targetStates.Contains(response.ScheduledTask.LifecycleState.Value),
                targetStates.Contains(ScheduledTask.LifecycleStateEnum.Deleted)
            );
            return new Waiter<GetScheduledTaskRequest, GetScheduledTaskResponse>(config, agent);
        }
        /// <summary>
        /// Creates a waiter using default wait configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetWorkRequestRequest, GetWorkRequestResponse> ForWorkRequest(GetWorkRequestRequest request, params OperationStatus[] targetStates)
        {
            return this.ForWorkRequest(request, WaiterConfiguration.DefaultWaiterConfiguration, targetStates);
        }

        /// <summary>
        /// Creates a waiter using the provided configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="config">Wait Configuration</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetWorkRequestRequest, GetWorkRequestResponse> ForWorkRequest(GetWorkRequestRequest request, WaiterConfiguration config, params OperationStatus[] targetStates)
        {
            var agent = new WaiterAgent<GetWorkRequestRequest, GetWorkRequestResponse>(
                request,
                request => client.GetWorkRequest(request),
                response => targetStates.Contains(response.WorkRequest.Status.Value)
            );
            return new Waiter<GetWorkRequestRequest, GetWorkRequestResponse>(config, agent);
        }
    }
}
