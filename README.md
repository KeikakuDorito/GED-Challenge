# GED-Challenge

Nathan Woo 100787454

1+0+0+7+8+7+4+5+4 = 36 (even)


Materials were used from the lab, namely the player movement, input system and the CommandInvoker.



Gameplay Video:
https://www.youtube.com/watch?v=awYlHBXHits&ab_channel=NintendoComplete

## Ice Climbers

Controls:

A - Move Left

D - Move Right

Space - Jump


## Singleton

GameManager holds a Singleton pattern called "Player Health Manager," which instantiates itself and ensures only one instance of itself exists. It's has two public methods that are accessible by all classes: ChangeHealth() and GetHealth().


When the player touches the enemy (sphere on the left of the player's spawn), the player's health will be reduced by 1. The UI will update using info from GetHealth in the singleton.


A singleton is beneficial for  this situation as there will be no new instances of the HealthManager created per event. This way, one instance can manage all types of events where a value of health is involved, and there will be no confusion or new values created for health.



## Command

A Command Interface called ICommand is created as a interface for all commands. All commands will be derived from ICommand to ensure all commands have the Execute and Undo methods.

The command "DestroyBrickCommand" inherits ICommand, with it's own definitions of Execute and Undo. When the the command is called by the client (in this case, the hitbox of the player), the command will be added to the queue of the command invoker, whcih will execute the command. When executed, the command will call "BrickDestroyer" to with the information of which brick to destroy the specificed brick.

When undone, the brick will be placed back at it's previous position.