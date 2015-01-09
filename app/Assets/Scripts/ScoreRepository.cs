using UnityEngine;
using System.Collections;

public class ScoreRepository : MonoBehaviour {
  public int Score = 0;

  private static ScoreRepository instance;
  public static ScoreRepository Instance {
    get {
      if (instance == null) {
        instance = GameObject.FindWithTag("ScoreRepository").GetComponent<ScoreRepository>();
      }

      return instance;
    }
  }

  public void AddPoints(int points) {
    Score += points;
    Events.instance.Raise(new ScoreChangedEvent(Score));
  }
}
