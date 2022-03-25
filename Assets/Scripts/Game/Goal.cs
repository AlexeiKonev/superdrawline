using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    public GameObject myBoy;

    public bool isBoyHere;
    private StageManager stageManager;
    private Color color;

    // Start is called before the first frame update
    void Start()
    {
        isBoyHere = false;
        stageManager = FindObjectOfType<StageManager>();
        color = this.GetComponent<MeshRenderer>().material.color;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public bool IsBoyHere()
    {
        if(isBoyHere)
        {
            return true;
        }
        return false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject == myBoy)
        {
            isBoyHere = true;
            this.GetComponent<MeshRenderer>().material.color = new Color(color.r + 0.5f, color.g + 0.5f, color.b + 0.5f);

            if (stageManager != null)
            {
                stageManager.CheckEveryBoyInGoal();
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject == myBoy)
        {
            this.GetComponent<MeshRenderer>().material.color = color;
            isBoyHere = false;
        }
    }
}
