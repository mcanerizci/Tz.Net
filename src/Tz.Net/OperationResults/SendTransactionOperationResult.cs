﻿using Newtonsoft.Json.Linq;

namespace TezosSharp
{
    public class SendTransactionOperationResult : OperationResult
    {
        public SendTransactionOperationResult() { }

        public SendTransactionOperationResult(JToken data) : base(data) { }

        public string Status { get; internal set; } = "unknown";
        public string ConsumedGas { get; internal set; } = "0";
    }
}