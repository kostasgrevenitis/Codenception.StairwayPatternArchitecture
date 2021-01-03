# Stairway Pattern Architecture
> Last update 03/01/2021
> 
> Document version 0.1

⚠️ Warning ⚠️

🚧 Work in progress. It can't be used yet! 🚧

## Introduction

There is an excellent book called **"Adaptive Code: Agile coding with design patterns and SOLID principles (Developer Best Practices) 2nd Edition"**, by Gary McLean Hall.

## What is Entourage anti-pattern?

The Entourage anti-pattern in simple Enlgish means that when you invite one, and only one, friend
to your party, we brings his own uninvited friends. This causes undesirable dependency management.


The Entourage anti-pattern brings unnecessary dependencies on board.
When we develop a project and add references to another project of conrcrete implementations
with references to other projects of concrete implementations as well, or/and nuget packages too, 
therefore we have to add those references as well. In simple words, in a ASP.NET Web app project, in the bin folder 
you will see the EF related assemblies as implicit dependencies.


## What is Staiway pattern?

The Stairway pattern is useful when we use abstraction (interfaces or abstract classes) 
and dependency inversion. It is applied when the project just depends on other projects 
that have only interfaces. Because of the we can avoid the Entourage anti-pattern. 
Also, those interface only projects should not depend 
on other third party (e.g. nuget) references. It's not possible all the time, 
but it would be good if those projects contain no implementations at all.

# Solution analysis

## Introduction

As we speak: 

- The codebase has 14 projects.	
- It borrows elements from DDD.
- It is layer structured.
- It is tier structured.
- Embraces DI
- Carter template is used instead of ASP.NET Core WebApi template

## Domain

The **.Domain.Interfaces** has all the interfaces organized per domain entity.

The **.Domain**	namespace has all the implementations of the agreed upon system behaviours.
In those classes we write the code that is related to the *functional requirements*. 
Each domain entity is assembled by three items:

- An Entity class item, that carries the domain (or business) logic
- A Record type item, that carries the data
- A Validator class item, that validates the data integrity

All 3 are immutable and any data changes should only be possible using methods. 
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

-- TODO --

## Mappers

Mapper classes are in charge of mapping data from one object to another. This allows the domain
to be isolated by the data structures the client app uses, and the data structures the repositories use.
The isolated domain is easier to be unit tested by the programmers, and the solution structure 
is more scalable this ways.

## Clients

### Console app client

-- TODO --

### Web Api client

-- TODO --

## External dependencies

- Fluent validation nuget package

# How to use the solution

# Roadmap

- [ ] Exceptions
- [ ] To json
- [ ] Unit tests
- [ ] Authentication/Authorization/Roles
- [ ] Caching 
- [ ] Session management
- [ ] Encryption
- [ ] UI project
- [ ] Integration tests
- [ ] Docker/Containers

# Versions

<details>
  <summary>0.0.1.0</summary>
  Building the scaffold
</details>
