# 🕹️ My First Unity Test Game

A small experimental project to practice Unity and GitHub workflow.

---

## 🎮 Play
Download the latest 
Windows build inside.
[⬇️ DodgeGame.zip](https://github.com/klatestudio/DodgeGame/releases/latest/download/DodgeGame.zip)

## ✨ Features
- Random obstacles
- Simple player controller

## 🖼️ Screenshots
<p align="center">
 <img width="600" height="600" alt="image" src="https://github.com/user-attachments/assets/a19c428a-ea31-484f-bd1c-40fac13f901a" />

 <img width="600" height="600" alt="image" src="https://github.com/user-attachments/assets/8a865e6a-c240-4201-84a3-444a55d127cc" />

 <img width="600" height="600" alt="image" src="https://github.com/user-attachments/assets/3fb87ee2-1d25-47d5-a507-29308bc3053b" />


## 🧩 Scripts & Practice

This test game was mainly a playground to explore different Unity components and APIs.  
Scripts I wrote and experimented with:

- **Mover.cs** – Basic WASD/arrow-key movement using `transform.Translate`.
- **Trigger.cs** – Activates hidden objects when the player enters a trigger collider.
- **FlyAtPlayer.cs** – Moves an object toward the player and destroys it on contact.
- **Spinner.cs** – Continuously rotates an object each frame.
- **Dropper.cs** – Shows an object and enables gravity after a delay.
- **Scorer.cs** – Counts player collisions and logs score.
- **ObjectHit.cs** – Changes an object’s color when the player collides.

Key Unity APIs used: `MonoBehaviour`, `OnCollisionEnter`, `OnTriggerEnter`, `Time`, `Vector3.MoveTowards`, `MeshRenderer`, `Rigidbody`, and basic Input axes.

</p>

## 🛠️ Built With
- Unity 2022
- C#

---
