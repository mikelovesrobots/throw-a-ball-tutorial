using UnityEngine;
using System.Collections;

public class OnTriggerEnterTrigger : TriggerBase {
  private void OnTriggerEnter(Collider other) {
    Trigger();
  }
}
