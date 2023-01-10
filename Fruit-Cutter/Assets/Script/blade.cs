using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blade : MonoBehaviour
{
    [SerializeField] private GameObject bladePreFab;
    [SerializeField] private float miniCutVel = .001f;



    bool isCutting = false;
    Vector2 prePosition;



    Rigidbody2D rgb;
    Camera cam;
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
        Vector2 newPosition = cam.ScreenToWorldPoint(Input.mousePosition);

        rgb.position = newPosition;
        float veclocity = (newPosition - prePosition).magnitude * Time.deltaTime;
        if (veclocity > miniCutVel)
        {
            col.enabled = true;

        }
        else
        {
            col.enabled = false;
        }

        prePosition = newPosition;

    }

    private void startCutting()
    {
        isCutting = true;
        currentTrail = Instantiate(bladePreFab, transform);
        prePosition = cam.ScreenToWorldPoint(Input.mousePosition);
        col.enabled = false;

    }

    private void stopCutting()
    {
        isCutting = false;
        currentTrail.transform.SetParent(null);
        Destroy(currentTrail, 3f);
        col.enabled = false;

    }
}
