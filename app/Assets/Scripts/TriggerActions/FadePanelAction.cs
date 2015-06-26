using UnityEngine;
using System.Collections;

public class FadePanelAction : ActionBase {
    public UIPanel Panel;
    public float TargetAlpha;
    public float AnimationTime = 0.25f;
    public float Delay = 0f;
    public string EaseType = "easeInOutQuad";

    public override void Act() {
        var options = new Hashtable();
        options.Add("from", Panel.alpha);
        options.Add("to", TargetAlpha);
        options.Add("time", AnimationTime);
        options.Add("delay", Delay);
        options.Add("easetype", EaseType);
        options.Add("onupdate", "TweenAlpha");
        options.Add("onupdatetarget", gameObject);
        iTween.ValueTo(gameObject, options);
    }

    private void TweenAlpha(float alpha) {
        Panel.alpha = alpha;
    }
}
