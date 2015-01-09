using UnityEngine;
using System.Collections;

public class MetronomeTrigger : MonoBehaviour {
  public float DelayInSeconds = 0.5f;
  public ActionBase Action;

  void Start () {
    StartCoroutine(DelayThenTick());
  }

  IEnumerator DelayThenTick() {
    yield return new WaitForSeconds(DelayInSeconds);
    Action.Act();
    StartCoroutine(DelayThenTick());
  }
}
