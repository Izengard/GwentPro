# Game Logics

## NonTerminals

Game: StartGame - Round - Round - Round* - EndGame
    StartGame: SET LEADERS - SET DECKS  - SetHands
        SetHands: INITIAL_DRAW - SWAP_TWO_CARDS
    EndGame: 
Round:  ROUND_DRAW - p1Turn - p2Turn - ((p1Turn)* - (p2Turn)*)* - EndRound
    EndRound:  DETERMINE_WINNER - DESTROY_FIELD_CARDS
Turn: PlayCard | ACTIVATE_LEADER_SKILL | PASS
    PlayCard: SUMMON_CARD_FROM_HAND - ACTIVATE_CARD_SKILL

## Terminals

SET_LEADERS:Set each player leader to its corresponding squares.
SET_DECKS: Set each player decks to its corresponding squares.
FIRST_DRAW: Each player Draw 10 Cards.
SWAP_TWO_CARDS: Each player may select up to two cards, send them to deck , then draw two cards. Randomize decks.
DETERMINE_WINNER: Get Each Player's Field Total Power and the player with greater Total Power wins
DESTROY_FIELD_CARDS: Send all Card in the field, and Weathers to Graveyard.
ACTIVATE_LEADER_SKILL: Activate the leader special skill
PASS: End this turn and the player can't play anymore for the rest of the round.
SUMMON_CARD_FROM_HAND: Set a Card from the Hand to the Field.  Weather?
ACTIVATE_CARD_SKILL: Activate the Card's Special Skill.

    
    

	
		