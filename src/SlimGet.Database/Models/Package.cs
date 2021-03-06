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

using System;
using System.Collections.Generic;
using System.Linq;

namespace SlimGet.Data.Database
{
    public class Package
    {
        public string Id { get; set; }
        public string IdLowercase { get; set; }
        public string Description { get; set; }
        public long DownloadCount { get; set; }
        public string Language { get; set; }
        public bool IsListed { get; set; }
        public string MinimumClientVersion { get; set; }
        public DateTime? PublishedAt { get; set; }
        public bool RequiresLicenseAcceptance { get; set; }
        public string Summary { get; set; }
        public string Title { get; set; }
        public string IconUrl { get; set; }
        public string LicenseUrl { get; set; }
        public string ProjectUrl { get; set; }
        public string RepositoryUrl { get; set; }
        public string RepositoryType { get; set; }
        public SemVerLevel SemVerLevel { get; set; }
        public string OwnerId { get; set; }
        
        public List<PackageVersion> Versions { get; set; }
        public List<PackageAuthor> Authors { get; set; }
        public List<PackageTag> Tags { get; set; }
        public User Owner { get; set; }

        public IEnumerable<string> AuthorNames => this.Authors.Select(x => x.Name);
        public IEnumerable<string> TagNames => this.Tags.Select(x => x.Tag);
    }
}
