module IntegralForLoopLowering.New

open System.Runtime.CompilerServices

module UInt32 =
    [<MethodImpl(MethodImplOptions.NoInlining)>]
    let ``10u..1u`` () = for _ in 10u..1u do ignore (2. ** 2.)

    [<MethodImpl(MethodImplOptions.NoInlining)>]
    let ``1u..256u`` () = for _ in 1u..256u do ignore (2. ** 2.)

    [<MethodImpl(MethodImplOptions.NoInlining)>]
    let ``start..finish`` (start : uint) finish = for _ in start..finish do ignore (2. ** 2.)

    [<MethodImpl(MethodImplOptions.NoInlining)>]
    let ``10u..2u..1u`` () = for _ in 10u..2u..1u do ignore (2. ** 2.)

    [<MethodImpl(MethodImplOptions.NoInlining)>]
    let ``1u..2u..256u`` () = for _ in 1u..2u..256u do ignore (2. ** 2.)

    [<MethodImpl(MethodImplOptions.NoInlining)>]
    let ``start..step..finish`` (start : uint) step finish = for _ in start..step..finish do ignore (2. ** 2.)

module Int64 =
    [<MethodImpl(MethodImplOptions.NoInlining)>]
    let ``10L..1L`` () = for _ in 10L..1L do ignore (2. ** 2.)

    [<MethodImpl(MethodImplOptions.NoInlining)>]
    let ``1L..256L`` () = for _ in 1L..256L do ignore (2. ** 2.)

    [<MethodImpl(MethodImplOptions.NoInlining)>]
    let ``start..finish`` (start : int64) finish = for _ in start..finish do ignore (2. ** 2.)

    [<MethodImpl(MethodImplOptions.NoInlining)>]
    let ``10L..2L..1L`` () = for _ in 10L..2L..1L do ignore (2. ** 2.)

    [<MethodImpl(MethodImplOptions.NoInlining)>]
    let ``10L..-1L..1L`` () = for _ in 10L.. -1L..1L do ignore (2. ** 2.)

    [<MethodImpl(MethodImplOptions.NoInlining)>]
    let ``1L..2L..256L`` () = for _ in 1L..2L..256L do ignore (2. ** 2.)

    [<MethodImpl(MethodImplOptions.NoInlining)>]
    let ``start..step..finish`` (start : int64) step finish = for _ in start..step..finish do ignore (2. ** 2.)
