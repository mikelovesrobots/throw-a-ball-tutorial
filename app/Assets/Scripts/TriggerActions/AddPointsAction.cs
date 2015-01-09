using UnityEngine;
using System.Collections;

public class AddPointsAction : ActionBase {
  public int Points = 100;

  public override void Act() {
    ScoreRepository.Instance.AddPoints(Points);
  }
}
