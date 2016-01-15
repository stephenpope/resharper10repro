Seems to be an issue with how .NET monikers are assessed in Resharper 10.

- `Thing` is a .NET451 project
- `Thing.Abstractions` is a .NET45 project

In the `Thing` project, it is unable to see the `IDoSomething` interface.

In the `Thing` project  - `project.json` .. if you change :

    "frameworks": {
      "net451": { }
    }

.. to ..

    "frameworks": {
      "net45": { }
    }

.. then Resharper can see the the other projects classes/interfaces.

I would say this was a bug (.NET451 should be able to see .NET45 projects).

Without Resharper Visual Studio's intellisense sees the classes correctly.