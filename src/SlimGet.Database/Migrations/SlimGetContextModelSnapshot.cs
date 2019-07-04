// <auto-generated />

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
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using SlimGet.Services;

namespace SlimGet.Data.Database.Migrations
{
    [DbContext(typeof(SlimGetContext))]
    partial class SlimGetContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:PostgresExtension:pg_trgm", ",,")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("SlimGet.Data.Database.Package", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id");

                    b.Property<string>("Description")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("description")
                        .HasDefaultValue(null);

                    b.Property<long>("DownloadCount")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("download_count")
                        .HasDefaultValue(0L);

                    b.Property<string>("IconUrl")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("icon_url")
                        .HasDefaultValue(null);

                    b.Property<string>("IdLowercase")
                        .IsRequired()
                        .HasColumnName("id_lowercase");

                    b.Property<bool>("IsListed")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("listed")
                        .HasDefaultValue(true);

                    b.Property<string>("Language")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("language")
                        .HasDefaultValue(null);

                    b.Property<string>("LicenseUrl")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("license_url")
                        .HasDefaultValue(null);

                    b.Property<string>("MinimumClientVersion")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("min_client_version")
                        .HasDefaultValue(null);

                    b.Property<string>("OwnerId")
                        .IsRequired()
                        .HasColumnName("owner_id");

                    b.Property<string>("ProjectUrl")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("project_url")
                        .HasDefaultValue(null);

                    b.Property<DateTime?>("PublishedAt")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnName("published_at")
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValueSql("now()");

                    b.Property<string>("RepositoryType")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("repository_type")
                        .HasDefaultValue(null);

                    b.Property<string>("RepositoryUrl")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("repository_url")
                        .HasDefaultValue(null);

                    b.Property<bool>("RequiresLicenseAcceptance")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("require_license_acceptance")
                        .HasDefaultValue(false);

                    b.Property<int>("SemVerLevel")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("semver_level")
                        .HasColumnType("integer")
                        .HasDefaultValue(0);

                    b.Property<string>("Summary")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("summary")
                        .HasDefaultValue(null);

                    b.Property<string>("Title")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("title")
                        .HasDefaultValue(null);

                    b.HasKey("Id")
                        .HasName("pkey_package_id");

                    b.HasAlternateKey("IdLowercase")
                        .HasName("ukey_package_idlower");

                    b.HasIndex("IdLowercase")
                        .HasName("ix_package_idlower");

                    b.HasIndex("OwnerId")
                        .HasName("ix_package_owner");

                    b.ToTable("packages");
                });

            modelBuilder.Entity("SlimGet.Data.Database.PackageAuthor", b =>
                {
                    b.Property<string>("PackageId")
                        .HasColumnName("package_id");

                    b.Property<string>("Name")
                        .HasColumnName("name");

                    b.HasKey("PackageId", "Name")
                        .HasName("pkey_author");

                    b.ToTable("package_authors");
                });

            modelBuilder.Entity("SlimGet.Data.Database.PackageBinary", b =>
                {
                    b.Property<string>("PackageId")
                        .HasColumnName("package_id");

                    b.Property<string>("PackageVersion")
                        .HasColumnName("package_version");

                    b.Property<string>("Framework")
                        .HasColumnName("framework");

                    b.Property<string>("Name")
                        .HasColumnName("name");

                    b.Property<string>("Hash")
                        .IsRequired()
                        .HasColumnName("sha256_hash");

                    b.Property<long>("Length")
                        .HasColumnName("length");

                    b.HasKey("PackageId", "PackageVersion", "Framework", "Name")
                        .HasName("pkey_binary_packageid_packageversion_framework");

                    b.HasIndex("Hash")
                        .HasName("ix_binary_hash")
                        .HasAnnotation("Npgsql:IndexMethod", "hash");

                    b.ToTable("package_binaries");
                });

            modelBuilder.Entity("SlimGet.Data.Database.PackageDependency", b =>
                {
                    b.Property<string>("PackageId")
                        .HasColumnName("package_id");

                    b.Property<string>("PackageVersion")
                        .HasColumnName("package_version");

                    b.Property<string>("Id")
                        .HasColumnName("id");

                    b.Property<string>("TargetFramework")
                        .HasColumnName("target_framework");

                    b.Property<bool?>("IsMaxVersionInclusive")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnName("max_version_inclusive")
                        .HasDefaultValue(false);

                    b.Property<bool?>("IsMinVersionInclusive")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnName("min_version_inclusive")
                        .HasDefaultValue(false);

                    b.Property<string>("MaxVersion")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("max_version")
                        .HasDefaultValue(null);

                    b.Property<string>("MinVersion")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("min_version")
                        .HasDefaultValue(null);

                    b.HasKey("PackageId", "PackageVersion", "Id", "TargetFramework")
                        .HasName("pkey_dependency");

                    b.ToTable("package_dependencies");
                });

            modelBuilder.Entity("SlimGet.Data.Database.PackageFramework", b =>
                {
                    b.Property<string>("PackageId")
                        .HasColumnName("package_id");

                    b.Property<string>("PackageVersion")
                        .HasColumnName("package_version");

                    b.Property<string>("Framework")
                        .HasColumnName("framework");

                    b.HasKey("PackageId", "PackageVersion", "Framework")
                        .HasName("pkey_framework");

                    b.ToTable("package_frameworks");
                });

            modelBuilder.Entity("SlimGet.Data.Database.PackageSymbols", b =>
                {
                    b.Property<string>("PackageId")
                        .HasColumnName("package_id");

                    b.Property<string>("PackageVersion")
                        .HasColumnName("package_version");

                    b.Property<string>("Framework")
                        .HasColumnName("framework");

                    b.Property<string>("BinaryName")
                        .HasColumnName("binary_name");

                    b.Property<Guid>("Identifier")
                        .HasColumnName("id")
                        .HasColumnType("uuid");

                    b.Property<int>("Kind")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("kind")
                        .HasColumnType("integer")
                        .HasDefaultValue(0);

                    b.Property<int>("Age")
                        .HasColumnName("age");

                    b.Property<string>("Filename")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("file_name")
                        .HasDefaultValue(null);

                    b.Property<string>("Name")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("name")
                        .HasDefaultValue(null);

                    b.Property<string>("Signature")
                        .IsRequired()
                        .HasColumnName("signature");

                    b.HasKey("PackageId", "PackageVersion", "Framework", "BinaryName", "Identifier", "Kind")
                        .HasName("pkey_symbols_packageid_packageversion_framework_id_kind");

                    b.HasIndex("Identifier")
                        .HasName("ix_symbols_id")
                        .HasAnnotation("Npgsql:IndexMethod", "hash");

                    b.HasIndex("Signature")
                        .HasName("ix_symbols_sig")
                        .HasAnnotation("Npgsql:IndexMethod", "hash");

                    b.ToTable("package_symbols");
                });

            modelBuilder.Entity("SlimGet.Data.Database.PackageTag", b =>
                {
                    b.Property<string>("PackageId")
                        .HasColumnName("package_id");

                    b.Property<string>("Tag")
                        .HasColumnName("tag");

                    b.HasKey("PackageId", "Tag")
                        .HasName("pkey_tag");

                    b.ToTable("package_tags");
                });

            modelBuilder.Entity("SlimGet.Data.Database.PackageVersion", b =>
                {
                    b.Property<string>("PackageId")
                        .HasColumnName("package_id");

                    b.Property<string>("Version")
                        .HasColumnName("version");

                    b.Property<long>("DownloadCount")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("download_count")
                        .HasDefaultValue(0L);

                    b.Property<bool>("IsListed")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("listed")
                        .HasDefaultValue(true);

                    b.Property<bool>("IsPrerelase")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("prerelease")
                        .HasDefaultValue(false);

                    b.Property<string>("ManifestFilename")
                        .IsRequired()
                        .HasColumnName("manifest_filename");

                    b.Property<string>("PackageFilename")
                        .IsRequired()
                        .HasColumnName("package_filename");

                    b.Property<DateTime?>("PublishedAt")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnName("published_at")
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValueSql("now()");

                    b.Property<string>("VersionLowercase")
                        .IsRequired()
                        .HasColumnName("version_lowercase");

                    b.HasKey("PackageId", "Version")
                        .HasName("pkey_version");

                    b.HasIndex("PackageId")
                        .HasName("ix_version_packageid");

                    b.ToTable("package_versions");
                });

            modelBuilder.Entity("SlimGet.Data.Database.Token", b =>
                {
                    b.Property<Guid>("Guid")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("guid")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("IssuedAt")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnName("issued_at")
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValueSql("now()");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnName("user_id");

                    b.HasKey("Guid")
                        .HasName("pkey_token_value");

                    b.HasIndex("UserId")
                        .HasName("ix_token_owner");

                    b.ToTable("tokens");
                });

            modelBuilder.Entity("SlimGet.Data.Database.User", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id");

                    b.Property<DateTime?>("CreatedAt")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnName("created_at")
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValueSql("now()");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnName("email");

                    b.HasKey("Id")
                        .HasName("pkey_user_id");

                    b.HasAlternateKey("Email")
                        .HasName("ukey_email");

                    b.ToTable("users");
                });

            modelBuilder.Entity("SlimGet.Data.Database.Package", b =>
                {
                    b.HasOne("SlimGet.Data.Database.User", "Owner")
                        .WithMany("Packages")
                        .HasForeignKey("OwnerId")
                        .HasConstraintName("fkey_package_ownerid")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SlimGet.Data.Database.PackageAuthor", b =>
                {
                    b.HasOne("SlimGet.Data.Database.Package", "Package")
                        .WithMany("Authors")
                        .HasForeignKey("PackageId")
                        .HasConstraintName("fkey_author_packageid")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SlimGet.Data.Database.PackageBinary", b =>
                {
                    b.HasOne("SlimGet.Data.Database.PackageVersion", "Package")
                        .WithMany("Binaries")
                        .HasForeignKey("PackageId", "PackageVersion")
                        .HasConstraintName("fkey_binary_packageid_packageversion")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SlimGet.Data.Database.PackageFramework", "PackageFramework")
                        .WithMany("Binaries")
                        .HasForeignKey("PackageId", "PackageVersion", "Framework")
                        .HasConstraintName("fkey_binary_framework")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SlimGet.Data.Database.PackageDependency", b =>
                {
                    b.HasOne("SlimGet.Data.Database.PackageVersion", "Package")
                        .WithMany("Dependencies")
                        .HasForeignKey("PackageId", "PackageVersion")
                        .HasConstraintName("fkey_dependency_packageid_packageversion")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SlimGet.Data.Database.PackageFramework", b =>
                {
                    b.HasOne("SlimGet.Data.Database.PackageVersion", "Package")
                        .WithMany("Frameworks")
                        .HasForeignKey("PackageId", "PackageVersion")
                        .HasConstraintName("fkey_framework_packageid_packageversion")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SlimGet.Data.Database.PackageSymbols", b =>
                {
                    b.HasOne("SlimGet.Data.Database.PackageBinary", "Binary")
                        .WithMany("PackageSymbols")
                        .HasForeignKey("PackageId", "PackageVersion", "Framework", "BinaryName")
                        .HasConstraintName("fkey_symbols_packageid_packageversion_framework_binaryname")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SlimGet.Data.Database.PackageTag", b =>
                {
                    b.HasOne("SlimGet.Data.Database.Package", "Package")
                        .WithMany("Tags")
                        .HasForeignKey("PackageId")
                        .HasConstraintName("fkey_tag_packageid")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SlimGet.Data.Database.PackageVersion", b =>
                {
                    b.HasOne("SlimGet.Data.Database.Package", "Package")
                        .WithMany("Versions")
                        .HasForeignKey("PackageId")
                        .HasConstraintName("fkey_version_packageid")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SlimGet.Data.Database.Token", b =>
                {
                    b.HasOne("SlimGet.Data.Database.User", "User")
                        .WithMany("Tokens")
                        .HasForeignKey("UserId")
                        .HasConstraintName("fkey_token_userid")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
