using UnityEngine;
using System.Collections;

public class MaterialChanger : MonoBehaviour {
    public MeshRenderer MeshRenderer;

    public void ChangeMaterial(Material material) {
        MeshRenderer.GetComponent<Renderer>().material = material;
    }
}
