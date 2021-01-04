﻿# Stairway Pattern Architecture

![alt text](https://repository-images.githubusercontent.com/324436469/d8b51780-4db8-11eb-8c68-f890b154a1b4)

🚧 Work in progress. It can't be used yet! 🚧

⚠️ Disclaimer. This is one man project, some its progress won't be the fastest one ⚠️


> Last update 04/01/2021
> 
> Document version 0.2
> 
> ![Appveyor status image](https://ci.appveyor.com/api/projects/status/github/kostasgrevenitis/Codenception.StairwayPatternArchitecture?branch=main&svg=true)
>
> [![License](https://img.shields.io/badge/License-Apache%202.0-blue.svg)](https://opensource.org/licenses/Apache-2.0)

## Introduction

There is an excellent book called 
[**"Adaptive Code: Agile coding with design patterns and SOLID principles (Developer Best Practices) 2nd Edition"**](https://www.amazon.com/Adaptive-Code-principles-Developer-Practices/dp/1509302581), by Gary McLean Hall.

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

**The current structure allows the programmers to develop diffent implementations for different clients
following the same methods signatures by implementing the interfaces.**

# Solution analysis

As we speak: 

- The codebase has 14 projects.
  - 2 clients projects
  - 2 unit tests projects
  - 6 interfaces projects
  - 4 implementations projects
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

###	Queue messaging

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

| Features  | Description |	Version|
| ------------- | ------------- |--|
| Option  | Content Cell  | |
| Exceptions  | Content Cell  | |
| To json  | Content Cell  | |
| Authentication/Authorization/Roles  | Content Cell  | |
| Caching   | Content Cell  | |
| Session management  | Content Cell  | |
| IO management  | Content Cell  | |
| Queue messaging management  | Content Cell  | |
| UI project  | Content Cell  | |
| Multitenant support  | Content Cell  | |
| Docker/Containers  | Content Cell  | |

# Versions

<details>
  <summary>0.0.1.0</summary>
  Building the scaffold
</details>
