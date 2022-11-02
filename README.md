# GED-Challenge

Nathan Woo 100787454

1+0+0+7+8+7+4+5+4 = 36 (even)

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