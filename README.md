# Blackjack_Kata

## Imagine you're working on a game with these principles in mind:

1. Single Responsibility Principle (SRP): The Player class handles player state and actions, while a PlayerRenderer class handles rendering the player on the screen.
2. Open/Closed Principle (OCP): You extend the game with new types of enemies by creating new subclasses of Dealer without modifying existing dealer classes.
3. Liskov Substitution Principle (LSP): You can use any subclass of Card in your game’s inventory system without altering the expected behavior of card-related functions.
4. Interface Segregation Principle (ISP): Players that are only meant to be moved don’t need to implement methods related to inventory.
5. Dependency Inversion Principle (DIP): The game engine depends on abstractions for input handling and rendering, allowing you to swap out or modify these components independently.
