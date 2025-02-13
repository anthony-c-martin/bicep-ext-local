#!/bin/bash
set -e

root="$(dirname ${BASH_SOURCE[0]})/.."

dotnet run --project "$root/src/Bicep.Types.Local/Bicep.Types.Local.csproj" -- --outdir "$root/types"