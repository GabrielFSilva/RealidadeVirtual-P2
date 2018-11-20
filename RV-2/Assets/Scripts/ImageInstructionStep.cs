using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImageInstructionStep : Step {

    public GameObject stepContainer;

    public override void EnableStep()
    {
        stepContainer.SetActive(true);
    }

    public override void DisableStep()
    {
        stepContainer.SetActive(false);
    }
}
