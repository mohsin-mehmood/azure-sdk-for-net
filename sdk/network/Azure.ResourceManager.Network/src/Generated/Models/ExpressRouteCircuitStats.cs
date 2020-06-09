// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Contains stats associated with the peering. </summary>
    public partial class ExpressRouteCircuitStats
    {
        /// <summary> Initializes a new instance of ExpressRouteCircuitStats. </summary>
        public ExpressRouteCircuitStats()
        {
        }

        /// <summary> Initializes a new instance of ExpressRouteCircuitStats. </summary>
        /// <param name="primarybytesIn"> The Primary BytesIn of the peering. </param>
        /// <param name="primarybytesOut"> The primary BytesOut of the peering. </param>
        /// <param name="secondarybytesIn"> The secondary BytesIn of the peering. </param>
        /// <param name="secondarybytesOut"> The secondary BytesOut of the peering. </param>
        internal ExpressRouteCircuitStats(long? primarybytesIn, long? primarybytesOut, long? secondarybytesIn, long? secondarybytesOut)
        {
            PrimarybytesIn = primarybytesIn;
            PrimarybytesOut = primarybytesOut;
            SecondarybytesIn = secondarybytesIn;
            SecondarybytesOut = secondarybytesOut;
        }

        /// <summary> The Primary BytesIn of the peering. </summary>
        public long? PrimarybytesIn { get; set; }
        /// <summary> The primary BytesOut of the peering. </summary>
        public long? PrimarybytesOut { get; set; }
        /// <summary> The secondary BytesIn of the peering. </summary>
        public long? SecondarybytesIn { get; set; }
        /// <summary> The secondary BytesOut of the peering. </summary>
        public long? SecondarybytesOut { get; set; }
    }
}