namespace Solutions

module Problem2 =
    let fibs =
        let rec f a b = seq {
            yield a
            yield! f b (a + b)
        }
        f 1 1
        |> Seq.cache

    let solve () : int64 =
        fibs
        |> Seq.takeWhile (fun x -> x < 4000000)
        |> Seq.filter (fun x -> x % 2 = 0)
        |> Seq.sum
        |> int64