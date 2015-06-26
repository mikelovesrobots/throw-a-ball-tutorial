using UnityEngine;
using System.Collections;

public class ShakeAction : ActionBase {
    public GameObject Target;
    public Vector3 Amount;
    public iTween.LoopType LoopType;
    public float Delay;
    public float AnimationTime;
    public bool IsLocal;

    public override void Act() {
        var options = new Hashtable();
        options.Add("amount", Amount);
        options.Add("delay", Delay);
        options.Add("time", AnimationTime);
        options.Add("looptype", LoopType);
        options.Add("islocal", IsLocal);
        iTween.ShakePosition(Target, options);
    }
}
