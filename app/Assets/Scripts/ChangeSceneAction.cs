using UnityEngine;
using System.Collections;

public class ChangeSceneAction : ActionBase {
  public string SceneName;

  public override void Act() {
    Application.LoadLevel(SceneName);
  }
}
