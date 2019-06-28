workspace(name = "nunitsample")

load("@bazel_tools//tools/build_defs/repo:http.bzl", "http_archive")

http_archive(
    name = "io_bazel_rules_dotnet",
    sha256 = "9ee5429417190f00b2c970ba628db833e7ce71323efb646b9ce6b3aaaf56f125",
    strip_prefix = "rules_dotnet-e9537b4a545528b11b270dfa124f3193bdb2d78e",
    urls = [
        "https://github.com/bazelbuild/rules_dotnet/archive/e9537b4a545528b11b270dfa124f3193bdb2d78e.tar.gz",
    ]
)

load("@io_bazel_rules_dotnet//dotnet:defs.bzl",
     "dotnet_register_toolchains",
     "net_register_sdk",
     "core_register_sdk",
     "mono_register_sdk",
     "dotnet_repositories",
     "dotnet_nuget_new",
     "nuget_package",
     "DOTNET_NET_FRAMEWORKS",
     "DOTNET_CORE_FRAMEWORKS")

dotnet_register_toolchains()
dotnet_repositories()

mono_register_sdk()

[net_register_sdk(
    framework
) for framework in DOTNET_NET_FRAMEWORKS]

[core_register_sdk(
    framework
) for framework in DOTNET_CORE_FRAMEWORKS]

# Default core_sdk
core_register_sdk("v2.1.502", name = "core_sdk")

# Default net_sdk
net_register_sdk("net472", name = "net_sdk")

dotnet_nuget_new(
   name = "nunit",
   package = "nunit",
   version = "3.11.0",
   build_file = "//third_party/nuget/packages:nunit.bzl",
)
