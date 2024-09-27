using UnityEngine;

public class SpawnACopyWhenHittingAnObject : MonoBehaviour
{
    [SerializeField] private bool CanSpawn = true;
    
    [SerializeField] private GameObject PrefabToSpawn = null;
    
    private static int NumberOfCubesSpawned = 0;
    
    private void OnCollisionEnter(Collision other)
    {
        if (!other.gameObject.CompareTag("MultiplyingCube") && NumberOfCubesSpawned < 16 && CanSpawn)
        {
            Instantiate(PrefabToSpawn, transform.position + new Vector3( 0.0f, 2.0f, 0.0f), transform.rotation);
            NumberOfCubesSpawned += 1;
        }
    }
}
