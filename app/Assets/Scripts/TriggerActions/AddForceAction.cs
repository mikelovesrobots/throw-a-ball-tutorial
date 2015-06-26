using UnityEngine;
using System.Collections;

public class AddForceAction : ActionBase {
  public Vector3 Force;
  public Vector3 RelativeForce;
  public Vector3 Torque;
  public Vector3 RelativeTorque;

  public ForceMode ForceMode = ForceMode.Force;

  public override void Act() {
    GetComponent<Rigidbody>().AddForce(Force, ForceMode);
    GetComponent<Rigidbody>().AddRelativeForce(RelativeForce, ForceMode);
    GetComponent<Rigidbody>().AddTorque(Torque, ForceMode);
    GetComponent<Rigidbody>().AddRelativeTorque(RelativeTorque, ForceMode);
  }
}
