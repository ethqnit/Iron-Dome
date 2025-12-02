# Iron-Dome

JavaScript Export Web Game.

<img src="https://img.shields.io/badge/Godot-4.2+%20(C%23)-478CBF?style=for-the-badge&logo=godot-engine" alt="Godot 4 C#">
<img src="https://img.shields.io/badge/Status-Learning%20Project%20%7C%20Archived-8A2BE2?style=for-the-badge" alt="Status">
<img src="https://img.shields.io/github/stars/ethqnit/Iron-Dome?style=for-the-badge" alt="Stars">

# ✈️ Iron Dome – Missile Defense Prototype

**A 2D missile interceptor game built in Godot 4 using C#**  
Defend your cities from waves of incoming ballistic missiles by launching counter-missiles that predict and intercept threats mid-flight.

This is a **learning sandbox** — not a polished game. I built it to deeply understand:
- Predictive targeting & interception math
- C# + Godot 4 workflow
- Particle effects, trails, and explosions
- Scene organization and signal-based architecture

<div align="center">
  <img src=".github/gameplay.gif" width="800" alt="Iron Dome Gameplay"/>
  <br><br>
  <sub><b>Intercepting multiple incoming threats with predictive trajectories</b></sub>
</div>

<br>

## 🎮 Features

- Realistic(ish) missile interception with lead prediction
- Explosions with screen shake and debris particles
- Satisfying trail effects using `Trail2D` + custom shaders
- Multiple cities to protect (game over when all are destroyed)
- Increasing difficulty waves
- 100% C# scripting (no GDScript!)
- Heavily modified open-source assets (all credited)

<br>

## 🛠️ Built With

- **Godot Engine 4.2+** (Mono / C#)
- Custom math for interception point calculation
- Modified assets from Kenney.nl (see credits)
- Particle systems & shader-based glow trails

<br>

## 🎯 Why This Project Exists

I made **Iron Dome** to level up my Godot + C# skills and explore real-time defense mechanics. Concepts learned here are now used in my newer (and much better) games.

Think of this repo as a public dev journal — messy in places, but full of useful tricks:
- How to calculate intercept points between two moving objects
- Clean C# pattern for spawning & managing projectiles
- Making explosions that *feel* powerful

<br>

## 📸 Screenshots

| Incoming Wave | Successful Intercept | Game Over |
|---------------|----------------------|-----------|
| ![1](/.github/screen1.jpg) | ![2](/.github/screen2.jpg) | ![3](/.github/screen3.jpg) |

<br>

## 🎖️ Credits & Licenses

- Missile/City assets: Modified from [Kenney Rocket Pack](https://kenney.nl/assets) (CC0)
- Explosion particles: Heavily modified from public domain sources
- Sound effects: From [freesound.org](https://freesound.org) (credited in-game)

<br>

## 🚀 Getting Started (If You Want to Run It)

1. Install **Godot 4.2+ Mono** (C# version)
2. Clone the repo
   ```bash
   git clone https://github.com/ethqnit/Iron-Dome.git

Tools Used: 
Development Engine( Godot) https://godotengine.org
IDE (Visual Studio Code, Notepad++)
Development Language used (C#, HTML, JavaScript, CSS)
WebHosting(Free https://www.000webhost.com/
Dreamlo (database)  https://dreamlo.com/ (API) REST - Json,XML,CSV formats.
