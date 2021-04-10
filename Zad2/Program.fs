open System

let isBalanced str = 
    let rec loop leftStr stack = 
        match (leftStr, stack) with
        | '(' :: frstSkipped,  stack         -> loop frstSkipped ('(' :: stack)
        | ')' :: frstSkipped, '(' :: stack   -> loop frstSkipped stack
        | ')' :: _, _               -> false
        | _ :: frstSkipped, stack   -> loop frstSkipped stack
        | [], []                    -> true
        | [], _                     -> false
    loop (Seq.toList str) []

[<EntryPoint>]
let main argv =
    printfn "Rozwiązanie zadania nr 31:"
    printfn "Test 1: \"()\" - %O" (isBalanced "()")
    printfn "Test 2: \"()()()\" - %O" (isBalanced "()()()")
    printfn "Test 3: \"((()))\" - %O" (isBalanced "((()))")
    printfn "Test 4: \"()((())())\" - %O" (isBalanced "()((())())")
    printfn "Podany argument \"%O\"" argv.[0]
    let isBalancedGiven = isBalanced argv.[0]
    printfn "Czy jest poprawny?: %O" isBalancedGiven
    0