using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class WindowRegistry {
  private Dictionary<string, string> db = new Dictionary<string, string>();

  public void Register(string group, string name) {
    db[group] = name;
  }

  public bool Exists(string group) {
    return db.ContainsKey(group);
  }

  public string Find(string group) {
    return db[group];
  }

  public void Reset() {
    db.Clear();
  }
}
