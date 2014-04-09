using UnityEngine;
using System.Collections;

public class ColorCycler : MonoBehaviour {
  public Color[] Colors;
  public int ColorIndex = 0;

  public void Reset() {
    ColorIndex = 0;
  }

  public Color Next() {
    var color = Colors[ColorIndex];
    IncrementCycle();
    return color;
  }

  private void IncrementCycle() {
    ColorIndex++;
    if (ColorIndex >= Colors.Length) {
      ColorIndex = 0;
    }
  }
}
