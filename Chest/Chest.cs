using UnityEngine;

public class Chest : Interactable
{
    protected override void OnInteract()
    {
        // DO Some Animation
        print("You Opened The Chest!");
    }
}