using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    public GameObject prefab;
    public GameObject shootPoint;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Instantiate(prefab, shootPoint.transform.position, shootPoint.transform.rotation);
        }
        // GameObject Clone = Instantiate(prefab);
        // Clone.transform.position = shootPoint.transform.position;
        // Clone.transform.rotation = shootPoint.transform.rotation;
    }
}
