# Dead Stand*
Multiplayer shooter in post-apocalyptic world. Play with friends in team PvP deathmatches! 

*Attention! This repo is a cut demo version of the project for code review (not for Unity Editor).

Site: www.playstel.com/deadstand

Trailer: www.youtube.com/watch?v=Zw6ZX3bwcB4

PlayFab - Database & Server:
---

Database stores info about rules, items, players, their inventory, statistics, and more.
The server processes all transactions and makes sure that clients do not cheat.

Photon Unity Network - Realtime Network:
---

This network creates rooms and shares the states of the players in those rooms.
It should work really quickly because the sync of actions between players depends on it.

Amazon S3 - Content Delivery Network:
---

Another network service store and retrieve game content: objects, materials, audio, UI, sprites, and game scenes. 
This makes it easy to update content and reduce build size.

Integrations:
---
Zenject DI Framework, Addressables Asset System,
UniTasks, Eventbus, Animation Rigging,
Universal RP, Shader Graph

Soft:
---
Unity 3d, Jet-Brains Rider, Adobe Illustrator, Adobe Premiere Pro, Notion, XMind

Assets:
---
DO-tween Animation Engine, Anti-Cheat Toolkit,
Text Animator, Iron Source, A* Pathfinding, Mesh Combiner, 
Synty Art Assets, Lean GUI, etc.
