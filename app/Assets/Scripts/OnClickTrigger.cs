using UnityEngine;
using System.Collections;

public class OnClickTrigger : MonoBehaviour {
  public float MinTimeBetweenPresses = 1f;
  public ActionBase Action;
  private bool isDisabled = false;

  void OnClick() {
    if (!isDisabled) {
      Action.Act();
      if (ShouldWaitBetweenPresses) {
        isDisabled = true;
        StartCoroutine(WaitThenRespondToClicksAgain());
      }
    }
  }

  private IEnumerator WaitThenRespondToClicksAgain() {
    yield return new WaitForSeconds(MinTimeBetweenPresses);
    isDisabled = false;
  }

  private bool ShouldWaitBetweenPresses {
    get { return MinTimeBetweenPresses > 0f; }
  }
}
