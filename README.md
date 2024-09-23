# Sett_test_task

![image](https://github.com/user-attachments/assets/6729541c-13f5-47a7-a861-88318d174263)


In this exercise you will build simple robots.
Each robot is a gameobject (can be a cube) with a list of instructions.
Each instruction is a list of commands and each command can be one of the following three:
* Move to position
* Rotate to angle
* Change color

Each command also has a time parameter for defining how long the action should take. So for example robot 1 can have two instructions:
* Move to (1,0,0), then Rotate to (90,0,0), then move to (1,1,0)
* Rotate to (45,45,45), then change Color to (1,0,0,1), then move to (1,1,0)

Create the code that represents the instructions, and write a function to execute it. 
Create a sample robot and run it.

Make the instruction creation easy and intuitive and make sure it is easy to apply changes to the robots.
