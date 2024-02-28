module IntegralForLoopLowering.Benchmarks

open BenchmarkDotNet.Attributes
open BenchmarkDotNet.Configs
open BenchmarkDotNet.Running

[<MemoryDiagnoser; GroupBenchmarksBy(BenchmarkLogicalGroupRule.ByCategory); CategoriesColumn; HideColumns("Method", "Error", "StdDev", "RatioSD")>]
type Benchmarks () =
    [<Benchmark(Baseline = true); BenchmarkCategory("Int32", "1", "10..1")>]
    member _.Int32_Old_10_1 () = Old.Int32.``10..1`` ()

    [<Benchmark; BenchmarkCategory("Int32", "1", "10..1")>]
    member _.Int32_New_10_1 () = New.Int32.``10..1`` ()

    [<Benchmark(Baseline = true); BenchmarkCategory("Int32", "2", "1..256")>]
    member _.Int32_Old_1_256 () = Old.Int32.``1..256`` ()

    [<Benchmark; BenchmarkCategory("Int32", "2", "1..256")>]
    member _.Int32_New_1_256 () = New.Int32.``1..256`` ()

    [<Benchmark(Baseline = true); BenchmarkCategory("Int32", "3", "start..finish (start=1,finish=65536)")>]
    member this.Int32_Old_Dynamic_1_65536 () = Old.Int32.``start..finish`` 1 65536

    [<Benchmark; BenchmarkCategory("Int32", "3", "start..finish (start=1,finish=65536)")>]
    member this.Int32_New_Dynamic_1_65536 () = New.Int32.``start..finish`` 1 65536

    [<Benchmark(Baseline = true); BenchmarkCategory("Int32", "4", "1..2..256")>]
    member _.Int32_Old_1_2_256 () = Old.Int32.``1..2..256`` ()

    [<Benchmark; BenchmarkCategory("Int32", "4", "1..2..256")>]
    member _.Int32_New_1_2_256 () = New.Int32.``1..2..256`` ()

    [<Benchmark(Baseline = true); BenchmarkCategory("Int32", "5", "start..step..finish (start=1,step=2,finish=65536)")>]
    member this.Int32_Old_Dynamic_1_2_65536 () = Old.Int32.``start..step..finish`` 1 2 65536

    [<Benchmark; BenchmarkCategory("Int32", "5", "start..step..finish (start=1,step=2,finish=65536)")>]
    member this.Int32_New_Dynamic_1_2_65536 () = New.Int32.``start..step..finish`` 1 2 65536

    [<Benchmark(Baseline = true); BenchmarkCategory("UInt32", "1", "10u..1u")>]
    member _.UInt32_Old_10uTo1u () = Old.UInt32.``10u..1u`` ()

    [<Benchmark; BenchmarkCategory("UInt32", "1", "10u..1u")>]
    member _.UInt32_New_10uTo1u () = New.UInt32.``10u..1u`` ()

    [<Benchmark(Baseline = true); BenchmarkCategory("UInt32", "2", "1u..256u")>]
    member _.UInt32_Old_1uTo256u () = Old.UInt32.``1u..256u`` ()

    [<Benchmark; BenchmarkCategory("UInt32", "2", "1u..256u")>]
    member _.UInt32_New_1uTo256u () = New.UInt32.``1u..256u`` ()

    [<Benchmark(Baseline = true); BenchmarkCategory("UInt32", "3", "start..finish (start=1u,finish=65536u)")>]
    member this.UInt32_Old_Dynamic_1uTo65536u () = Old.UInt32.``start..finish`` 1u 65536u

    [<Benchmark; BenchmarkCategory("UInt32", "3", "start..finish (start=1u,finish=65536u)")>]
    member this.UInt32_New_Dynamic_1uTo65536u () = New.UInt32.``start..finish`` 1u 65536u

    [<Benchmark(Baseline = true); BenchmarkCategory("UInt32", "4", "1u..2u..256u")>]
    member _.UInt32_Old_1u2u256u () = Old.UInt32.``1u..2u..256u`` ()

    [<Benchmark; BenchmarkCategory("UInt32", "4", "1u..2u..256u")>]
    member _.UInt32_New_1u2u256u () = New.UInt32.``1u..2u..256u`` ()

    [<Benchmark(Baseline = true); BenchmarkCategory("UInt32", "5", "start..step..finish (start=1u,step=2u,finish=65536u)")>]
    member this.UInt32_Old_Dynamic_1u2u65536u () = Old.UInt32.``start..step..finish`` 1u 2u 65536u

    [<Benchmark; BenchmarkCategory("UInt32", "5", "start..step..finish (start=1u,step=2u,finish=65536u)")>]
    member this.UInt32_New_Dynamic_1u2u65536u () = New.UInt32.``start..step..finish`` 1u 2u 65536u

    [<Benchmark(Baseline = true); BenchmarkCategory("Int64", "1", "10L..1L")>]
    member _.Int64_Old_10LTo1L () = Old.Int64.``10L..1L`` ()

    [<Benchmark; BenchmarkCategory("Int64", "1", "10L..1L")>]
    member _.Int64_New_10LTo1L () = New.Int64.``10L..1L`` ()

    [<Benchmark(Baseline = true); BenchmarkCategory("Int64", "2", "1L..256L")>]
    member _.Int64_Old_1LTo256L () = Old.Int64.``1L..256L`` ()

    [<Benchmark; BenchmarkCategory("Int64", "2", "1L..256L")>]
    member _.Int64_New_1LTo256L () = New.Int64.``1L..256L`` ()

    [<Benchmark(Baseline = true); BenchmarkCategory("Int64", "3", "start..finish (start=1L,finish=65536L)")>]
    member this.Int64_Old_Dynamic_1LTo65536L () = Old.Int64.``start..finish`` 1L 65536L

    [<Benchmark; BenchmarkCategory("Int64", "3", "start..finish (start=1L,finish=65536L)")>]
    member this.Int64_New_Dynamic_1LTo65536L () = New.Int64.``start..finish`` 1L 65536L

    [<Benchmark(Baseline = true); BenchmarkCategory("Int64", "4", "1L..2L..256L")>]
    member _.Int64_Old_1L2L256L () = Old.Int64.``1L..2L..256L`` ()

    [<Benchmark; BenchmarkCategory("Int64", "4", "1L..2L..256L")>]
    member _.Int64_New_1L2L256L () = New.Int64.``1L..2L..256L`` ()

    [<Benchmark(Baseline = true); BenchmarkCategory("Int64", "5", "start..step..finish (start=1L,step=2L,finish=65536L)")>]
    member this.Int64_Old_Dynamic_1L2L65536L () = Old.Int64.``start..step..finish`` 1L 2L 65536L

    [<Benchmark; BenchmarkCategory("Int64", "5", "start..step..finish (start=1L,step=2L,finish=65536L)")>]
    member this.Int64_New_Dynamic_1L2L65536L () = New.Int64.``start..step..finish`` 1L 2L 65536L

ignore (BenchmarkRunner.Run<Benchmarks> ())
