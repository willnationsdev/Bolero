namespace MiniBlazor.Tests

open FsCheck

[<AutoOpen>]
module Utility =

    let (.=.) left right = left = right |@ sprintf "%A = %A" left right

    let epsilon = 0.0001

    let (=~) left right = left - right < epsilon

    let (.=~.) left right = left =~ right |@ sprintf "%A =~ %A" left right