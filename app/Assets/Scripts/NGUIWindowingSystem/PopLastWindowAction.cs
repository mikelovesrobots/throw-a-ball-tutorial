using UnityEngine;
using System.Collections;

public class PopLastWindowAction : ActionBase {
  public NavigationController NavigationController;

  public override void Act() {
    NavigationController.Pop();
  }
}
