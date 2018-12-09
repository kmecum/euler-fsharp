open Solutions

let solvers =
    let funcs : List<unit->int64> =
        [Problem1.solve;
         Problem2.solve;
         Problem3.solve;
         Problem4.solve;
         Problem5.solve;
         Problem6.solve;
         Problem7.solve;
         Problem8.solve;
         Problem9.solve;
         Problem10.solve;
         Problem11.solve]
    Seq.zip [1..funcs.Length] funcs

let printSolution i f =
    printfn "Problem %i: %i" i (f ())

[<EntryPoint>]
let main argv =
    if argv.Length = 1 then
        let success, i = System.Int32.TryParse argv.[0]
        if success && i > 0 && i <= Seq.length solvers then
            let _, f = Seq.item (i - 1) solvers
            printSolution i f
            0
        else
            eprintfn "'%s' is not a valid problem number. Try again." argv.[0]
            1
    else
        for (i, f) in solvers do
            printSolution i f
        0
