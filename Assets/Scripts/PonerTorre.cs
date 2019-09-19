using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PonerTorre : MonoBehaviour
{
    public GameObject torre;

    private void OnMouseDown()
    {
        GameObject temp;
        Vector3 pos = this.transform.position;
        pos.y = pos.y + .4f;
        temp = Instantiate(torre);
        temp.transform.position = pos;
        temp.layer = 5;
        Destroy(this.gameObject);
    }
}
