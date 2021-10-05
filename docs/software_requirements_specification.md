# Software Requirements Specification


## Overview     
 

This game will be a first-person RPG dungeon-crawler with a singleplayer focus. A pre-existing foundation in role-playing games is required to understand terminology in this Software Requirements Specification, such as "mage" or "ranger". Understanding the basic components to a video game ( i.e. main menu, the player, obstacles, the game world) is also required. This Software Requirements Specification document is designed to outline the requirements of the game and guide its development.

 
## Functional Requirements 
 
1. Should have a range of classes to play as.
	1. The game shall have class selection screen before entering into gameworld.
	2. The game shall have pre-defined classes to select from.
		1. The game shall have a ranger class.
		2. The game shall have a warrior class.
		3. The game shall have a mage class.
		4. The game shall have a rogue class.

2. Should have game feature where each class has a unique way to regenerate health
	1. The game shall require the ranger class to deal damage to the enemy's head to regenerate health.
	2. The game shall require the rogue class to deal damage to the enemy's flank to regenerate health.
	3. The game shall require the warrior class to perform a combo move on an enemy in order to regenerate health.
	4. The game shall require the mage class to balance their mana in order to regenerate health.
		1. When health is low the mage's mana regeneration shall be faster.
		2. When mana is low the mage's health regeneration shall be faster.

3. Should have ability to host a server
	1. The game shall have server hosting screen accessible from main menu.
	2. The game shall have ability for host to require a server password.
	3. The game shall have ability for host to set limit on number of players allowed on the server at once.

    		 

## Non-Functional Requirements 
 
1. Should be able run in multiple environments
	1. The game shall be playable in a web-browser.
	2. The game shall be playable in a Windows 7+ environment. 
	3. The game shall be playable in a Linux environment. 

2. Should have system requirements.
	1. The game shall be able to run on 4 GB RAM.
	2. The game shall be able to run on 512MB VRAM.
	3. The game shall require no more than 10 GB of storage.