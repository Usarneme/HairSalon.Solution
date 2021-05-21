#!bin/bash

# prompt the user for a project name
echo -n "Enter the project name: "
read PNAME

# conditional, test whether project name was provided
if [[ -n $PNAME ]]
then
  echo "Setting Up Up Project Named: $PNAME"
  # Make directories
  mkdir $PNAME
  mkdir $PNAME/Models
  tes="${PNAME}.Tests"
  mkdir $tes
  mkdir $tes/ModelTests

  # Make empty cs class file
  main="${PNAME}.cs"
  touch $PNAME/Models/$main

  # Make csproj files for main and test dirs
  mainproj="${PNAME}.csproj"
  echo "<Project Sdk=\"Microsoft.NET.Sdk\">
  <PropertyGroup>
    <TargetFramework>net5.0</TargetFramework>
  </PropertyGroup>
</Project>" >> $PNAME/$mainproj
  testproj="${PNAME}.Tests.csproj"
  echo "<Project Sdk=\"Microsoft.NET.Sdk\">

  <PropertyGroup>
    <TargetFramework>net5.0</TargetFramework>
  </PropertyGroup>
  <ItemGroup>
    <PackageReference Include=\"Microsoft.NET.Test.Sdk\" Version=\"15.0.0\" />
    <PackageReference Include=\"MSTest.TestAdapter\" Version=\"1.3.2\" />
    <PackageReference Include=\"MSTest.TestFramework\" Version=\"1.3.2\" />
  </ItemGroup>

  <ItemGroup>
    <ProjectReference Include=\"..\\${PNAME}\\${mainproj}\" />
  </ItemGroup>

</Project>" >> $tes/$testproj

  # make cs test file
  modtes="${PNAME}Test.cs"
  echo "using Microsoft.VisualStudio.TestTools.UnitTesting;" >> $tes/ModelTests/$modtes

  # print success and escape
  echo "${PNAME} Project Directories and Files Set Up Successfully!"
  exit 1
else
  echo "You must provide a project name. Please try again."
  exit 0
fi