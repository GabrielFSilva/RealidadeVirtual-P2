using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneManager : MonoBehaviour {

    public List<Step> steps;
    public int currentStep = 0;
	// Use this for initialization
	void Start () {
        steps = GetComponentsInChildren<Step>().ToList();
        steps[currentStep].EnableStep();
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow))
            PreviousStep();
        if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))
            NextStep();
    }

    public void PreviousStep()
    {
        if (currentStep > 0)
        {
            steps[currentStep].DisableStep();
            currentStep--;
            steps[currentStep].EnableStep();
            Debug.Log("Previous: " + currentStep);
        }
    }
    public void NextStep()
    {
        if (currentStep < steps.Count - 1)
        {
            steps[currentStep].DisableStep();
            currentStep++;
            steps[currentStep].EnableStep();
            Debug.Log("Next: " + currentStep);
        }
    }
}
