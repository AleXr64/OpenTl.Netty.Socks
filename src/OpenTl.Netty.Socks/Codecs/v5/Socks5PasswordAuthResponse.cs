﻿/*
 * Copyright 2012 The Netty Project
 *
 * The Netty Project licenses this file to you under the Apache License,
 * version 2.0 (the "License"); you may not use this file except in compliance
 * with the License. You may obtain a copy of the License at:
 *
 *   http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS, WITHOUT
 * WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. See the
 * License for the specific language governing permissions and limitations
 * under the License.
 */

namespace OpenTl.Netty.Socks.Codecs.Socksx.v5
{
    /**
  * A SOCKS5 subnegotiation response for username-password authentication, as defined in
  * <a href="http://tools.ietf.org/html/rfc1929#section-2">the section 2, RFC1929</a>.
  */
    public interface ISocks5PasswordAuthResponse : ISocks5Message
    {
        /**
     * Returns the status of this response.
     */
        Socks5PasswordAuthStatus Status { get; }
    }
}