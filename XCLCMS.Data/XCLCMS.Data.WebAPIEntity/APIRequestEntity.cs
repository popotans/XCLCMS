﻿using Newtonsoft.Json;
using System;
using System.Runtime.Serialization;

namespace XCLCMS.Data.WebAPIEntity
{
    /// <summary>
    /// web api request实体
    /// </summary>
    [Serializable]
    [DataContract]
    public class APIRequestEntity<T> where T : new()
    {
        /// <summary>
        /// token
        /// </summary>
        [JsonIgnore]
        [DataMember]
        public string UserToken { get; set; }

        /// <summary>
        /// 来源ip
        /// </summary>
        [JsonIgnore]
        [DataMember]
        public string ClientIP { get; set; }

        /// <summary>
        /// 来源url
        /// </summary>
        [JsonIgnore]
        [DataMember]
        public string Url { get; set; }

        /// <summary>
        /// 请求ID
        /// </summary>
        [JsonIgnore]
        [DataMember]
        public string RequestID { get; } = Guid.NewGuid().ToString("N");

        /// <summary>
        /// request的数据
        /// </summary>
        [DataMember]
        public T Data { get; set; }
    }
}