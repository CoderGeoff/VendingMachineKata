VendingMachineKata
==================

This is my atttempt at a kata to create an object that behaves like a vending machine

#Instructions#

The vending machine has 

*	Seven selection buttons: numbered 0 - 6
*	*Cancel selection* and *Cancel transaction* buttons.  
*	a slot that accepts coins 
*	a tray for returning coins
*	a hopper where the purchased items are delivered
*	a two-line display; each line can show up to 20 characters. The top line is used for showing the item that has been selected and the bottom line for showing the amount of money required to make a purchase
*	capacity for 30 products, with item codes 012-016, 022-026, 032-036, 112-116, 122-126 and 132-136. Each is priced individually.

The machine allows users to select the item they want to buy by keying in the three-digit item code using the numbered keys, and inserting coins to cover the cost of the item. Once the machine has received a valid selection and sufficient money, it sends the purchased item to the hopper and any change to the coin tray. 

Your vending machine should have the following behaviours

1. When it first starts up, it enters the ready state. In this state, the machine displays “Ready”.
2. A user must key in a three-digit code using the seletion buttons to form a complete selection. If the selection buttons are pressed just once or twice, the selection is incomplete, and the machine displays “Selection incomplete: xy” where xy is the incomplete selection.
3. Once a complete selection of three digits has been keyed in, the machine changes its display; if the selection is a valid one, it displays “Selected: xyz”. If the selection is invalid, the machine displays “Selection invalid: xyz”.
4. Once a complete selection (valid or invalid) has been keyed in, subsequent presses of the selection buttons changes the selection by shifting the digits left. So, when wxy is selected and the z button is pressed, the selection changes to xyz.
5. At any time, pressing *Cancel selection* sets the machine to the state it would have had had no selection buttons been pressed. 
6. The user may insert coins into the machine at any point: before, during or after entering their selection.
7. If the current selection is valid and insufficient money has been inserted to buy the selected item, the machine displays “Insert “ followed by the amount of money the user must still insert to make the purchase. 
8. If the current selection is incomplete or invalid and some money has been inserted, the machine displays “xy inserted” where y is the total value of the inserted coins.
9. If the current selection is incomplete or invalid and no money has been inserted, the machine doesn’t display anything about money.
10. If at any time, the *Cancel transaction* button is pressed, the machine returns all the coins inserted since it was last in the ready state to the coin tray, cancels the current selection and returns to the ready state.
11. If at any time, the machine has a valid selection and amount of money inserted is sufficient to purchase the selected item, the machine transfers the item to the hopper, sends any change to the coin tray and returns to the ready state.


