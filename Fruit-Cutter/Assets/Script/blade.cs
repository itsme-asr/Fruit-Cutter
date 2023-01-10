using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blade : MonoBehaviour
{
    bool isCutting = false;
    Rigidbody2D rgb;
    Camera cam;
    [SerializeField] private GameObject bladePreFab;
    GameObject currentTrail;

    CircleCollider2D col;

    private void Start()
    {
        cam = Camera.main;
        rgb = GetComponent<Rigidbody2D>();
        col = GetComponent<CircleCollider2D>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            startCutting();
        }
        else if (Input.GetMouseButtonUp(0))
        {
            stopCutting();
        }

        if (isCutting)
        {
            updateCut();
        }

    }

    private void updateCut()
    {
        rgb.position = cam.ScreenToWorldPoint(Input.mousePosition);

    }

    private void startCutting()
    {
        isCutting = true;
        currentTrail = Instantiate(bladePreFab, transform);
        col.enabled = true;

    }

    private void stopCutting()
    {
        isCutting = false;
        currentTrail.transform.SetParent(null);
        Destroy(currentTrail, 3f);
        col.enabled = false;

    }
}
