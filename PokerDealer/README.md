# Poker Dealer Challenge

In this challenge you are asked to complete the program by completing the `Deck` constructor and the `DrawCard()` method. This challenge relies heavily on the use of `List<T>` and your knowledge of how to create and use them.

## Object Design

Think about a real deck of cards. How would you create a deck using code? What are the components of a deck? What are the components of a card?

Look carefully at the program's design before you start to write your code. Look at all the classes and see if you can understand how the pieces fit together. Are there any existing methods that you might use?

Look also at the `Main()` method of Program.cs. Look at the code and see if you can determine what it's supposed to do.

## Challenge 1 - Complete the Deck's Constructor

The constructor method need to return a fully populated deck of cards. They should be in order as if it were a fresh pack of cards straight from the box. Populate the deck of cards by adding them to the `_cards` global variable. When you think you're code is correct run the program. Did it display the deck of cards as outlined in Program.cs?

## Challenge 2 - Complete the `DrawCard()` Method

Think about a physical deck of cards, if you were drawing cards from the deck you'd take the first one off the deck and hand it to a player. Once that card is handed off it's no longer in the deck. How would you do the equivalent in code? (Remember your deck is stored in `_cards`).

## Bonus Challenges

### Multiple Sets of Cards

A normal deck has 52 cards.  Alter the `Deck` constructor to support an argument to indicate the number of card sets.  In other words: 1 &rarr; 52 cards, 2 &rarr; 104 cards, 3 &rarr; 156 cards, etc.

### Hand Classifier

Add a classifier to identify the type of hand for each player.  Examples: two pair, straight, flush.
