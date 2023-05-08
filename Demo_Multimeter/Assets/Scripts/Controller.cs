using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    private Outline outline;

    private GameObject manager;
    private Model model;
    // Start is called before the first frame update
    void Start()
    {
        outline = GetComponent<Outline>();
        manager = GameObject.Find("Manager");
        model = manager.GetComponent<Model>();
    }

    // Update is called once per frame
    void Update()
    {
        Scrool();
    }

    private void OnMouseEnter()
    {
        outline.enabled = true;
        
    }
    private void OnMouseExit()
    {
        outline.enabled = false;
    }
    
    void Scrool()
    {
        if (Input.GetAxis("Mouse ScrollWheel") > 0)
        {
            transform.Rotate(0,0,5);
            float Rotation = transform.rotation.eulerAngles.z;
            model.solution(Rotation);
        }
        if (Input.GetAxis("Mouse ScrollWheel") < 0)
        {
            transform.Rotate(0, 0, -5);
            float Rotation = transform.rotation.eulerAngles.z;
            model.solution(Rotation);
        }
    }
}
