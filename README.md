[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-22041afd0340ce965d47ae6ef1cefeee28c7c493a6346c4f15d667ab976d596c.svg)](https://classroom.github.com/a/7qg5CCgx)
# HW2
## Devlog
The planned parts of the minigame were incorporated through creating a class for Player, Coin, and GameController. What I didn't expect was to create a separate class for the CoinSpawner. Game objects such as the player would interact with coin in order for the score UI to update. This was done through the coin having a collider and a rigidbody. I had the GameController be in charge of the coin script as well as the GameController script. When the coin moves off the screen, it gets deleted using and if statement with transform.position and the Destroy(gameObject) function under the Coin class. A Destroy function with OnTriggerEnter2D would allow the coin to disappear when the player collects it under the Player class. The coins are able to spawn because of an Update and SpawnCoin method. RandomRange can be used to tweak the interval of coin spawn as well as how many coins spawn by declaring a min and max value and using a random amount field in an array. Instantiate allows coins to be spawned where the Coin Spawner game object is placed in the scene. They are able to move towards the left in the Coin class' Update method. Using Vector3.left, we can multiply the speed and Time.deltaTime so the coins will move left every frame. 


## Open-Source Assets
If you added any other outside assets, list them here!
- [Sprout Lands sprite asset pack](https://cupnooble.itch.io/sprout-lands-asset-pack) - rabbit and item sprites
- [Pixel Penguin 32x32 Asset pack](https://legends-games.itch.io/pixel-penguin-32x32-asset-pack) - penguin sprites
- [Coins 2D](https://artist2d3d.itch.io/2d) - coin sprites
