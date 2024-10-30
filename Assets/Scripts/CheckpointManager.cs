using UnityEngine;
public class CheckpointManager : MonoBehaviour
{
    private void Awake()
    {
        ResetAllCheckpoints();
    }

    public void ResetAllCheckpoints()
    {
        // Find all GameObjects with the "CheckPoint" tag
        foreach (GameObject cp in GameObject.FindGameObjectsWithTag("CheckPoint"))
        {
            // Get the CheckPoint component and call ResetCheckpoint
            CheckPoint checkpointComponent = cp.GetComponent<CheckPoint>();
            if (checkpointComponent != null)
            {
                checkpointComponent.ResetCheckpoint(); // Call the method on the component
            }
        }
    }
}
