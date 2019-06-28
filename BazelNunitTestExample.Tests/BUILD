load("@io_bazel_rules_dotnet//dotnet:defs.bzl", "net_nunit3_test")

net_nunit3_test(
    name = "example",
	srcs = glob([
        "*.cs",
    ]),
    out = "BazelNunitTestExample.Tests.dll",
    args = [
        "--agents=1",
    ],
    data = [
    ],
    dotnet_context_data = "@io_bazel_rules_dotnet//:net_context_data_net47",
    visibility = ["//visibility:public"],
    deps = [
        "//BazelNunitTestExample:example",
        "@nunit//:net45",
    ],
)
