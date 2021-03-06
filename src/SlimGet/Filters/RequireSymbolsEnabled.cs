// This file is a part of SlimGet project.
//
// Copyright 2019 Emzi0767
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using SlimGet.Data.Configuration;

namespace SlimGet.Filters
{
    public class RequireSymbolsEnabled : IResourceFilter
    {
        private PackageStorageConfiguration Configuration { get; }
        private ILogger<RequireSymbolsEnabled> Logger { get; }

        public RequireSymbolsEnabled(IOptions<StorageConfiguration> scfg, ILoggerFactory logger)
        {
            this.Configuration = scfg.Value.Packages;
            this.Logger = logger.CreateLogger<RequireSymbolsEnabled>();
        }

        public void OnResourceExecuted(ResourceExecutedContext context)
        { }

        public void OnResourceExecuting(ResourceExecutingContext context)
        {
            if (!this.Configuration.SymbolsEnabled)
            {
                this.Logger.LogError("Attempted access to symbol storage when symbols are disabled");
                context.Result = new NotFoundResult();
            }
        }
    }
}
