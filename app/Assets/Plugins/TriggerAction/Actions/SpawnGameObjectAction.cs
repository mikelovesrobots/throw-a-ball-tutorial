using UnityEngine;
using System.Collections;

public class SpawnGameObjectAction : ActionBase {
    public GameObject Prefab;
    public Transform Parent;

    public bool IsTemporary;
    public float Lifespan;

    public override void Act() {
        GameObject instance = GameObject.Instantiate(Prefab, transform.position, transform.rotation) as GameObject;

        if (IsTemporary) {
            GameObject.Destroy(instance, Lifespan);
        }

        instance.transform.parent = Parent;
    }
}
