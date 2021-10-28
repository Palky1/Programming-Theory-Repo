using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cube : Shape
{
    [SerializeField] Text cubeText;

    private string m_name = "Cube";
    public string NameOfCube
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
        Debug.Log("Clicked on Cube");
        if (cubeText.gameObject.activeSelf)
            cubeText.gameObject.SetActive(false);
        else
            cubeText.gameObject.SetActive(true);
    }
}
