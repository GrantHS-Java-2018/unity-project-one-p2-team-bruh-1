using System.Collections;
using System.Collections.Generic;
using System.Runtime.Remoting.Messaging;
using UnityEngine;
public class Button : MonoBehaviour
{
    public bool answer;
    
    private void OnMouseDown()
    {
        answer = true;
        throw new System.NotImplementedException();
    }
    
}
