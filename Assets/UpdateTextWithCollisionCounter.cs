using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateTextWithCollisionCounter : MonoBehaviour
{ 
    private TMPro.TMP_Text myTextField = null;

    private CollisionCounter FirstCollisionCounterFound = null;
    
    private void Start()
    {
        myTextField = GetComponent<TMPro.TMP_Text>();
        FirstCollisionCounterFound = GameObject.FindGameObjectWithTag("MultiplyingCube").GetComponent<CollisionCounter>();
        //FindObjectOfType<CollisionCounter>();
    }

    private void Update()
    {
        myTextField.text = $"Globals Hits: {CollisionCounter.GlobalCollisionCounter} \nFirst Cube Hits: {FirstCollisionCounterFound.SelfCollisionCounter}";
    }
}
