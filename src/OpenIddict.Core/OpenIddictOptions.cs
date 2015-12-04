﻿/*
 * Licensed under the Apache License, Version 2.0 (http://www.apache.org/licenses/LICENSE-2.0)
 * See https://github.com/openiddict/core for more information concerning
 * the license and the contributors participating to this project.
 */

using AspNet.Security.OpenIdConnect.Server;

namespace OpenIddict {
    public class OpenIddictOptions : OpenIdConnectServerOptions {
        public OpenIddictOptions() {
            AuthenticationScheme = OpenIddictDefaults.AuthenticationScheme;
            ApplicationCanDisplayErrors = true;
        }
    }
}