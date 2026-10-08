using UnityEngine;
using UnityEngine.InputSystem;

public class spawnerscript : MonoBehaviour
{
    public GameObject objectToSpawn;
    public Transform spawnPoint;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            Instantiate(
                objectToSpawn,
                spawnPoint.position,
                spawnPoint.rotation
            );
        }
    }
}
