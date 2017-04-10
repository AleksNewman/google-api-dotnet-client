// Licensed under the Apache License, Version 2.0 (the "License"); you may not use this file except in compliance with
// the License. You may obtain a copy of the License at
//
// http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software distributed under the License is distributed on
// an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. See the License for the
// specific language governing permissions and limitations under the License.

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by google-apis-code-generator 1.5.1
//     C# generator version: 1.25.0
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

/**
 * \brief
 *   TaskQueue API Version v1beta1
 *
 * \section ApiInfo API Version Information
 *    <table>
 *      <tr><th>API
 *          <td><a href='https://developers.google.com/appengine/docs/python/taskqueue/rest'>TaskQueue API</a>
 *      <tr><th>API Version<td>v1beta1
 *      <tr><th>API Rev<td>20160428 (483)
 *      <tr><th>API Docs
 *          <td><a href='https://developers.google.com/appengine/docs/python/taskqueue/rest'>
 *              https://developers.google.com/appengine/docs/python/taskqueue/rest</a>
 *      <tr><th>Discovery Name<td>taskqueue
 *    </table>
 *
 * \section ForMoreInfo For More Information
 *
 * The complete API documentation for using TaskQueue API can be found at
 * <a href='https://developers.google.com/appengine/docs/python/taskqueue/rest'>https://developers.google.com/appengine/docs/python/taskqueue/rest</a>.
 *
 * For more information about the Google APIs Client Library for .NET, see
 * <a href='https://developers.google.com/api-client-library/dotnet/get_started'>
 * https://developers.google.com/api-client-library/dotnet/get_started</a>
 */

namespace Google.Apis.Taskqueue.v1beta1
{
    /// <summary>The Taskqueue Service.</summary>
    public class TaskqueueService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1beta1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed =
            Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public TaskqueueService() :
            this(new Google.Apis.Services.BaseClientService.Initializer()) {}

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public TaskqueueService(Google.Apis.Services.BaseClientService.Initializer initializer)
            : base(initializer)
        {
            taskqueues = new TaskqueuesResource(this);
            tasks = new TasksResource(this);
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features
        {
            get { return new string[0]; }
        }

        /// <summary>Gets the service name.</summary>
        public override string Name
        {
            get { return "taskqueue"; }
        }

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri
        {
            get { return "https://www.googleapis.com/taskqueue/v1beta1/projects/"; }
        }

        /// <summary>Gets the service base path.</summary>
        public override string BasePath
        {
            get { return "taskqueue/v1beta1/projects/"; }
        }

        #if !NET40
        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri
        {
            get { return "https://www.googleapis.com/batch"; }
        }

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath
        {
            get { return "batch"; }
        }
        #endif

        /// <summary>Available OAuth 2.0 scopes for use with the TaskQueue API.</summary>
        public class Scope
        {
            /// <summary>Manage your Tasks and Taskqueues</summary>
            public static string Taskqueue = "https://www.googleapis.com/auth/taskqueue";

            /// <summary>Consume Tasks from your Taskqueues</summary>
            public static string TaskqueueConsumer = "https://www.googleapis.com/auth/taskqueue.consumer";

        }



        private readonly TaskqueuesResource taskqueues;

        /// <summary>Gets the Taskqueues resource.</summary>
        public virtual TaskqueuesResource Taskqueues
        {
            get { return taskqueues; }
        }

        private readonly TasksResource tasks;

        /// <summary>Gets the Tasks resource.</summary>
        public virtual TasksResource Tasks
        {
            get { return tasks; }
        }
    }

    ///<summary>A base abstract class for Taskqueue requests.</summary>
    public abstract class TaskqueueBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        ///<summary>Constructs a new TaskqueueBaseServiceRequest instance.</summary>
        protected TaskqueueBaseServiceRequest(Google.Apis.Services.IClientService service)
            : base(service)
        {
        }

        /// <summary>Data format for the response.</summary>
        /// [default: json]
        [Google.Apis.Util.RequestParameterAttribute("alt", Google.Apis.Util.RequestParameterType.Query)]
        public virtual System.Nullable<AltEnum> Alt { get; set; }

