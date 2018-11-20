using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AssemblyStep : Step
{
    public GameObject stepContainer;
    public List<GameObject> stepTargets;
    public List<GameObject> stepObjects;

    public override void EnableStep()
    {
        stepContainer.SetActive(true);
        foreach (GameObject go in stepTargets)
            go.SetActive(true);
        foreach (GameObject go in stepObjects)
            go.SetActive(true);
    }

    public override void DisableStep()
    {
        stepContainer.SetActive(false);
        foreach (GameObject go in stepTargets)
            go.SetActive(false);
        foreach (GameObject go in stepObjects)
            go.SetActive(false);
    }
}
