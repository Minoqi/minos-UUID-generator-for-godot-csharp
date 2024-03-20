# Usage with CSharp

There are two ways to use the UUID generator, in eidtor or at runtime. *Make sure to have followed the installation steps first!*

## In Editor

1. Create new `UUIDManagerCSharp` node
2. That's it! The UUIID is generated automatically and is removed automatically when the node is removed.


## At Runtime

1. Add a `UUIDManagerCSharp` variable in the script you want to store the UUID node in
```cs
// Variables
UUIDManager uuidNode
```

2. Set the variable by calling the `create_new_uuid()` script at `_ready()`. The function takes in the parent to add the node to as a child.
```cs
// Variables
UUIDManager uuidNode

public override void _Ready(){
  uuidNode = MinosUUIDGeneratorCSharp.CreateNewUUID(this);
}
```

## Set-Up Debugging Options

The `MinosUUIDGeneratorCSharp` script comes with 4 variables for debugging. By default they're set to true.

```cs
static bool printNewUUID = true
static bool printSuccessfulRemoval = true
static bool printFailedRemoval = true
static bool printNewUUIDNode = true
```

- `printNewUUID` will print a message when a new UUID is made and it's UUID.
- `printSuccessfulRemoval` will print a message when a UUID is removed as well as the old UUID.
- `printFailedRemoval` will print a message when a UUID was attempted to be removed but couldn't be found in the array.
- `printNewUUIDNode` will print a message when a new `UUIDManagerCSharp` node is made.
