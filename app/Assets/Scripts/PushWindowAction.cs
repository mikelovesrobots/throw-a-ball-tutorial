using UnityEngine;
using System.Collections;

public class PushWindowAction : ActionBase {
  public WindowTransitioner TargetWindow;
  public NavigationController NavigationController;

  public override void Act() {
    NavigationController.Push(TargetWindow);
  }
}
