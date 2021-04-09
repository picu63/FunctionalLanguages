
open System
open System.Numerics

let complexPrint(compl:Complex):string =
    let real = compl.Real
    let imaginary = compl.Imaginary
    $"Czesc rzeczywista: {real}, Część urojona: {imaginary}"

[<EntryPoint>]
let main argv =
    printfn "Rozwiązanie zadania nr 14:"
    let a = Complex.Divide(new Complex(1.0,1.0), new Complex(1.0,-1.0))
    let b = Complex.Divide(new Complex(0.0, 2.0), new Complex(1.0, 1.0))
    let c = Complex.Divide(new Complex(4.0, -3.0), new Complex(4.0, 3.0))
    let d = Complex.Sqrt(new Complex(-3.0,  -4.0))
    let e = Complex.Sqrt(new Complex(8.0,  6.0))
    let f = Complex.Pow(new Complex(1.0, 1.0), 10.0)
    let g = Complex.Pow(new Complex(2.0, Math.Sqrt(12.0)), 5.0)
    let h = Complex.Sqrt(new Complex(-1.0, 0.0))
    let aConv = complexPrint a
    let bConv = complexPrint b
    let cConv = complexPrint c
    let dConv = complexPrint d
    let eConv = complexPrint e
    let fConv = complexPrint f
    let gConv = complexPrint g
    let hConv = complexPrint h
    printfn "a) %A" aConv
    printfn "b) %A" bConv
    printfn "c) %A" cConv
    printfn "d) %A" dConv
    printfn "e) %A" eConv
    printfn "f) %A" fConv
    printfn "g) %A" gConv
    printfn "h) %A" hConv
    0