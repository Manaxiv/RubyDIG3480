using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class ExplosionScript : MonoBehaviour
{
    public float vidLength;
    private float vidTime;

    // Start is called before the first frame update
    void Start()
    {
        vidTime = vidLength;
    }

    // Update is called once per frame
    void Update()
    {
        vidTime -= Time.deltaTime;
            if (vidTime < 0)
                Destroy(gameObject);
        
    }
}
