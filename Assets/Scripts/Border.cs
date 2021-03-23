using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Border : MonoBehaviour
{
    public event Action<GameObject, bool> PlayerFall = delegate { };

    private void OnTriggerEnter(Collider other)
    {
        PlayerFall(other.transform.root.gameObject, true);
    }
}
