using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text Username_a;
    // Start is called before the first frame update
    void Start()
    {
        Username_a.text = "Username : "+ MainManager.Instance.Username;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
