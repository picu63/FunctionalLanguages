// Learn more about F# at http://docs.microsoft.com/dotnet/fsharp

open System
open FParsec

let a = pstring "Hello"
let b = pstring "World"
let p = a<|>b
let result = run p "Hello"
printfn "%O" result