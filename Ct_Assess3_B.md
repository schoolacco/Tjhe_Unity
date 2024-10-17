# **Identifying a Need**
---
---
---

# **Brainstorming**
---
---
## **Mechatronics-based game**
|P|M|I|
|-|-|-|
|Interactive|I suck at coding Mechatronics|Connected to the real world|

## **Python-based game**
|P|M|I|
|-|-|-|
|Easier to code|More simplistic|-|
|-|Less interactive|-|

## **Unity - 2D Platformer**
|P|M|I|
|-|-|-|
|Simple controls|Generic|Has a large area for original ideas|
|Easy to code|Less interactive|-|

## **Unity - 2D Platformer**
|P|M|I|
|-|-|-|
|Simple controls|Generic|Has a large area for original ideas|
|Easy to code|Less interactive|-|

## **Unity - 3D Roll a Ball**
|P|M|I|
|-|-|-|
|Simple controls|Unoriginal and boring|May have area for gimmicks|
|Direct Tutorial|Less interactive|-|

## **Unity - 2D Roguelike**
|P|M|I|
|-|-|-|
|Simple controls|Repetitive gameplay loop|Large amount of room for originality|
|Direct Tutorial|-|-|

## **Unity - Top Down RPG**
|P|M|I|
|-|-|-|
|Simple controls|Repetitive gameplay loop|Large amount of room for originality|
|Direct Tutorial|Unoriginal|RPGs tend to be hard to execute well but if done correctly can work well|

## **_____ Fangame**
|P|M|I|
|-|-|-|
|Challenging|Requires prior skill to play|Based on a prior fanbase|
|Reasonably possible (similar has been made in Scratch)|Limited Audience|My personal choice|
|Top Down RPG code can be useful|SO MUCH SPRITE/MUSIC DESIGNING|Not directed towards a specific gender|

---
---

# **Need-Problem Statement**
---
---
## **Need:**
---
To provide an entertaining challenge for veteran players of the original game (and possibly an easier version for beginners)

---
## **Problem Statement**
---
Nearly all games are made for the purpose of entertainment, hence each game is made to cater to a specific audience of people who enjoy a specific aspect, my game is intended for prior players of _____ using similar mechanics and some unique ones to create a unique challenge for the player, although there are already many _____ fangames, there is no harm in having another (as long as it's well developed)

---
## **Skill Development**
---
Firstly to possibly develop a small overworld and develop the battle mechanics I will likely have to use the [2D Top Down RPG Tutorial](https://www.youtube.com/watch?v=JmyRnlXbZcA&list=PL6bqhqO0Ba776ksb3F9P_xmUMT9WvmfFT&index=51) (the other tutorial is blocked) and for the rest of the game I'll likely have to recreate scratch projects in Unity or try and find general help online.

---
---

# **Requirements Outline**
---
---
## **Inputs**
---
Be able to recieve keyboard inputs for menu navigation, general movement and inputs and recieve mouse clicks for hidden easter eggs.

* User inputs with directional arrows keys or WASD to move in the corresponding direction (in the menu, in the battle or in the overworld)
* User inputs with Z, X and C keys to interact with the menu (Z to interact, X to exit the specific part of the menu, C to quickly skip dialogue)
* User may be able to hover the cursor over specific areas of the screen and click to activate an easter egg
---
## **Processing**
---
The program is able to update variables based on previously mentioned inputs and collision with 'bullets' as well as in-game events.

* After the user input for movement the game will move the player across the menu or in the battle in the correspondingly related direction to the input
* After the user inputs a non-movement menu input it will update the menu depending on which option was selected
* After the user clicks in the correct place the program will update a related variable for the easter egg or immediately show it
* If the player has a skill issue and they get hit by a 'bullet' they will lose a set amount of health and recieve KARMA damage.
* If the user's health is 0 a small death animation will be played before being taken to the game over screen
* If the player wins a cutscene will be triggered (this may lead to further phases)
---
## **Outputs**
---
The program shows the user the corresponding movement/menu change/gameover/easter egg based on the previously mentioned process.

* When the player moves they will see the player character move (in battle or in the overworld)
* When the player moves in the menu they will the menu option change
* When the player inputs in the menu they will see the menu change
* When the player gets hit the displayed health will lower and the displayed KARMA will increase and a sound will play for every hit (no i-frames because the damage will be low)
* When the player triggers an easter egg it will be seen and they may recieve an achievement for it (also shown on screen)
* If the player dies they will see the death animation before being sent to the gameover screen (which they will also see)
* If the player wins they will witness a cutscene
---
## **Transmission**
---
**NIL**

* **NULL**
---
## **Storage**
---
Achievements and in-game progress (via checkpoints) is saved locally

* When the player earns an achievement it will be saved
* When the player reaches a checkpoint it will be saved
---
---
# **Functional Requirements**
---
---
## **User Interactions**
---

The user will able to use keyboard inputs (and some mouse clicks) to input (refer to the entire **Inputs** section)
