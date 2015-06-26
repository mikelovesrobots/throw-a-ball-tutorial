using UnityEngine;
using System.Collections;

public class MoveFromAction : ActionBase {
    public GameObject Target;
    public Vector3 TargetPosition;
    public iTween.EaseType EaseType;
    public iTween.LoopType LoopType;
    public float Delay;
    public float AnimationTime;
    public bool isLocal = true;

    public override void Act() {
        var options = new Hashtable();
        options.Add("position", TargetPosition);
        options.Add("delay", Delay);
        options.Add("time", AnimationTime);
        options.Add("looptype", LoopType);
        options.Add("easetype", EaseType);
        options.Add("islocal", isLocal);
        iTween.MoveFrom(Target, options);
    }
}
