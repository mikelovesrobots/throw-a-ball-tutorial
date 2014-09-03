using UnityEngine;
using System.Collections;

public class SceneTransitionAction : ActionBase {
  public string Level;

  public override void Act() {
    SceneTransitioner.Instance.TransitionTo(Level);
  }
}
