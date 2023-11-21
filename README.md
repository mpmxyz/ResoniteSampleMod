# ResoniteSampleMod
[![Build & Test (MonkeyLoader)](https://github.com/mpmxyz/ResoniteSampleMod/actions/workflows/build-monkey.yml/badge.svg?branch=main)](https://github.com/mpmxyz/ResoniteSampleMod/actions/workflows/build-monkey.yml)
[![Build & Test (ResoniteModLoader)](https://github.com/mpmxyz/ResoniteSampleMod/actions/workflows/build-rml.yml/badge.svg?branch=main)](https://github.com/mpmxyz/ResoniteSampleMod/actions/workflows/build-rml.yml)

A Mod for Resonite that just adds a "Hello World!" log entry whenever you click a button.

## About this repository

This repository is a template everyone can copy from.
It includes automatic github workflows to test your code (Continuous Integration) and a manually triggered release workflow to publish a new version.
Mods created using this template support two different mod loaders: [ResoniteModLoader](https://github.com/resonite-modding-group/ResoniteModLoader) and [MonkeyLoader](https://github.com/Banane9/MonkeyLoader)

## Initializing the Template
TODO
- private "ResoniteFiles" repository and read-only access token
- change permissions settings of repository
- change mpmxyz -> repository owner
- change ResoniteSampleMod -> repo name
- change SampleMod -> project name
- remove "about this repository", "initializing the template" and "publishing a new mod version"

## Publishing a new Mod Version
TODO

## Installation (ResoniteModLoader)
1. Install [ResoniteModLoader](https://github.com/resonite-modding-group/ResoniteModLoader).
2. Download [release zip file](https://github.com/mpmxyz/ResoniteSampleMod/releases/latest/download/SampleMod-ResoniteModLoader.zip) and extract contents into Resonite directory. (e.g. rml_mods should be merged with rml_mods.)
3. Start Resonite. (with ```-LoadAssembly Libraries/ResoniteModLoader.dll``` launch option)

## Installation (MonkeyLoader)
(Work in Progress)
1. Install [MonkeyLoader](https://github.com/Banane9/MonkeyLoader).
2. Add package source "https://nuget.pkg.github.com/mpmxyz/index.json"
3. Add package "mpmxyz.SampleMod.MonkeyLoader"
4. Start Resonite.
