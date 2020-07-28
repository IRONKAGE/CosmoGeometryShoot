# Cosmo Geometry Shoot
Unity 2019.4.X/Shooter/AR/Vuforia/Mobile

![GitHub](https://img.shields.io/github/license/IRONKAGE/CosmoGeometryShoot?style=plastic) ![Languges](https://img.shields.io/github/languages/count/IRONKAGE/CosmoGeometryShoot?style=plastic)

# About Game

🎲 Task:
Implement a game application using the Vuforia SDK. Use a standard astronaut as a “target”.

🎮 Mechanics:
From one end of the "target" 3 types of geometric objects (cylinder, sphere, cube) appear randomly one by one and immediately begin to move. When the other edge of the target is reached, the objects disappear. Each object has a random color when it appears. As soon as the user points the camera to the “target”, downcount appears on the UI: 3️⃣, 2️⃣, 1️⃣ Start. Then the game begins in which the player needs to “tap” on the screen to destroy objects before they reach the end of the target. In case of hitting an object, an explosion occurs, as a result of which the object is scattered into many similar shapes of the same color as itself (to be implemented using the Particle System). Each destroyed object adds + 1 point to the player's score displayed on the UI. Every 10 seconds the speed of objects increases by 20%. All objects rotate randomly. P.S. Not all implemented 🧐
