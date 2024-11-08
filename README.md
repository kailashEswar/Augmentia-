DragonController.cs:
This script controls how the dragon character moves and faces different directions based on joystick input. It detects the horizontal and vertical values from a joystick component in the scene, 
then adjusts the dragon’s speed and direction accordingly. Using a Rigidbody, the script applies physics-based movement, and it also rotates the dragon to face the direction it’s moving,
providing a smooth and natural movement experience in response to user control.

PrefabCreator.cs:
This script is responsible for placing a dragon model in an AR environment when a specific image is recognized by the device's camera. Using AR Foundation’s image tracking,
the script detects when a target image appears, then spawns the dragon model at that image’s location. It includes an adjustable position offset,
allowing the dragon to be slightly shifted from the exact image position. This setup creates an engaging AR interaction where the dragon appears anchored to a real-world image,
enhancing immersion and user interaction in the AR space.






