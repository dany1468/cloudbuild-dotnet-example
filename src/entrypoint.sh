#!/bin/bash

set -e
run_cmd="dotnet test"

until dotnet ef database update -p CloudBuildSample.EF; do
  >&2 echo "SQL Server is starting up"
  sleep 1
done

>&2 echo "SQL Server is up - executing command"
exec $run_cmd

