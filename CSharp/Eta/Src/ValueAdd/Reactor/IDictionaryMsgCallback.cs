﻿/*|-----------------------------------------------------------------------------
 *|            This source code is provided under the Apache 2.0 license      --
 *|  and is provided AS IS with no warranty or guarantee of fit for purpose.  --
 *|                See the project's LICENSE.md for details.                  --
 *|           Copyright (C) 2022-2023 Refinitiv. All rights reserved.         s--
 *|-----------------------------------------------------------------------------
 */

namespace LSEG.Eta.ValueAdd.Reactor
{
    /// <summary>
    /// The RDM dictionary message callback 
    /// is used to communicate dictionary message events to the application.
    /// </summary>
    public interface IDictionaryMsgCallback
    {
        /// <summary>
        /// A callback function that the <see cref="Reactor"/> will use 
        /// to communicate dictionary message events to the application.
        /// </summary>
        /// <param name="msgEvent">A ReactorMsgEvent containing event information. 
        /// The ReactorMsgEvent is valid only during callback</param>
        /// <returns>A callback return code that can trigger specific 
        /// Reactor behavior based on the outcome of the callback function</returns>
        public ReactorCallbackReturnCode RdmDictionaryMsgCallback(RDMDictionaryMsgEvent msgEvent);
    }
}