using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

public class Grägas : MonoBehaviour
{
    public GameObject Brick;
    public float delay;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        Brick.SetActive(true);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Invoke("DeactivateBrick", delay);
    }

    private void DeactivateBrick()
    {
        Brick.SetActive(false);
    }
}
