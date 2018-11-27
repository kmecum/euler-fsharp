namespace Solutions

module Problem4 =
    let isPalindrome (n:int) =
        let rec reverse (n: int) =
            match n with
            | 0 -> 0
            | _ -> (n % 10 * ((10.0 ** (n |> float |> log10 |> floor)) |> int)) + reverse (n / 10)
        n = reverse n

    let solve () : int64 =
        let candidates =
            [for a in 100..999 do
             for b in 100..999 do
                yield (a * b)]
            |> Seq.sort
            |> Seq.rev
        Seq.find isPalindrome candidates |> int64