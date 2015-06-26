using UnityEngine;
using System.Collections;

public class RotationAction : ActionBase {
    public GameObject Target;
    public Vector3 TargetRotation;
    public iTween.EaseType EaseType;
    public iTween.LoopType LoopType;
    public bool IsLocal = true;
    public float Delay = 0f;
    public float AnimationTime = 0.25f;

    public override void Act() {
        var options = new Hashtable();
        options.Add("rotation", TargetRotation);
        options.Add("delay", Delay);
        options.Add("time", AnimationTime);
        options.Add("islocal", IsLocal);
        options.Add("looptype", LoopType);
        options.Add("easetype", EaseType);
        iTween.RotateTo(Target, options);
    }
}
