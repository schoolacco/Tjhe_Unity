using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class CheckPoint : MonoBehaviour
{
    #region Public Variables

    /// <summary>
    /// Indicate if the checkpoint is activated
    /// </summary>
    public bool Activated = false;


    #endregion

    #region Static Variables

    /// <summary>
    /// List with all checkpoints objects in the scene
    /// </summary>
    public static List<GameObject> CheckPointsList;
    public BoxCollider2D Collider;
    #endregion

    #region Static Functions
    
    /// <summary>
    /// Get position of the last activated checkpoint
    /// </summary>
    /// <returns></returns>
    public static Vector3 GetActiveCheckPointPosition()
    {
        Vector3 result = Vector3.zero; // Default position
        foreach (GameObject cp in CheckPointsList)
        {
            if (cp != null) // Check if the checkpoint is not null
            {
                CheckPoint checkpointComponent = cp.GetComponent<CheckPoint>();
                if (checkpointComponent != null && checkpointComponent.Activated)
                {
                    result = cp.transform.position;
                    break;
                }
            }
        }
        return result;
    }

    public void ResetCheckpoint()
    {
         Activated = false; // Reseting stuff
    }
    #endregion


    #region Private Functions

    /// <summary>
    /// Activate the checkpoint
    /// </summary>
    private void ActivateCheckPoint()
    {
        foreach (GameObject cp in CheckPointsList)
        {
            if (cp.GetComponent<CheckPoint>() != null) //Error prevention
             { cp.GetComponent<CheckPoint>().Activated = false;
             }
        } 

        Activated = true; 
        Debug.Log("Checkpoint activated at position: " + transform.position); // Debuging to see if the checkpoint functioned
    }

    #endregion
    void Awake()
    {
      CheckPointsList = GameObject.FindGameObjectsWithTag("CheckPoint").ToList(); // Error testing - 1
      Debug.Log("List made..?"); // Future me: THIS WORKED?
    }    
    void Start()
    {
        if (CheckPointsList == null)
        {
          CheckPointsList = GameObject.FindGameObjectsWithTag("CheckPoint").ToList();
        }  
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            ActivateCheckPoint();
        }
    }
}
