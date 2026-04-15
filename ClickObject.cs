using UnityEngine;

public class ClickObject : MonoBehaviour
{
    private Renderer rend;

    void Start()
    {
        rend = GetComponent<Renderer>();
    }

    void OnMouseDown()
    {
        rend.material.color = new Color(Random.value, Random.value, Random.value);
        Debug.Log("Objet cliqué : " + gameObject.name);
    }
}
