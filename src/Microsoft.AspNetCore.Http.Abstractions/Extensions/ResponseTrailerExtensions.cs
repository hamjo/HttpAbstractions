// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using Microsoft.AspNetCore.Http.Features;
using Microsoft.Extensions.Primitives;

namespace Microsoft.AspNetCore.Http
{
    public static class ResponseTrailerExtensions
    {
        private const string Trailer = "Trailer";

        public static void DeclareTrailer(this HttpResponse response, string trailerName)
        {
            response.Headers.AppendCommaSeparatedValues(Trailer, trailerName);
        }

        public static void AppendTrailer(this HttpResponse response, string trailerName, StringValues trailerValues)
        {
            var feature = response.HttpContext.Features.Get<IHttpResponseTrailersFeature>();
            feature?.Trailers?.Append(trailerName, trailerValues);
        }
    }
}
