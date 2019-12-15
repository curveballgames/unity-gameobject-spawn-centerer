# Unity GameObject Spawn Centerer
Automatically center any GameObject at 0,0,0 when instantiated in the Unity Editor.

## Importing
1. Download the latest zip from [releases](https://github.com/curveballgames/unity-gameobject-spawn-centerer/releases)
2. Unpack into project Assets directory

## Usage
This package automatically centers any GameObject instantiated in the Editor a `Vector3.zero`.

## How it works
**This is a very simple feature designed for quality of life.** Please read below on how it is implemented to save yourself some headaches.

- A very simple `CustomEditor` activates any time a GameObject with a transform is selected
- This custom editor looks for the `GameObjectCenterer` script attached to said component
    - If the component exists, it does nothing
    - If the component does not exist, it adds it to the `GameObject` of the inspected `Transform`
- The `GameObjectCenterer` script executes in edit mode. It centers the GameObject immediately by setting its `localPosition` to `Vector3.zero`.
- The fact that is has done this is stored, so that the code is not run again.

**Note:** overriding the `Transform` editor replaces world coordinates with local coordinates.

## Contributing
1. Create a `feature` branch off master
2. Once feature complete, submit a [pull request against master](https://github.com/curveballgames/unity-gameobject-spawn-centerer/compare)
3. Assign at least [the repository owner](https://github.com/curveballgames) as a reviewer
4. Await approval and merge from the repository owner

Once approved and merged, a new release will be created by the repository owner.

## License
This codebase is provided under the MIT license. That means you may do whatever you please with this code, including distribution, replication, and use in your own code projects. Curveball Games assumes no rights to its usage, and is providing the code in the public domain.

Please view the [license file](https://github.com/curveballgames/unity-gameobject-spawn-centerer/blob/master/LICENSE) for more information. You can find out more about the MIT license [here](https://opensource.org/licenses/MIT).
