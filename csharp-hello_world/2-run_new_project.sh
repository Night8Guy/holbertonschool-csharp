#!/usr/bin/env bash

cd ~/csharp-hello_world

dotnet new console -o 2-new_project

dotnet build 2-new_project

dotnet run --project 2-new_project
