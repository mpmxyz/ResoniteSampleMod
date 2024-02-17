# ResoniteSampleMod
[![Build & Test (MonkeyLoader)](https://github.com/mpmxyz/ResoniteSampleMod/actions/workflows/build-monkey.yml/badge.svg?branch=main)](https://github.com/mpmxyz/ResoniteSampleMod/actions/workflows/build-monkey.yml)
[![Build & Test (ResoniteModLoader)](https://github.com/mpmxyz/ResoniteSampleMod/actions/workflows/build-rml.yml/badge.svg?branch=main)](https://github.com/mpmxyz/ResoniteSampleMod/actions/workflows/build-rml.yml)

A Mod for Resonite that just adds a "Hello World!" log entry whenever you click a button.

## About this repository

This repository is a template everyone can copy from.
It includes automatic github workflows to test your code (Continuous Integration including linting and style checking) and a manually triggered release workflow to publish a new version.
Mods created using this template support two different mod loaders: [ResoniteModLoader](https://github.com/resonite-modding-group/ResoniteModLoader) and [MonkeyLoader](https://github.com/Banane9/MonkeyLoader)

## Using this Template
1. Use this repository as a template (green button ```Use this template/Create a new repository``` on the top right)
2. Inside the new repository go to the tab ```Actions``` and run the workflow ```Init Template``` (You can specify user/mod names that differ from the repository.)
3. After the action is finished, follow the instructions in the newly created Issue ```Setup repository to support full CI/CD```
   (most likely [#1](https://github.com/mpmxyz/ResoniteSampleMod/issues/1) when reading this in your repository)
5. On your local machine make sure that the environment variables ```ResonitePath``` (required) and ```ResoniteCache``` (recommended) are set and that you have at least one mod loader installed.
6. ???
7. Happy coding!

Additional Notes:
- This template uses a shared project to reduce redundancies between the different mod loader variants.
  (Using solution internal dependencies would cause multiple dll files to be output. To reduce the inconvenience for ResoniteModLoader users I chose this hacky workaround.)
  Only open one of those projects at a time to avoid bugs with Visual Studio!
  If you open multiple variants at a time you may encounter warning messages and cannot save changes to the csproj files!
  Restarting Visual Studio makes sure that the error messages go away.
- You can freely add dependencies to your project. Shared dependencies should be added to the project SampleMod.csproj (without suffix!) to keep dependencies of the variants in sync.
- There are unit tests using the mod loader independent project.
- You can start Resonite directly from Visual Studio. The dll files/NuGet packages will be directly copied into the Resonite install.
  If you add additional files you have to adjust the scripts in the files SampleModMonkey.csproj and SampleModRML.csproj.
  The file ```manifest-template.json``` and the step ```Build``` of workflow ```Build & Test (ResoniteModLoader)``` need to be adjusted for proper release automation, too.
  (TODO: hints for NuGet-based MonkeyLoader mods)

## Publishing a new Mod Version
1. Increment the &lt;Version&gt; number within the files ```SampleMod.csproj``` and ```Mod.RML/SampleModRML.cs```
2. Execute the github workflow ```Create Release```

## Installation (ResoniteModLoader)
1. Install [ResoniteModLoader](https://github.com/resonite-modding-group/ResoniteModLoader).
2. Download [release zip file](https://github.com/mpmxyz/ResoniteSampleMod/releases/latest/download/SampleMod-ResoniteModLoader.zip) and extract contents into Resonite directory. (e.g. rml_mods should be merged with rml_mods.)
3. Start Resonite. (with ```-LoadAssembly Libraries/ResoniteModLoader.dll``` launch option)

## Installation (MonkeyLoader)
(Work in Progress)
1. ~Install [MonkeyLoader](https://github.com/Banane9/MonkeyLoader).~
2. ~Add package source "https://nuget.pkg.github.com/mpmxyz/index.json"~
3. ~Add package "mpmxyz.SampleMod.MonkeyLoader"~
4. ~Start Resonite.~
