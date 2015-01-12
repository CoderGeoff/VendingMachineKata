#Vending Machine: 1st kata session#
 
##Problem: Build a machine with a simple button pad##
This is the first kata in a series of x. The aim of this kata is to build a class that will evolve to become the vending machine.

##Learning objective: using Single Responsibility to create a design that can be extended easily##
Your aim is to build just the beginning of a simple vending machine. You will extend this  you will extend in later katas. Your code should therefore keep an eye separating distinct entities to limit the impact of future changes. Good quality tests will also help you later on.


###Tasks###

The machine you will build in this kata has 
* a button pad with 
  * the selection buttons 0 - 6 
  * the *Clear Selection* button
* a *Display* with two rows

1. Set a up suitable working environment, with a VisualStudio solution in a repository on GitHub 
The machine should
2. display the "Ready" message when it powers up into the ready state
3. display the current selection when it's incomplete
4. display any three-digit selection as if it were a valid selection (i.e. it should treat all selections as valid)
5. return to the ready state when the *Cancel Selection* button is pressed

