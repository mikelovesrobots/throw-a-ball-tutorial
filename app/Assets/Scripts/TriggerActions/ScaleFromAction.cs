using UnityEngine;
using System.Collections;

public class ScaleFromAction : ActionBase {
    public GameObject Target;
    public Vector3 Scale;
    public iTween.EaseType EaseType;
    public iTween.LoopType LoopType;
    public float Delay = 0f;
    public float AnimationTime = 0.25f;

    public override void Act() {
        var options = new Hashtable();
        options.Add("scale", Scale);
        options.Add("delay", Delay);
        options.Add("time", AnimationTime);
        options.Add("looptype", LoopType);
        options.Add("easetype", EaseType);
        iTween.ScaleFrom(Target, options);
    }
}
