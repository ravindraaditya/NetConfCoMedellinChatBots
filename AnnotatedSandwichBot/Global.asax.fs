namespace Microsoft.Bot.FunSample.AnnotatedSandwichBot

open System.Web
open System.Web.Http

type WebApiApplication() =
    inherit HttpApplication()

    member this.Application_Start() =
         WebApiConfig.Register |> GlobalConfiguration.Configure
