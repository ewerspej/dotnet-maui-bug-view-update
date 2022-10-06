# dotnet-maui-bug-view-update
Views don't get updated (e.g. when changing layout or applying a VisualState) unless UI is interacted with or an observable property gets changed

This occurs, when trying to update the UI layout in response to a size change, e.g. by applying a VisualState when rotating the device.
