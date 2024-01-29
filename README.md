This program simulates the movement of an object on a table using a set of commands. 
The table is represented as a matrix, and the object has an initial position and direction. 
The simulation follows a protocol, reading commands from stdin and outputting the final position or [-1, -1] if the object falls off the table.

To begin, you must input the table size and the object's initial position. The table size is specified as two integers (width and height), and the initial position is specified as two integers (x and y).

For example, to simulate a 4x4 table with the object starting at position (2, 3), you would input: 4,4,2,3.

The inputs are;
0: Quit simulation and print results
1: Move forward one step
2: Move backward one step
3: Rotate clockwise 90 degrees
4: Rotate counterclockwise 90 degrees

The inputs should be comma-seperated.

After entering all desired commands, the program will output the final position of the object or [-1, -1] if the object falls off the table.

To run the program, compile the code e.g in Visual Studio and follow the on-screen instructions to input table details and commands.
