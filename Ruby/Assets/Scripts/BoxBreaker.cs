using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxBreaker : MonoBehaviour
{
    public void Shatter()
    {
        Destroy(gameObject);
    }
}
