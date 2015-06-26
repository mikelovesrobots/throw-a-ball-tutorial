using UnityEngine;
using System.Collections;

public class FadeWidgetAction : ActionBase {
    public UIWidget Widget;
    public float StartAlpha;
    public float EndAlpha;
    public float AnimationTime = 0.25f;
    public float Delay = 0f;
    public iTween.EaseType EaseType;

    public override void Act() {
        var options = new Hashtable();
        options.Add("from", StartAlpha);
        options.Add("to", EndAlpha);
        options.Add("time", AnimationTime);
        options.Add("delay", Delay);
        options.Add("easetype", EaseType);
        options.Add("onupdate", "TweenAlpha");
        options.Add("onupdatetarget", gameObject);
        iTween.ValueTo(gameObject, options);
    }

    private void TweenAlpha(float alpha) {
        Widget.alpha = alpha;
    }
}
