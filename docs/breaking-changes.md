# Breaking Changes

This document is supposed to capture cases where we'd like to deviate in
behavior and/or API surface from our goal of being 100% compatible with .NET
Framework, Mono, and Xamarin.

Please note that this doesn't imply that we'll **actually** break compatibility.
However, maintainin this list is helpful for making educated decisions around
the degree to which compatibility can -- and should -- be achieved.

## Binary Serialization

* Right now, our contracts imply a large chunks of all the framework types are
  marked as serializable
* Changing the contracts isn't helping because it's about whether the runtime
  view implements

### Investigation

* Review list of types in the .NET Core and see what the current and future
  impact of serialization would be
* Find types that implement `ISerializable` and/or are marked `[Serializable]`
  and include the list of framework types that reference
