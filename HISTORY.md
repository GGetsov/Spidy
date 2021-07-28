# History
---

## Commit #8 - Score and more 
---
* Added: 
    - Script (Score) that keeps track of the score (number of webs moved correctly).
* Edited:
    - WebInputController - improved readability. 
    - YAxisMover - added actions for losing on wrong move and score counting improved readability.
    - LoseConditionChecker - added new lose condition (on wrong move) and improved readability. 
    - Unity files after update.
---

## Commit #7 - Lose Condition
---
* Added: 
    - Script (LoseConditionChecker) that checks if the Spider has walked over empty space (without a Web) and disables movement if has.
---

## Commit #6 - Player Controlled Webs
---
* Added: 
    - Script (WebInputController) that accepts input ('A' and 'D') and executes events.
    - GetKeyDownArgs class inside WebInputController.
    - Script (YAxisMover) that move Webs along the Y axis (1 block left or right) after input via the WebInputController events.
* Edited:
    - LeftOrRight - rearranged function order for better readability. 
    - HISTORY.md - fixed typos.
---

## Commit #5 - Random Web Respawn (Left or Right from center)
---
* Added: 
    - Script (LeftOrRight) that with help of the Spawn script respawns the Webs left or right from center randomly.
* Edited:
    - Spawn - added event OnRespawn that calls the function to respawn randomly left or right from center. 
    - Spawn - added OnRespawnArgs class inside Spawn. 
---

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
