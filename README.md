# Stairway Pattern Architecture

![alt text](https://repository-images.githubusercontent.com/324436469/d8b51780-4db8-11eb-8c68-f890b154a1b4)

🚧 Work in progress. Source code nor documentation can be used yet! 🚧

⚠️ Disclaimer. This is a one-man's project, so its progress is not the fastest one. ⚠️

> Last update 05/01/2021
> 
> Document version 0.5.0
> 
> ![Appveyor status image](https://ci.appveyor.com/api/projects/status/github/kostasgrevenitis/Codenception.StairwayPatternArchitecture?branch=main&svg=true)
> [![License](https://img.shields.io/badge/License-Apache%202.0-blue.svg)](https://opensource.org/licenses/Apache-2.0)
> [![Quality Gate Status](https://sonarcloud.io/api/project_badges/measure?project=kostasgrevenitis_Codenception.StairwayPatternArchitecture&metric=alert_status)](https://sonarcloud.io/dashboard?id=kostasgrevenitis_Codenception.StairwayPatternArchitecture)
## Introduction

There is an excellent book called 
[**"Adaptive Code: Agile coding with design patterns and SOLID principles (Developer Best Practices) 2nd Edition"**](https://www.amazon.com/Adaptive-Code-principles-Developer-Practices/dp/1509302581), by Gary McLean Hall.

I am using this book as the basis for this project.

## What is Entourage anti-pattern?

The Entourage anti-pattern in simple Enlgish means that when you invite one, and only one, friend
to your party, we brings his own uninvited friends. This causes undesirable dependency management.
It brings unnecessary dependencies on board.

When we develop a project and add references to another project of conrcrete implementations
with references to other projects of concrete implementations as well, or/and nuget packages too, 
therefore we have to add those references as well. In simple words, in a ASP.NET Web app project, in the bin folder 
you will see the EF related assemblies as implicit dependencies.

![EntourageAntiPattern image](EntourageAntiPattern.png "Entourage AntiPattern")

## What is Staiway pattern?

The Stairway pattern is useful when we use abstraction (interfaces or abstract classes) 
and dependency inversion. It is applied when the project just depends on other projects 
that have only interfaces. Because of the we can avoid the Entourage anti-pattern. 
Also, those interface only projects should not depend 
on other third party (e.g. nuget) references. It's not possible all the time, 
but it would be good if those projects contain no implementations at all.

**The current structure allows the programmers to develop diffent implementations for different clients
following the same methods signatures by implementing the interfaces.**

![Stairway pattern image](StairwayPattern.png "Stairway Pattern")

# Prerequisites

- [.NET version 5.0.1 SDK](https://dotnet.microsoft.com/download/dotnet/5.0)
- [RabbitMQ](https://www.rabbitmq.com/), if RabbitMQ messagging implementation is used
- [ElasticSearch](https://www.elastic.co/downloads/elasticsearch), [Kibana](https://www.elastic.co/downloads/kibana) if Serilog + ElasticSearch + Kibana implementation is used

# Nuget dependencies
	
- [Autofac](https://www.nuget.org/packages/Autofac/)
- [Carter](https://www.nuget.org/packages/Carter/)
- [DocumentFormat.OpenXml](https://www.nuget.org/packages/DocumentFormat.OpenXml/)
- [Finbuckle.MultiTenant](https://www.nuget.org/packages/Finbuckle.MultiTenant/)
- [Fluent validation](https://www.nuget.org/packages/FluentValidation/)
- [MassTransit](https://www.nuget.org/packages/MassTransit/)
- [Microsoft.Extensions.Caching.Redis](https://www.nuget.org/packages/Microsoft.Extensions.Caching.Redis)
- [NSubstitute](https://www.nuget.org/packages/NSubstitute)
- [NSubstitute.Analyzers.CSharp](https://www.nuget.org/packages/NSubstitute.Analyzers.CSharp/)
- [Serilog](https://www.nuget.org/packages/Serilog/2.10.1-dev-01265)
- [xunit](https://www.nuget.org/packages/xunit/)

# Solution analysis

At the moment: 

- The codebase has 14 projects.
  - 2 clients projects
  - 2 unit tests projects
  - 6 interfaces projects
  - 4 implementations projects
 - An appveyor.yml file
- It borrows elements from DDD.
- It is layer structured.
- It is tier structured.
- It embraces DI
- Carter template is used instead of ASP.NET Core WebApi template, for the Web API

## Domain

The **.Domain.Interfaces** has all the interfaces organized per domain entity.

The **.Domain**	namespace has all the implementations of the agreed upon system behaviours.
In those classes we write the code that is related to the *functional requirements*. 
Each domain entity is assembled by three items:

- An Entity class item, that carries the domain (or business) logic
- A Record type item, that carries the data
- A Validator class item, that validates the data integrity

All 3 are immutable and any state changes should only be possible using methods. 
Data must be validated to ensure that we always have a valid state.

## Services

The **.Services.Interfaces** has all the interfaces organized per domain entity.

A service class is an orchestrator. A stateless object that performs actions.
It includes all the objects and data, and dictates how all of
them will work together. It actually implements pipelines of 
"input data -> transform data -> run calculations -> results -> persist and/or return results".

## Repositories

A repository encapsulates the logic that retrieves the data from a data source.
It mediates between the domain and data mapping layers, acting like an in-memory
domain object collection. The domain must be agnostic to the type of data 
that comprises the data source layer.

## Infrastructure

### Database

-- TODO --

### IO

-- TODO --

### Caching

-- TODO --

###	Messaging

-- TODO --

## Mappers

Mapper classes are in charge of mapping data from one object to another. This allows the domain
to be isolated by the data structures the client app uses, and the data structures the repositories use.
The isolated domain is easier to be unit tested by the programmers, and the solution structure 
is more scalable this ways.

# DevOps

## CI

### Appveyor

appveyor.yml

```yaml
version: '1.0.{build}'
image: Visual Studio 2019
branches:
  only:
  - main
init:
  # Good practise, because Windows line endings are different from Unix/Linux ones
  - cmd: git config --global core.autocrlf true
#install:
  # Install repo specific stuff here
before_build:
  # Display .NET Core version
  - cmd: dotnet --version
  # Display minimal restore text
  - cmd: dotnet restore 
build_script:
  - cmd: dotnet publish
#after_build:
  # For once the build has completed
#artifacts:
# - path: '\src\bin\Debug\netcoreapp1.1\publish'
#   name: WebSite
#   type: WebDeployPackage
clone_depth: 1
test_script:
  # restore packages for our unit tests
  - cmd: dotnet restore
  - cmd: dotnet test
#on_finish :
  # any cleanup in here
deploy: off
```

### Github actions

-- TODO --

## Codecov

-- TODO --

# How to use it

## Implement a feature

1. If Web Api client is used, create a controller class and the related DTO class(es)
2. Create a service class
3. Create an entity class, a record item and a validator class
4. Create a repository class
5. Create a data model class
6. Create the source access class
7. Add them into the Autofac IoC container, into the Startup.cs or Program.cs class

Always include
- Unit tests

## Implement a behaviour

-- TODO --


# Features roadmap

| Features  | Description |	Version|
| ------------- | ------------- |--|
| Option monad  | `null` is used to indicate no value. The method called can't produce a value of the expected type, and therefore it returns "nothing". The programmer must continually check if the value is null. It's only a matter of time before a null reference exception crops up because the variable wasn't checked. This is where `Option` monad steps in. In functional languages use what's known as an option type. In F# it's called Option, in Haskell it's called Maybe. Option<T> works in a very similar way to Nullable<T>, except it works with all types rather than just value types. It's a struct and therefore can't be null. An instance can be created by either calling Some(value), which represents a positive "I have a value" response, or None, which is the equivalent of returning null.  | TODO |
| Exceptions  | TODO  | TODO |
| To json  | TODO  | TODO |
| Data source access  | TODO  | TODO |
| Authentication/Authorization/Roles  | TODO  | TODO |
| Caching management  | - Implementation with InMemory cache <br/> - Implementation with Redis   | TODO |
| IO management  | Microsoft Office files management with DocumentFormat.OpenXml  | TODO |
| Logging  | - Implementation with Serilog to files <br/> - Implementation with Serilog, ElasticSearch, Kibana  | TODO |
| UI project  | UI project built with Blazor  | TODO |
| Messaging management  | Implementation with MassTransit  | TODO |
| Docker/Containers  | TODO  | TODO |
| Multitenant support  | Implementation with Finbuckle.MultiTenant  | TODO |
| Programmer's documentation  | Implementation with DocxFx  | TODO |

# Versions

[Semantic versioning](https://semver.org/) is used

<details>
  <summary>0.1.0.0</summary>
  Building the scaffold
</details>
