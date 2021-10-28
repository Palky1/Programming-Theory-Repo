using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sphere : Shape //inheritance
{
    [SerializeField] Text sphereText;

    private string m_name = "Sphere";
    public string NameOfSphere  //encapsulation
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
    private void ClickOnObject()    //abstraction
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
            if (hit.collider.CompareTag(m_name))
                DisplayText();
    }

    protected override void DisplayText()   //polymorphism
    {
        Debug.Log("Clicked on Sphere");
        if (sphereText.gameObject.activeSelf)
            sphereText.gameObject.SetActive(false);
        else
            sphereText.gameObject.SetActive(true);
    }
}
