using UnityEngine;
using System;
using System.Collections;

public class WindowTransitioner : MonoBehaviour {
  private const float ANIMATION_TIME = 0.25f;
  public UIPanel[] Panels;
  public WindowInitializer OptionalWindowInitializer;

  public string Name {
    get { return gameObject.name; }
  }

  public void Show() {
    Transition(0f, 1f);
    gameObject.SetActive(true);
    if (OptionalWindowInitializer != null) {
      OptionalWindowInitializer.Initialize();
    }
  }

  public void Hide() {
    Hide(() => {});
  }

  public void Hide(Action callback) {
    Transition(1f, 0f);
    StartCoroutine(WaitThenDisable(callback));
  }

  private IEnumerator WaitThenDisable(Action callback) {
    yield return new WaitForSeconds(ANIMATION_TIME);
    gameObject.SetActive(true);
    callback();
  }

  private void Transition(float from, float to) {
    var options = new Hashtable();
    options.Add("from", from);
    options.Add("to", to);
    options.Add("time", ANIMATION_TIME);
    options.Add("easetype", "easeinoutquad");
    options.Add("onupdate", "TweenAlpha");
    options.Add("onupdatetarget", gameObject);
    iTween.ValueTo(gameObject, options);
  }

  private void TweenAlpha(float alpha) {
    foreach (var panel in Panels) {
      panel.alpha = alpha;
    }
  }
}
