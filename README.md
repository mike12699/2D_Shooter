# 2D_Shooter
A simple 2D platformer shooter with inspirations from the Metroid games

*Update 12/08/2021*:
I added some UI assets for the player and the enemies. I included animations for both of these as well. When the player shoots at the enemies enough times, they will trigger a death state. As of now, there is no win state yet, and I plan to implement that by next week. The intent was to make the player reach the end of the level, which will trigger the end state of the game. I feel like I have been going at a steady pace, but at this rate, only one level will be finished for the final. I have implemented the building blocks of the game already, so it's just a matter of time to add the remaining assets.

*Update 12/15/2021*:
I touched up on the gameplay mechanics of this game. There is a score tracker on the top right of the screen. When a player kills an enemy, the score will add up by one. When all enemies are killed (points reach to 10) the player wins the game. The top left of the screen includes the lives counter. However, this feature does not work. My intent was that when an enemy touches the player, the player will lose a life. When the lives reach zero, it's game over. I also added an invisibility shader effect for the player. When the left mouse button is clicked, the player will turn invisible and still move and shoot around. However, once it is triggered the player cannot revert back to normal. Finally, the instructions panel can be displayed on the title screen to view the controls. Overall, I am satisfied with this build and plan to work on it more in the future.

*Update 03/23/2022:*
I added some coding for AI components on some enemies. Some should follow the player trying to attack. One enemy will move back and forth on a platform using a waypoint system. Most of these updates will be polished up in the future to make the game more appealing.