        /// <summary>Data format for the response.</summary>
        public enum AltEnum
        {
            /// <summary>Responses with Content-Type of application/json</summary>
            [Google.Apis.Util.StringValueAttribute("json")]
            Json,
        }

        /// <summary>Selector specifying which fields to include in a partial response.</summary>
        [Google.Apis.Util.RequestParameterAttribute("fields", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string Fields { get; set; }

        /// <summary>API key. Your API key identifies your project and provides you with API access, quota, and reports.
        /// Required unless you provide an OAuth 2.0 token.</summary>
        [Google.Apis.Util.RequestParameterAttribute("key", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string Key { get; set; }

        /// <summary>OAuth 2.0 token for the current user.</summary>
        [Google.Apis.Util.RequestParameterAttribute("oauth_token", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string OauthToken { get; set; }

        /// <summary>Returns response with indentations and line breaks.</summary>
        /// [default: true]
        [Google.Apis.Util.RequestParameterAttribute("prettyPrint", Google.Apis.Util.RequestParameterType.Query)]
        public virtual System.Nullable<bool> PrettyPrint { get; set; }

        /// <summary>Available to use for quota purposes for server-side applications. Can be any arbitrary string
        /// assigned to a user, but should not exceed 40 characters. Overrides userIp if both are provided.</summary>
        [Google.Apis.Util.RequestParameterAttribute("quotaUser", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string QuotaUser { get; set; }

        /// <summary>IP address of the site where the request originates. Use this if you want to enforce per-user
        /// limits.</summary>
        [Google.Apis.Util.RequestParameterAttribute("userIp", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string UserIp { get; set; }

        /// <summary>Initializes Taskqueue parameter list.</summary>
        protected override void InitParameters()
        {
            base.InitParameters();

            RequestParameters.Add(
                "alt", new Google.Apis.Discovery.Parameter
                {
                    Name = "alt",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "json",
                    Pattern = null,
                });
            RequestParameters.Add(
                "fields", new Google.Apis.Discovery.Parameter
                {
                    Name = "fields",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            RequestParameters.Add(
                "key", new Google.Apis.Discovery.Parameter
                {
                    Name = "key",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            RequestParameters.Add(
                "oauth_token", new Google.Apis.Discovery.Parameter
                {
                    Name = "oauth_token",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            RequestParameters.Add(
                "prettyPrint", new Google.Apis.Discovery.Parameter
                {
                    Name = "prettyPrint",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "true",
                    Pattern = null,
                });
            RequestParameters.Add(
                "quotaUser", new Google.Apis.Discovery.Parameter
                {
                    Name = "quotaUser",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            RequestParameters.Add(
                "userIp", new Google.Apis.Discovery.Parameter
                {
                    Name = "userIp",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
        }
    }

    /// <summary>The "taskqueues" collection of methods.</summary>
    public class TaskqueuesResource
    {
        private const string Resource = "taskqueues";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public TaskqueuesResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;

        }


        /// <summary>Get detailed information about a TaskQueue.</summary>
        /// <param name="project">The project under which the queue lies.</param>
        /// <param name="taskqueue">The id of the
        /// taskqueue to get the properties of.</param>
        public virtual GetRequest Get(string project, string taskqueue)
        {
            return new GetRequest(service, project, taskqueue);
        }

        /// <summary>Get detailed information about a TaskQueue.</summary>
        public class GetRequest : TaskqueueBaseServiceRequest<Google.Apis.Taskqueue.v1beta1.Data.TaskQueue>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string project, string taskqueue)
                : base(service)
            {
                Project = project;
                Taskqueue = taskqueue;
                InitParameters();
            }


            /// <summary>The project under which the queue lies.</summary>
            [Google.Apis.Util.RequestParameterAttribute("project", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Project { get; private set; }

            /// <summary>The id of the taskqueue to get the properties of.</summary>
            [Google.Apis.Util.RequestParameterAttribute("taskqueue", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Taskqueue { get; private set; }

            /// <summary>Whether to get stats. Optional.</summary>
            [Google.Apis.Util.RequestParameterAttribute("getStats", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> GetStats { get; set; }


            ///<summary>Gets the method name.</summary>
            public override string MethodName
            {
                get { return "get"; }
            }

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod
            {
                get { return "GET"; }
            }

            ///<summary>Gets the REST path.</summary>
            public override string RestPath
            {
                get { return "{project}/taskqueues/{taskqueue}"; }
            }

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "project", new Google.Apis.Discovery.Parameter
                    {
                        Name = "project",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "taskqueue", new Google.Apis.Discovery.Parameter
                    {
                        Name = "taskqueue",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "getStats", new Google.Apis.Discovery.Parameter
                    {
                        Name = "getStats",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
            }

        }
    }

    /// <summary>The "tasks" collection of methods.</summary>
    public class TasksResource
    {
        private const string Resource = "tasks";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public TasksResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;

        }


        /// <summary>Delete a task from a TaskQueue.</summary>
        /// <param name="project">The project under which the queue lies.</param>
        /// <param name="taskqueue">The taskqueue
        /// to delete a task from.</param>
        /// <param name="task">The id of the task to delete.</param>
        public virtual DeleteRequest Delete(string project, string taskqueue, string task)
        {
            return new DeleteRequest(service, project, taskqueue, task);
        }

        /// <summary>Delete a task from a TaskQueue.</summary>
        public class DeleteRequest : TaskqueueBaseServiceRequest<string>
        {
            /// <summary>Constructs a new Delete request.</summary>
            public DeleteRequest(Google.Apis.Services.IClientService service, string project, string taskqueue, string task)
                : base(service)
            {
                Project = project;
                Taskqueue = taskqueue;
                Task = task;
                InitParameters();
            }


            /// <summary>The project under which the queue lies.</summary>
            [Google.Apis.Util.RequestParameterAttribute("project", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Project { get; private set; }

            /// <summary>The taskqueue to delete a task from.</summary>
            [Google.Apis.Util.RequestParameterAttribute("taskqueue", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Taskqueue { get; private set; }

            /// <summary>The id of the task to delete.</summary>
            [Google.Apis.Util.RequestParameterAttribute("task", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Task { get; private set; }


            ///<summary>Gets the method name.</summary>
            public override string MethodName
            {
                get { return "delete"; }
            }

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod
            {
                get { return "DELETE"; }
            }

            ///<summary>Gets the REST path.</summary>
            public override string RestPath
            {
                get { return "{project}/taskqueues/{taskqueue}/tasks/{task}"; }
            }

            /// <summary>Initializes Delete parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "project", new Google.Apis.Discovery.Parameter
                    {
                        Name = "project",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "taskqueue", new Google.Apis.Discovery.Parameter
                    {
                        Name = "taskqueue",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "task", new Google.Apis.Discovery.Parameter
                    {
                        Name = "task",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
            }

        }

        /// <summary>Get a particular task from a TaskQueue.</summary>
        /// <param name="project">The project under which the queue lies.</param>
        /// <param name="taskqueue">The taskqueue
        /// in which the task belongs.</param>
        /// <param name="task">The task to get properties of.</param>
        public virtual GetRequest Get(string project, string taskqueue, string task)
        {
            return new GetRequest(service, project, taskqueue, task);
        }

        /// <summary>Get a particular task from a TaskQueue.</summary>
        public class GetRequest : TaskqueueBaseServiceRequest<Google.Apis.Taskqueue.v1beta1.Data.Task>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string project, string taskqueue, string task)
                : base(service)
            {
                Project = project;
                Taskqueue = taskqueue;
                Task = task;
                InitParameters();
            }


            /// <summary>The project under which the queue lies.</summary>
            [Google.Apis.Util.RequestParameterAttribute("project", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Project { get; private set; }

            /// <summary>The taskqueue in which the task belongs.</summary>
            [Google.Apis.Util.RequestParameterAttribute("taskqueue", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Taskqueue { get; private set; }

            /// <summary>The task to get properties of.</summary>
            [Google.Apis.Util.RequestParameterAttribute("task", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Task { get; private set; }


            ///<summary>Gets the method name.</summary>
            public override string MethodName
            {
                get { return "get"; }
            }

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod
            {
                get { return "GET"; }
            }

            ///<summary>Gets the REST path.</summary>
            public override string RestPath
            {
                get { return "{project}/taskqueues/{taskqueue}/tasks/{task}"; }
            }

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "project", new Google.Apis.Discovery.Parameter
                    {
                        Name = "project",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "taskqueue", new Google.Apis.Discovery.Parameter
                    {
                        Name = "taskqueue",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "task", new Google.Apis.Discovery.Parameter
                    {
                        Name = "task",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
            }

        }

        /// <summary>Lease 1 or more tasks from a TaskQueue.</summary>
        /// <param name="project">The project under which the queue lies.</param>
        /// <param name="taskqueue">The taskqueue
        /// to lease a task from.</param>
        /// <param name="numTasks">The number of tasks to lease.</param>
        /// <param
        /// name="leaseSecs">The lease in seconds.</param>
        public virtual LeaseRequest Lease(string project, string taskqueue, int numTasks, int leaseSecs)
        {
            return new LeaseRequest(service, project, taskqueue, numTasks, leaseSecs);
        }

        /// <summary>Lease 1 or more tasks from a TaskQueue.</summary>
        public class LeaseRequest : TaskqueueBaseServiceRequest<Google.Apis.Taskqueue.v1beta1.Data.Tasks>
        {
            /// <summary>Constructs a new Lease request.</summary>
            public LeaseRequest(Google.Apis.Services.IClientService service, string project, string taskqueue, int numTasks, int leaseSecs)
                : base(service)
            {
                Project = project;
                Taskqueue = taskqueue;
                NumTasks = numTasks;
                LeaseSecs = leaseSecs;
                InitParameters();
            }


            /// <summary>The project under which the queue lies.</summary>
            [Google.Apis.Util.RequestParameterAttribute("project", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Project { get; private set; }

            /// <summary>The taskqueue to lease a task from.</summary>
            [Google.Apis.Util.RequestParameterAttribute("taskqueue", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Taskqueue { get; private set; }

            /// <summary>The number of tasks to lease.</summary>
            [Google.Apis.Util.RequestParameterAttribute("numTasks", Google.Apis.Util.RequestParameterType.Query)]
            public virtual int NumTasks { get; private set; }

            /// <summary>The lease in seconds.</summary>
            [Google.Apis.Util.RequestParameterAttribute("leaseSecs", Google.Apis.Util.RequestParameterType.Query)]
            public virtual int LeaseSecs { get; private set; }


            ///<summary>Gets the method name.</summary>
            public override string MethodName
            {
                get { return "lease"; }
            }

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod
            {
                get { return "POST"; }
            }

            ///<summary>Gets the REST path.</summary>
            public override string RestPath
            {
                get { return "{project}/taskqueues/{taskqueue}/tasks/lease"; }
            }

            /// <summary>Initializes Lease parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "project", new Google.Apis.Discovery.Parameter
                    {
                        Name = "project",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "taskqueue", new Google.Apis.Discovery.Parameter
                    {
                        Name = "taskqueue",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "numTasks", new Google.Apis.Discovery.Parameter
                    {
                        Name = "numTasks",
                        IsRequired = true,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "leaseSecs", new Google.Apis.Discovery.Parameter
                    {
                        Name = "leaseSecs",
                        IsRequired = true,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
            }

        }

        /// <summary>List Tasks in a TaskQueue</summary>
        /// <param name="project">The project under which the queue lies.</param>
        /// <param name="taskqueue">The id of the
        /// taskqueue to list tasks from.</param>
        public virtual ListRequest List(string project, string taskqueue)
        {
            return new ListRequest(service, project, taskqueue);
        }

        /// <summary>List Tasks in a TaskQueue</summary>
        public class ListRequest : TaskqueueBaseServiceRequest<Google.Apis.Taskqueue.v1beta1.Data.Tasks2>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service, string project, string taskqueue)
                : base(service)
            {
                Project = project;
                Taskqueue = taskqueue;
                InitParameters();
            }


            /// <summary>The project under which the queue lies.</summary>
            [Google.Apis.Util.RequestParameterAttribute("project", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Project { get; private set; }

            /// <summary>The id of the taskqueue to list tasks from.</summary>
            [Google.Apis.Util.RequestParameterAttribute("taskqueue", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Taskqueue { get; private set; }


            ///<summary>Gets the method name.</summary>
            public override string MethodName
            {
                get { return "list"; }
            }

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod
            {
                get { return "GET"; }
            }

            ///<summary>Gets the REST path.</summary>
            public override string RestPath
            {
                get { return "{project}/taskqueues/{taskqueue}/tasks"; }
            }

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "project", new Google.Apis.Discovery.Parameter
                    {
                        Name = "project",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "taskqueue", new Google.Apis.Discovery.Parameter
                    {
                        Name = "taskqueue",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
            }

        }
    }
}

namespace Google.Apis.Taskqueue.v1beta1.Data
{    

    public class Task : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Time (in seconds since the epoch) at which the task was enqueued.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enqueueTimestamp")]
        public virtual System.Nullable<long> EnqueueTimestamp { get; set; } 

        /// <summary>Name of the task.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; } 

        /// <summary>The kind of object returned, in this case set to task.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; } 

        /// <summary>Time (in seconds since the epoch) at which the task lease will expire. This value is 0 if the task
        /// isnt currently leased out to a worker.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("leaseTimestamp")]
        public virtual System.Nullable<long> LeaseTimestamp { get; set; } 

        /// <summary>A bag of bytes which is the task payload. The payload on the JSON side is always Base64
        /// encoded.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("payloadBase64")]
        public virtual string PayloadBase64 { get; set; } 

        /// <summary>Name of the queue that the task is in.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("queueName")]
        public virtual string QueueName { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class TaskQueue : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>ACLs that are applicable to this TaskQueue object.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("acl")]
        public virtual TaskQueue.AclData Acl { get; set; } 

        /// <summary>Name of the taskqueue.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; } 

        /// <summary>The kind of REST object returned, in this case taskqueue.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; } 

        /// <summary>The number of times we should lease out tasks before giving up on them. If unset we lease them out
        /// forever until a worker deletes the task.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxLeases")]
        public virtual System.Nullable<int> MaxLeases { get; set; } 

        /// <summary>Statistics for the TaskQueue object in question.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stats")]
        public virtual TaskQueue.StatsData Stats { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
        

        /// <summary>ACLs that are applicable to this TaskQueue object.</summary>
        public class AclData
        {
            /// <summary>Email addresses of users who are "admins" of the TaskQueue. This means they can control the
            /// queue, eg set ACLs for the queue.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("adminEmails")]
            public virtual System.Collections.Generic.IList<string> AdminEmails { get; set; } 

            /// <summary>Email addresses of users who can "consume" tasks from the TaskQueue. This means they can
            /// Dequeue and Delete tasks from the queue.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("consumerEmails")]
            public virtual System.Collections.Generic.IList<string> ConsumerEmails { get; set; } 

            /// <summary>Email addresses of users who can "produce" tasks into the TaskQueue. This means they can Insert
            /// tasks into the queue.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("producerEmails")]
            public virtual System.Collections.Generic.IList<string> ProducerEmails { get; set; } 

        }    

        /// <summary>Statistics for the TaskQueue object in question.</summary>
        public class StatsData
        {
            /// <summary>Number of tasks leased in the last hour.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("leasedLastHour")]
            public virtual System.Nullable<long> LeasedLastHour { get; set; } 

            /// <summary>Number of tasks leased in the last minute.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("leasedLastMinute")]
            public virtual System.Nullable<long> LeasedLastMinute { get; set; } 

            /// <summary>The timestamp (in seconds since the epoch) of the oldest unfinished task.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("oldestTask")]
            public virtual System.Nullable<long> OldestTask { get; set; } 

            /// <summary>Number of tasks in the queue.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("totalTasks")]
            public virtual System.Nullable<int> TotalTasks { get; set; } 

        }
    }    

    public class Tasks : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The actual list of tasks returned as a result of the lease operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("items")]
        public virtual System.Collections.Generic.IList<Task> Items { get; set; } 

        /// <summary>The kind of object returned, a list of tasks.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class Tasks2 : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The actual list of tasks currently active in the TaskQueue.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("items")]
        public virtual System.Collections.Generic.IList<Task> Items { get; set; } 

        /// <summary>The kind of object returned, a list of tasks.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
