Predicted distance for Cube B: 25 units

| Cube | 30 fps | 60 fps | 144 fps |
|------|--------|--------|---------|
| A    |  755   |  1495  |  3555   |
| B    |25.0172 |25.0563 |25.0192  |
| C    |  1250  |  1250  |  1250   |

Why Cube A's numbers change: (2-3 sentences)
This is because Cube A's position calls the method once every frame, therefore the faster the framerate the more times the cube will move. 
For example Cube A being positioned 755 units means it is equal to: (5 * 30) * 5 



Cube C's distance does not change with frame rate, and it is also not 25. Explain both halves. 
Your answer must name the specific setting that determines how often FixedUpdate runs.

Cube C's distance does not change with frame rate because FixedUpdate() runs at a fixed interval rather than once per rendered frame which is, at default 0.02 seconds or 50 times per second.
Since Cube C moves 5 units every fixedUpdate() it travels by (5 seconds * 50 calls) * 5 moves = 1250 units.
