# History
---

## Commit #5 - Random Web Respawn (Left or Right from center)
---
* Added: 
    - Script (LeftOrRight) that with help of the Spawn script respawns the Webs left or right from center randomly.
* Edited:
    - Spawn - added event OnRespawn that calls the function to respawn randomly left or right from center. 
--- - Spawn - added OnRespawnArgs class

## Commit #4 - Movement
---
* Added: 
    - Script (Movement) that with help of the Spawn script moves the Webs and Background Walls, creating the illusion of the Spider climbing the wall.
* Edited:
    - Number of Webs controlled by Web Controller: 10 --> 12
    - Spawn point of Webs: -4.5 --> -6.5
    - Spawn point of Background Walls: 0 --> -12
--- 

## Commit #3 - Rename SampleScene to MainScene
---
* Renamed:
    - SampleScene.unity to MainScene.unity
    - SampleScene.unity.meta to MainScene.unity.meta
---

## Commit #2 - Spider, Web and Background
---
* Added: 
    - Spider.prefab - main character
    - Web.prefab - player controlled terrain
    - Background Wall.prefab - background
    - Scripts that return GameObject Arrays for other scripts to control (IControlledObjects,ChildrenController,SelfController)
    - Script that instantiates those GameObjects (Spawn)
* Edited:
    - README.md to include notice for missing art assets
---

## Commit #1 - Initial commit
---
* Added:
    - Empty Unity Project
    - .gitignore
    - README.md
    - HISTORY.md
