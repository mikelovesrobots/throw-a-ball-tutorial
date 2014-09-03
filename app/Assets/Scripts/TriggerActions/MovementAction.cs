using UnityEngine;
using System.Collections;

public class MovementAction : ActionBase {
  public GameObject Target;
  public Vector3 TargetPosition;
  public string EaseType = "easeInOutQuad";
  public string LoopType = "none";
  public float Delay;
  public float AnimationTime;

  public override void Act() {
    var options = new Hashtable();
    options.Add("position", TargetPosition);
    options.Add("delay", Delay);
    options.Add("time", AnimationTime);
    options.Add("looptype", LoopType);
    options.Add("easetype", EaseType);
    options.Add("islocal", true);
    iTween.MoveTo(Target, options);
  }
}
