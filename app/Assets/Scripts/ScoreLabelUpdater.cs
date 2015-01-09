using UnityEngine;
using System.Collections;

public class ScoreLabelUpdater : MonoBehaviour {
  public UILabel UILabel;

  private void Start() {
    Events.instance.AddListener<ScoreChangedEvent>(OnScoreChange);
  }

  private void OnDestroy() {
    Events.instance.RemoveListener<ScoreChangedEvent>(OnScoreChange);
  }

  protected void OnScoreChange(ScoreChangedEvent e) {
    UILabel.text = e.Score.ToString();
  }
}
