# Overview 
 
This game will be a first-person RPG dungeon-crawler with a singleplayer focus. The typical user expected to play the game are PC gamers comfortable with a first person perspective and control scheme ( i.e. WASD, shift to sprint, control to crouch). A pre-existing foundation in role-playing games is required to understand terminology in this Software Requirements Specification, such as "mage" or "ranger". Understanding the basic components to a video game ( i.e. main menu, the player, obstacles, the game world) is also required. This Software Requirements Specification document is designed to outline the requirements of the game and guide its development.

 
# Software Requirements 
 
This section is composed of two main categories: Functional requirements and Nonfunctional requirements.
Further, each set of functional and nonfunctional requirements is composed of subcategories which focus on similar game-design aspects. 
Each subcategory is composed of game features.
Each game feature is composed of detailed and specific requirements.
 
## Functional Requirements

### Enemy Behavior
 
#### The game should have enemies to automatically attack the player. 
 
| ID  | Requirement     |  
| :-------------: | :----------: |  
| FR1 | Enemies shall have a "spotting range", a vicinity the player must be within for the enemy to recognize the player and approach them |  
| FR2 | Enemies shall have an "attack range", a vicinity the player must be within before the enemy will start attacking. |  
| FR2.1 | The "attack range" shall be a smaller vicinity than the "spotting range" |  
| FR3 | Enemies shall have a defined spawn point which they return to if the player leaves the "spotting range" | 
| FR3.1 | Enemies shall respawn at their specified spawn point after being killed | 

### Player Behavior
 
#### The player should be able to select from and play as multiple pre-defined classes.
 
| ID  | Requirement     |  
| :-------------: | :----------: | 
| FR4 | The game shall have pre-defined classes for the player to select from | 
| FR4.1 | The game shall be able to choose a different class upon each new start |
| FR4.2 | The game shall have a ranger class |  
| FR4.3 | The game shall have a warrior class |  
| FR4.4 | The game shall have a mage class |

### User Interface

#### The game should have a main menu.
 
| ID  | Requirement     |  
| :-------------: | :----------: | 
| FR5 | The game shall present the main menu when first launched. |  
| FR6 | The main menu shall have a background scene |  
| FR7 | The main menu shall have a "QUIT" button to exit the game |  
| FR8 | The main menu shall give the player access to the OPTIONS menu via a button |
| FR9 | The main menu shall give the player access to the CLASS SELECTION menu via a button |

#### The game should have an options menu
 
| ID  | Requirement     |  
| :-------------: | :----------: | 
| FR10 | The game shall have an options menu that is accessible through the main menu |  
| FR11 | The options menu shall allow the player the adjust different game volumes |  
| FR11.1 | The options menu shall allow the player to adjust the music volume |  
| FR11.2 | The options menu shall allow the player to adjust the ambient noise volume |

#### The game should present the player with a list of classes to choose from.
 
| ID  | Requirement     |  
| :-------------: | :----------: | 
| FR12 | The game shall have a class selection screen that is accessible through the main menu |  
| FR13 | The game shall present the player with brief information about the class they want to choose |  
| FR13.1 | The game shall preview the physical appearance of a class to the player |  

 
## Non-Functional Requirements 
 
#### The game should be responsive 
 
| ID  | Requirement     |  
| :-------------: | :----------: |  
| NFR1 | The game shall be built using the WebGL API |  
| NFR2 | The game shall be playable within a WebGL-supported internet browser | 
| NFR3 | The game shall be playable on a Windows 7+ environment | 
| NFR4 | The game shall use keyboard inputs for user interaction | 
| NFR5 | The game shall respond immediately to player input | 

#### The game should be playable on simple machines
 
| ID  | Requirement     |  
| :-------------: | :----------: |  
| NFR6 | The game shall require less than 4GB of RAM to run |  
| NFR7 | The game shall require less than 512MB of VRAM to run | 
| NFR8 | The game shall require no more than 10GB of storage | 
| NFR9 | The game shall run on any current generation CPU's | 
| NFR10 | The game shall run on any HDMI compatible monitor | 


#### The game should have basic performance
 
| ID  | Requirement     |  
| :-------------: | :----------: |  
| NFR11 | The game shall run at 30fps | 
| NFR12 | The game shall render 2 chunks at a time | 
| NFR13 | The game shall have less an 1ms delay between actions performed | 
| NFR14 | The game shall render in 1080p | 
| NFR15 | The game shall accept ping no higher than 150ms | 


# Software Artifacts 

This section is meant to detail the project timeline, present the tasks required to complete the project, and provide supporting diagrams to better understand some of the features presented above.

## Use Case Diagrams
 
* [Enemy-Player Interaction](../artifacts/use_case_diagrams/CIS350UseCaseExtended.pdf)
* [Player-Shop Interaction](../artifacts/use_case_diagrams/CIS350UseCase.pdf)
* [Player-Skill System Interaction](../artifacts/use_case_diagrams/APT_skill_usecase.jpg)

## Project Schedule

* [Gantt Chart Project Timeline](CIS350_Project_Gantt_Chart.pdf)
* [Project Tasklist](projectschedule_and_tasklist.md)

## Project Proposal

* [Project Proposal](proposal-template.md)
* [Project Proposal Presentation](CIS350_RPGenius_Proposal_Presentation.pdf)
