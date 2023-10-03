using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPickup : MonoBehaviour
{
    public GameObject pickup;
    public GameObject playerRightHand;
    public GameObject dropOffPoint;

    public bool IhaveSomething = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void PickUpObject()
    {
        if (IhaveSomething)
        {
            pickup.transform.parent = null;
            pickup.transform.localPosition = dropOffPoint.transform.position;
            IhaveSomething = false;
        }

        else
        {
            if (pickup != null)
            {
                pickup.transform.SetParent(playerRightHand.transform);

                pickup.transform.localPosition = new Vector3(0f, 0f, 0f);
                IhaveSomething = true;
            }
            else
            {
                Debug.Log("I can't pick up.");
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("PickableObject"))
        {
            pickup = other.gameObject;
            Debug.Log("It's pickable: " + other.gameObject.name);
        }
    }
}
