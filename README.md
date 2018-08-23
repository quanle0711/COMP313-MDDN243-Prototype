# COMP313-MDDN243-Prototype

## Assets used and imported: Post Processing-Stack (unity asset store)
## Unity3D 5.6.3f1 used!!! important!!!

## Highlight: Enemy(Giant) AI
used a mixture of Navmesh and Vector components, the Giant NPC can detect, move towards and attack any nearest buildings built. 
A successful attack by the giant also "knocks" the giant back as to better represent the attack animation of the enemy, and the delay between collision detections that determines the hitpoints of a building.

# City Smash
#### Quan Le and Melissa Marriott

### Genre: Construction-and-Management-Simulation (City builder) come Tower-Defence game 

## Premise: 
City Smash is a 3D city building game. The player builds their city at the top of a tiered play area and places defences to protect the city from a raging giant. 

## Goal:
As a player your goal is to erect a number of buildings (all standing at the same time) before the giant destroys your city or your citizens flee in panic. 

## Conception and Inspiration:
This game was conceived collaboratively using a topic abstraction method that involves picking a commonplace activity from your everyday life, focusing on a single aspect of that activity (i.e. a single action or a set of connected actions) then abstracting this to form a concept. We chose the aspect of precise footwork in the sport of fencing and abstracted this to a giant stepping on buildings, which eventually developed into our game. 
Our game was inspired by the aesthetics of Clash of Clans and Monsters Ate My Condo, random events from Simcity and the impact of panic on players decisions (stress system Darkest Dungeon). 

## Mechanics and Systems: 

#### Build mechanic (core)

Player chooses and clicks on a section of a grid in the top tier to create a building. Building subtracts 50 gold and cannot be done with less than 50 gold accumulated. 

#### Currency system 

The player passively accumulates gold each second which can be spent on buildings and defences. 

#### Defence mechanic (secondary)

The player chooses and clicks an area of a secondary grid on the middle tier to build a defence (in the prototype, a canon that targets the giant) that will slow down or alter the path of the giant. This costs money to create. 

#### Camera control (secondary)

The main camera points on the center of the city and can be rotated around using the right and left arrow keys, so the player can access all build areas equally as buildings can obscure areas behind them. 

#### Giant AI

The giant will target and move towards the nearest building to its current position. Every time it collides with a building it is repelled briefly before attacking again. 

#### Panic system 

The panic level of your citizens increases every time the giant successfully destroys a building. If the panic level gets too high you lose the game when citizens flee the city. 

#### Core Loop: 




Development Plan: A full development of this game would see bright and cheerful aesthetic modelled in a relatively simple 3D style, similar to the likes of Clash of Clans. The giant would be replaced with a rigged 3D model hooked up to ragdoll physics that triggers when it is hit by a defence. Buttons with pictures (for placing defences) would be illustrated in a simple, cartoon-like style with block colours. Small shrubs, trees and rocks would be added to the environment. The buildings changing colour to indicate how close they are to destruction would be replaced with animations of the building gradually becoming more and more wrecked. 

It will allow the player to work through a number of levels of increasing difficulty, with larger rewards, more defence abilities and building options available. Each level would start with a number of buildings (rather than a blank board) to immediately activate the giant. This way they player cannot sit until enough gold has been accumulated to build the entire city in one go. The level would also be lost if the giant destroyed all buildings. Once everything is fully implemented, a lot of balancing would need to be done to make both winning and losing feasible and give a better playing experience. This would include things like changing the giant’s speed, how much gold/ panic accumulates and the costs of various things, how much the cooldowns would affect gameplay and many other aspects. 

In a fully developed version, different building variations would be implemented, allowing greater and more considered control from the player. These buildings would provide ways to generate more income (bank), slow the panic level increase (temple), and reduce the cooldown time of defences (factory), but each different building would have varying number of hit points and may be easier for the giant to destroy than a regular building. 

Different defence options would also be implemented, on top of the canon, including a spring loaded boxing glove, tripwire, catapult, pool/ pond of glue, spikes and distractions. These defences would each have a cool down, that prevents the player from placing many at once and prompts them to think about the location of a defence. 

The panic system would involve benefits top the player that promote strategic thinking. Increased panic would reduce defence cool downs and increase gold production, but it would put the player at risk of losing the game, therefore a carefully monitored balance should be maintained. 

The game could potentially include random events and have a chance to do you harm or good- or the giant. To keep this involved in game tactics the player could have the ability to spend money on building an early warning system that gives them time to set up a contingency for an imminent random event.  Random events could include: wildfire, flooding, earthquake, meteor shower, mass bird migration, dense fog and more. 
