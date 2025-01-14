﻿using OpenAI.ObjectModels.SharedModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace OpenAI.ObjectModels.RequestModels
{
    public class ThreadCreateRequest : IOpenAiModels.IMetaData
    {
        /// <summary>
        /// A list of messages to start the thread with.
        /// </summary>
        [JsonPropertyName("messages")]
        public List<MessageCreateRequest> Messages { get; set; }

        /// <summary>
        /// Set of 16 key-value pairs that can be attached to an object.
        /// This can be useful for storing additional information about the object in a structured format. 
        /// Keys can be a maximum of 64 characters long and values can be a maxium of 512 characters long.
        /// </summary>
        [JsonPropertyName("metadata")]
        public Dictionary<string, string> MetaData { get; set; }
    }
}
