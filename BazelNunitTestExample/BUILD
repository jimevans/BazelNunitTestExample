load("@io_bazel_rules_dotnet//dotnet:defs.bzl", "core_library", "core_resource", "net_library")

net_library(
    name = "example",
    srcs = glob([
        "*.cs",
    ]),
    out = "BazelNunitTestExample.dll",
    dotnet_context_data = "@io_bazel_rules_dotnet//:net_context_data_net47",
    visibility = ["//visibility:public"],
    deps = [
        "@io_bazel_rules_dotnet//dotnet/stdlib.net:system.core.dll",
        "@io_bazel_rules_dotnet//dotnet/stdlib.net:system.data.dll",
        "@io_bazel_rules_dotnet//dotnet/stdlib.net:system.dll",
        "@io_bazel_rules_dotnet//dotnet/stdlib.net:system.drawing.dll",
        "@io_bazel_rules_dotnet//dotnet/stdlib.net:system.io.compression.dll",
        "@io_bazel_rules_dotnet//dotnet/stdlib.net:system.io.compression.filesystem.dll",
        "@io_bazel_rules_dotnet//dotnet/stdlib.net:system.net.http.dll",
        "@io_bazel_rules_dotnet//dotnet/stdlib.net:system.xml.dll",
    ],
)
