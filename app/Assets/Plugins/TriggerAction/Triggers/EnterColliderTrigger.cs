using UnityEngine;
using System.Collections;

public class EnterColliderTrigger : TriggerBase {
  public string Tag;

  void OnCollisionEnter(Collision collision) {
    Debug.Log("Collided");
    if (collision.gameObject.tag == Tag) {
      action.Act();
    }
  }
}
