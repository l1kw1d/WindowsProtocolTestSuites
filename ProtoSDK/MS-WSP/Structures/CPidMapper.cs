﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;

namespace Microsoft.Protocols.TestTools.StackSdk.FileAccessService.WSP
{
    /// <summary>
    /// The CPidMapper structure contains an array of property specifications and serves to map from a property offset to a full property specification.
    /// The more compact property offsets are used to name properties in other parts of the protocol.
    /// Since offsets are more compact, they allow shorter property references in other parts of the protocol.
    /// </summary>
    public struct CPidMapper : IWSPObject
    {
        /// <summary>
        /// A 32-bit unsigned integer containing the number of elements in the aPropSpec array.
        /// </summary>
        public UInt32 count;

        /// <summary>
        /// Array of CFullPropSpec structures indicating the properties to return.
        /// </summary>
        public CFullPropSpec[] aPropSpec;

        public void ToBytes(WSPBuffer buffer)
        {
            buffer.Add(count);

            foreach (var property in aPropSpec)
            {
                property.ToBytes(buffer);
            }
        }
    }
}
