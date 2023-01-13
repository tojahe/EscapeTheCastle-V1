# Escape the Castle                                                    
*Can you escape the castle by solving questions/riddles that get harder with every level? Be careful, once you're past level 1 every wrong answer will land you back in the cells.*


**- - - - - - - - - - M A P P I N G - - - - - - - - - -**

Ignore for now, need to make changes

![level1](https://user-images.githubusercontent.com/122262287/211813599-a3d16f4f-e5f6-46a2-95ee-c2893b5e81f7.png)

**- - - - - - - - - - G A M E - D E S I G N - - - - - - - - - -**

```
level 1 - the cells(in the cellar), Fairly easy questions and riddles - start the game by getting a random
number from a 1-4 dice, said number will put you on a path to answer. If you get them wrong you will end 
up in a loop until the correct answer puts you through to level 2.

Concept: users starts in the middle and is given a dice to roll, can only land on 1-4. User moves on said
path. They are then faced with an (easy) question. If they get this right they are moved onto level 2. If
they get the answer wrong they are then give another dice which can roll 1-2, this will take them to a 
riddle to solve, if they get this correct then they move onto level 2 - if they guess wrong again they
get put right back to the start with the 1-4 dice. 

-----------------------------------------------------------------------------------------------------------

level 2 - getting out of the castle, you will need to answer 1 riddle and 1 question of a medium difficulty,
getting both of these rightwill allow you to answer a mathematical question to put you to level 3. If you
answer incorrectly you will get put back to the cells, aka the start

Concept: users start in the middle again, given a dice to roll, can only land on 1-4 again. User moved on 
said path, they are then faced with one (medium) riddle and one (medium) question. answering both of these 
correct will give them a key to a chest that contains a scroll with a mathematical question - answer that 
correctly to move onto level 3. ANy wrong answers will put you back to the cellar.

-----------------------------------------------------------------------------------------------------------

Level 3 - escaping the castle grounds, you will need to answer 1 riddle, 1 general knowledge question, 1 true
or false and 1 mathematical question. 4 correct questions in a row will get you out. one wrong answer will 
put you back to the start of level 1.

Concept:users start in the middle again, given a dice to roll, can only land on 1-5. User has to answer a
(hard) riddle, (hard) general knowledge question, true or false question, 1 mathematical question. answering
all 4 questions correct will grant them the key to the gates so that they can make a run for it. If they
answer any questions incorrect they will get put back to the start of level 2.

-----------------------------------------------------------------------------------------------------------

Level 4, bonus level - you're running out of the castle grounds, just before you make it over the draw
bridge a dragon lands on it - flip the coin to get out - random answer to get out. If you're wrong you die

Concept: users is face to face with a dragon (think smaug) he will help you escape if you can correctly
guess if his coin will land heads or tails. if you guess correctly you mount the dragon and fly away to 
freedom. If you guess incorrectly you are eaten and LOSE. 
-----------------------------------------------------------------------------------------------------------

Winners message:

Congrats, you've won! want to try again?

Y/N

Y = start again
N = exit

Losers message:

Oh no. You were eaten by the dragon. Care to try again?

Y/N

Y = start again
N = display loser message in ascii
```
**- - - - - - - - - - E X T R A - D E T A I L S - - - - - - - - - -**

There will be a leaderboard that holds the users username along with time to completion.

The dragon coin is there to only make sure users do not easily win the game if they memorise answers.

