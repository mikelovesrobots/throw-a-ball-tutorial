using UnityEngine;
using System.Collections;

public class PunchAction : ActionBase {
    public GameObject Target;
    public float AnimationTime;
    public Vector3 Position;

    public override void Act() {
        iTween.PunchPosition(Target, Position, AnimationTime);
    }
}
