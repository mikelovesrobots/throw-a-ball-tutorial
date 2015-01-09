using UnityEngine;
using System.Collections;

public class AddForceAction : ActionBase {
  public Vector3 Force;
  public Vector3 RelativeForce;
  public Vector3 Torque;
  public Vector3 RelativeTorque;

  public override void Act() {
    rigidbody.AddForce(Force);
    rigidbody.AddRelativeForce(RelativeForce);
    rigidbody.AddTorque(Torque);
    rigidbody.AddRelativeTorque(RelativeTorque);
  }
}
