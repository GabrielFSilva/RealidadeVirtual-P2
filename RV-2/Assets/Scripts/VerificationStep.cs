using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class VerificationStep : Step
{
    public GameObject stepContainer;
    public List<GameObject> stepTargets;
    public List<GameObject> stepObjects;
    public List<CollisionCheck> collisionChecks;
    public List<Renderer> stepRenderers;

    public TMP_Text correctText;
    public bool correct;

    public Material correctMaterial;
    public Material incorrectMaterial;

    public bool active = false;

    public void Update()
    {
        if (!active)
            return;

        correct = true;
        foreach(CollisionCheck col in collisionChecks)
        {
            if (!col.colliding)
            {
                correct = false;
                break;
            }
        }
        if (correct)
        {
            correctText.text = "Correct";
            foreach (Renderer ren in stepRenderers)
                ren.material = correctMaterial;
        }
        else
        {
            correctText.text = "Incorrect";
            foreach (Renderer ren in stepRenderers)
                ren.material = incorrectMaterial;
        }
    }

    public override void EnableStep()
    {
        active = true;
        stepContainer.SetActive(true);
        foreach (GameObject go in stepTargets)
            go.SetActive(true);
        foreach (GameObject go in stepObjects)
            go.SetActive(true);
    }

    public override void DisableStep()
    {
        active = false;
        stepContainer.SetActive(false);
        foreach (GameObject go in stepTargets)
            go.SetActive(false);
        foreach (GameObject go in stepObjects)
            go.SetActive(false);
    }
}
