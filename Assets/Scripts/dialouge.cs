using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dialouge : MonoBehaviour
{
    [SerializeField] GameObject dialougeBox;
    public void Continue()
    {
        FindObjectOfType<PlayerMovement>().GetComponent<Rigidbody2D>().simulated = true;
        FindObjectOfType<PlayerMovement>().isDiolougeEnd = true;
        FindObjectOfType<TargetToKill>().diolougeEnd = true;
        Destroy(dialougeBox);
    }
}
