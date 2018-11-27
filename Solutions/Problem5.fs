namespace Solutions

module Problem5 =
    let solve () : int64 =
        let multiples = Seq.initInfinite(fun n -> (n + 1) * 2 * 3 * 5 * 7 * 11 * 13 * 17 * 19)
        Seq.find (fun n -> Seq.forall (fun m -> n % m = 0) [2..20]) multiples |> int64