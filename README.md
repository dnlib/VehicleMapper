# VehicleMapper
A very simple FiveM script that allows you to easily map vehicle model names to much more friendly names using a JSON file

## Editing

Edit it, open `VehicleMapper.sln` in Visual Studio.

## Compilation

To build it, run `build.cmd`. The `dist` folder can be copied to your server resources.

## Installation

Grab the latest version from the releases page.

Afterwards, you can use `ensure VehicleMapper` in your server.cfg or server console to start the resource. You should make sure that this is after the `ensure chat` and such is ran.

Finally, you'll want to modify the `vehicles.json` file in the folder to what models and names you want to map to.

The structure is as follows:

```json
[
    {
        "name": "Friendly name of the vehicle",
        "model": "model-name-of-the-vehicle"
    },
    {
        "name": "Audi R8 V10",
        "model": "audir8"
    }
]
```
