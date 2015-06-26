using UnityEngine;
using System.Collections;

public class MoveByAction : ActionBase {
    public GameObject Target;
    public Vector3 Amount;
    public iTween.EaseType EaseType;
    public iTween.LoopType LoopType;
    public float Delay;
    public float AnimationTime;
    public bool IsLocal = true;

    public override void Act() {
        var options = new Hashtable();
        options.Add("position", TargetPosition);
        options.Add("delay", Delay);
        options.Add("time", AnimationTime);
        options.Add("looptype", LoopType);
        options.Add("easetype", EaseType);
        options.Add("islocal", IsLocal);
        iTween.MoveTo(Target, options);
    }

    private Vector3 TargetPosition {
        get {
            var position = IsLocal ? Target.transform.localPosition : Target.transform.position;
            return position + Amount;
        }
    }
}
