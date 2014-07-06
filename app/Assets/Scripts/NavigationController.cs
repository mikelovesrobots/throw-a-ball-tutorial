using UnityEngine;
using System;
using System.Linq;
using System.Collections.Generic;

public class NavigationController : MonoBehaviour {
  public string WindowGroup;
  public WindowTransitioner[] Windows;
  public WindowTransitioner StartingWindow;
  private WindowTransitioner currentWindow;
  private Stack<WindowTransitioner> HistoryStack = new Stack<WindowTransitioner>();

  public void Initialize() {
    Initialize(null);
  }

  public void Initialize(WindowTransitioner windowOverride) {
    if (windowOverride != null) {
      ShowWindow(windowOverride);
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
    CurrentWindow = window;
    window.Show();
  }

  private void TransitionTo(WindowTransitioner window) {
    Action ShowNextWindow = () => {
      ShowWindow(window);
    };

    if (CurrentWindow != null) {
      CurrentWindow.Hide(ShowNextWindow);
    } else {
      ShowNextWindow();
    }
  }

  public void Push(WindowTransitioner window) {
    if (CurrentWindow != null) {
      HistoryStack.Push(CurrentWindow);
    }

    TransitionTo(window);
  }

  public void Pop() {
    TransitionTo(HistoryStack.Pop());
  }

  private WindowTransitioner CurrentWindow {
    set { currentWindow = value; }
    get { return currentWindow; }
  }

  private bool HasStartingWindow {
    get { return StartingWindow != null; }
  }

}
