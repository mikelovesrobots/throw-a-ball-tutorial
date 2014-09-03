using UnityEngine;
using System.Collections;

public class RecolorWidgetAction : ActionBase {
  public UIWidget UIWidget;
  public Color Color;

  public override void Act() {
    UIWidget.color = Color;
  }
}
