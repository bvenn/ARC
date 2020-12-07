#load "/workspaces/FSharpCodespace/dependencies/.paket/load/netstandard2.0/main.group.fsx"

open Plotly.NET

Chart.Point([1.,2.])
|> Chart.SaveHtmlAs "test"