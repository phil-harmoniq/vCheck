#!/usr/bin/env bash

set -e

curl "https://api.nuget.org/v3/registration3/shell.net/index.json" > shell-result.json
