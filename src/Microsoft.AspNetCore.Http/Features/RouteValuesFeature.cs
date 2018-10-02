// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using Microsoft.AspNetCore.Routing;

namespace Microsoft.AspNetCore.Http.Features
{
    public class RouteValuesFeature : IRouteValuesFeature
    {
        private RouteValueDictionary _routeValues;

        public RouteValueDictionary RouteValues
        {
            get
            {
                if (_routeValues == null)
                {
                    _routeValues = new RouteValueDictionary();
                }

                return _routeValues;
            }
            set => _routeValues = value;
        }
    }
}