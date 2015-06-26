using UnityEngine;
using System.Collections;

public class ScaleAction : ActionBase {
    public GameObject Target;
    public Vector3 TargetScale;
    public iTween.EaseType EaseType;
    public iTween.LoopType LoopType;
    public float Delay = 0f;
    public float AnimationTime = 0.25f;

    public override void Act() {
        var options = new Hashtable();
        options.Add("scale", TargetScale);
        options.Add("delay", Delay);
        options.Add("time", AnimationTime);
        options.Add("looptype", LoopType);
        options.Add("easetype", EaseType);
        iTween.ScaleTo(Target, options);
    }
}
