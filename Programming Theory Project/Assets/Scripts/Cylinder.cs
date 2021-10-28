using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cylinder : Shape
{
    [SerializeField] Text cylinderText;

    private string m_name = "Cylinder";
    public string NameOfCylinder
    {
        get { return m_name; }
        set { m_name = value; }
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            ClickOnObject();
        }
    }
    private void ClickOnObject()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
            if (hit.collider.CompareTag(m_name))
                DisplayText();
    }

    protected override void DisplayText()
    {
        Debug.Log("Clicked on Cylinder");
        if (cylinderText.gameObject.activeSelf)
            cylinderText.gameObject.SetActive(false);
        else
            cylinderText.gameObject.SetActive(true);
    }
}
