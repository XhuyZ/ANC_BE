#!/usr/bin/env bash

set -e

read -p "Enter solution name (e.g. ANC): " SOLUTION

if [[ -z "$SOLUTION" ]]; then
  echo "❌ Solution name is required"
  exit 1
fi

echo "🚀 Creating solution: $SOLUTION"

# Root folder
mkdir "$SOLUTION"
cd "$SOLUTION"

# Create solution
dotnet new sln -n "$SOLUTION"

# Create projects (same level)
dotnet new webapi  -n "$SOLUTION.Api"
dotnet new classlib -n "$SOLUTION.Application"
dotnet new classlib -n "$SOLUTION.Domain"
dotnet new classlib -n "$SOLUTION.Infrastructure"
dotnet new xunit   -n "$SOLUTION.Tests"

# Add projects to solution
dotnet sln add \
  "$SOLUTION.Api/$SOLUTION.Api.csproj" \
  "$SOLUTION.Application/$SOLUTION.Application.csproj" \
  "$SOLUTION.Domain/$SOLUTION.Domain.csproj" \
  "$SOLUTION.Infrastructure/$SOLUTION.Infrastructure.csproj" \
  "$SOLUTION.Tests/$SOLUTION.Tests.csproj"

# Add references
dotnet add "$SOLUTION.Application/$SOLUTION.Application.csproj" \
  reference "$SOLUTION.Domain/$SOLUTION.Domain.csproj"

dotnet add "$SOLUTION.Infrastructure/$SOLUTION.Infrastructure.csproj" \
  reference "$SOLUTION.Application/$SOLUTION.Application.csproj" \
            "$SOLUTION.Domain/$SOLUTION.Domain.csproj"

dotnet add "$SOLUTION.Api/$SOLUTION.Api.csproj" \
  reference "$SOLUTION.Application/$SOLUTION.Application.csproj" \
            "$SOLUTION.Infrastructure/$SOLUTION.Infrastructure.csproj"

dotnet add "$SOLUTION.Tests/$SOLUTION.Tests.csproj" \
  reference "$SOLUTION.Api/$SOLUTION.Api.csproj" \
            "$SOLUTION.Application/$SOLUTION.Application.csproj" \
            "$SOLUTION.Domain/$SOLUTION.Domain.csproj" \
            "$SOLUTION.Infrastructure/$SOLUTION.Infrastructure.csproj"

echo "✅ Solution $SOLUTION created successfully"

