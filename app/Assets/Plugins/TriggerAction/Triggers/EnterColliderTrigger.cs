using UnityEngine;
using System.Collections;

public class EnterColliderTrigger : TriggerBase {
  public bool RequireTag;
  public string Tag;

  void OnCollisionEnter(Collision collision) {
    if (RequireTag) {
      if (collision.gameObject.tag == Tag) {
        action.Act();
      }
    } else {
      action.Act();
    }
  }
}
