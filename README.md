# UFO-game
a simple 2d ufo collection game
ide: unity 
script language: C#

# Player controll
sign movement compoment to player using Input.GetAxis horziantal and vertical function.
use rigidbody2D add force to sign movement on the game object
lock Z axis compoment using vector2 function.
select player object as trigger
write distory fucntion by set gameobject.setactive equal false to distory collectable object after it collected it.
store and calulate score in player object
set up win function and set win text to be display

# background scene
use box collider 2d to generate the egde.
add collider 2d on player object
the player will bounce back once it hit the edge
add text score: that store in player object
add win text and set to hide

# camera view
get player position
use vector3 to sign with player posistion.

# collectable object
add circle collider2d to collectable object
write tansdform.rotate to let the object rotating by sign in vectore3 value.

# Game start:
![ufo1](https://user-images.githubusercontent.com/15969187/40992268-5a09ceac-68c4-11e8-94e5-534c2d344793.png)

# Game in process:
![2](https://user-images.githubusercontent.com/15969187/40992320-7cb44798-68c4-11e8-89c7-1de08f2b007e.png)

# Game finished:
![3](https://user-images.githubusercontent.com/15969187/40992377-aa0c3dae-68c4-11e8-95ff-1117aa13de0f.png)
