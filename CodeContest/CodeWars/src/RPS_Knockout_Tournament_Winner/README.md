## RPS Knockout Tournament Winner

A rock-paper-scissors robo player participates regularly in the same knockout tournament but almost always without success. Can you improve this robo player and make it a tournament winner?

### Task
* A match is between 2 players. The first that wins 20 games of Rock-Paper-Scissors is the winner of the match and continues to the next round. The other player is eliminated from the tournament.
* If your bot wins 5 rounds, the final included, it has won the tournament.
* The number of opponents is limited. Each opponent has its own strategy that does not change.
* The tournament is played on the preloaded `RockPaperScissorsPlayground`:

```csharp
RockPaperScissorsPlayground playground = new RockPaperScissorsPlayground();
bool result = playground.PlayTournament(myPayer);
```

This kata starts with a working bot, although it plays with a poor random strategy. It can compete on the `RockPaperScissorsPlayground` because it implements:

```csharp
public interface IRockPaperScissorsPlayer
{
    // Your name as displayed in match results.
    string Name { get; }    
    
    // Used by playground to notify you that a new match will start.
    void SetNewMatch(string opponentName);
    
    // Used by playground to get your game shape (values: "R", "P" or "S").
    string GetShape();
    
    // Used by playground to inform you about the shape your opponent played in the game. 
    void SetOpponentShape(string shape);
}
```

### Note
The best way to solve this kata is:

* Extend methods `get shape` and `set opponent shape` to make the patterns of your opponents visible to you and analyze their strategies and weaknesses.
* If the strategy of an opponent is clear to you, adapt your bot to the opponent.
* Continue until your bot can beat all opponents by skill instead of sheer luck.