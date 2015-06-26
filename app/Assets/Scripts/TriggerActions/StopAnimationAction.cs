using UnityEngine;
using System.Collections;

public class StopAnimationAction : ActionBase {
    public GameObject Target;

    public override void Act() {
        iTween.Stop(Target);
    }
}
