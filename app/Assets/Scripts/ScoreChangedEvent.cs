using UnityEngine;
using System.Collections;

public class ScoreChangedEvent : GameEvent {
  public int Score;

  public ScoreChangedEvent(int score) {
    this.Score = score;
  }
}


