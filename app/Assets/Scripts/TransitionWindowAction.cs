using UnityEngine;
using System.Collections;

public class TransitionWindowAction : ActionBase {
  public WindowTransitioner TargetWindow;
  public NavigationController NavigationController;

  public override void Act() {
    NavigationController.TransitionTo(TargetWindow);
  }
}
