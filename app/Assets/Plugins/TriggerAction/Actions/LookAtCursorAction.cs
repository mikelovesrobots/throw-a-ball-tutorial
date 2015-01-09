using UnityEngine;
using System.Collections;

public class LookAtCursorAction : ActionBase {
  public Transform Transform;
  public float DistanceFromCamera = 100.0f;

  public override void Act() {
    var target = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, DistanceFromCamera));
    Transform.LookAt(target);
  }
}
