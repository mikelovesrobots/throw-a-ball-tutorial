using UnityEngine;
using System;
using System.Linq;

public class NavigationController : MonoBehaviour {
  public string WindowGroup;
  public WindowTransitioner[] Windows;
  public WindowTransitioner StartingWindow;
  private WindowTransitioner currentWindow;

  private void Start() {
    if (IsReturning) {
      ShowWindow(ReturningWindow);
    } else if (HasStartingWindow) {
      ShowWindow(StartingWindow);
    }
  }

  public void ShowNext() {
    TransitionTo(NextWindow);
  }

  public void ShowPrev() {
    TransitionTo(PrevWindow);
  }

  private WindowTransitioner PrevWindow {
    get { return Windows[PrevIndex]; }
  }

  private WindowTransitioner NextWindow {
    get { return Windows[NextIndex]; }
  }

  private int NextIndex {
    get { 
      var index = Array.IndexOf(Windows, currentWindow) + 1;
      if (index == Windows.Length) {
        index = 0;
      }
      return index;
    }
  }

  private int PrevIndex {
    get { 
      var index = Array.IndexOf(Windows, currentWindow) - 1;
      if (index < 0) {
        index = Windows.Length - 1;
      }
      return index;
    }
  }

  private void ShowWindow(WindowTransitioner window) {
    window.Show();
    CurrentWindow = window;
    Analytics.changeScreen(window.Name);
  }

  public void TransitionTo(WindowTransitioner window) {
    Action ShowNextWindow = () => {
      ShowWindow(window);
    };

    if (CurrentWindow != null) {
      CurrentWindow.Hide(ShowNextWindow);
    } else {
      ShowNextWindow();
    }
  }

  private WindowTransitioner CurrentWindow {
    set { 
      currentWindow = value; 
      HomeOptions.WindowRegistry.Register(WindowGroup, value.gameObject.name);
    }
    get { 
      return currentWindow;
    }
  }

  private bool IsReturning {
    get { return HomeOptions.WindowRegistry.Exists(WindowGroup); }
  }

  private WindowTransitioner ReturningWindow {
    get { 
      var lastWindowName = HomeOptions.WindowRegistry.Find(WindowGroup);
      return Windows.Single(window => window.gameObject.name == lastWindowName); 
    }
  }

  private bool HasStartingWindow {
    get { return StartingWindow != null; }
  }

}
