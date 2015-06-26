using UnityEngine;
using System.Collections;

public class RandomRotationAction : ActionBase {
    public Vector3 MinRotation;
    public Vector3 MaxRotation;

    public override void Act() {
        transform.rotation = Quaternion.Euler(Vector3.zero + RandomRotation);
    }

    private Vector3 RandomRotation {
        get {
            return new Vector3(
                    Random.Range(MinRotation.x, MaxRotation.x), 
                    Random.Range(MinRotation.y, MaxRotation.y), 
                    Random.Range(MinRotation.z, MaxRotation.z));
        }
    }
}
