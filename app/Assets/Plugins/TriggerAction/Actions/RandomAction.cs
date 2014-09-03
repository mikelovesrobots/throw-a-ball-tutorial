﻿using UnityEngine;
using System;
using System.Collections;

public class RandomAction : ActionBase {
  public ActionBase[] Actions;

  public override void Act() {
    RandomChoiceAction.Act();
  }

  private ActionBase RandomChoiceAction {
    get { return Actions[UnityEngine.Random.Range(0, Actions.Length)];
    }
  }
}
