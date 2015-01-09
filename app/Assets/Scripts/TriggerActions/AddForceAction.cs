using UnityEngine;
using System.Collections;

public class AddForceAction : ActionBase {
  public Vector3 Force;
  public Vector3 RelativeForce;
  public Vector3 Torque;
  public Vector3 RelativeTorque;

  public ForceMode ForceMode = ForceMode.Force;

  public override void Act() {
    rigidbody.AddForce(Force, ForceMode);
    rigidbody.AddRelativeForce(RelativeForce, ForceMode);
    rigidbody.AddTorque(Torque, ForceMode);
    rigidbody.AddRelativeTorque(RelativeTorque, ForceMode);
  }
}
