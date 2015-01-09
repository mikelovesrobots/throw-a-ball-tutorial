using UnityEngine;
using System.Collections;

public class RotationAction : ActionBase {
  public float AnimationTime = 1.0f;
  public Vector3 TargetRotation;
  public string EaseType = "easeInOutQuad";
  public string LoopType = "none";

  public override void Act() {
    var options = new Hashtable();
    options.Add("rotation", TargetRotation);
    options.Add("time", AnimationTime);
    options.Add("looptype", LoopType);
    options.Add("easetype", EaseType);
    options.Add("islocal", true);
    iTween.RotateTo(gameObject, options);
  }
}
