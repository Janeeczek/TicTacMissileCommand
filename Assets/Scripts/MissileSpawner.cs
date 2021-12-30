using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

public class MissileSpawner : MonoBehaviour
{
    
    
    public Rigidbody2D missile;
    public float speed = 8;
    public float cooldown = 3;
    private bool _canFire = true;
    private void Update()
    {
        if(_canFire)
            StartCoroutine(SpawnMissile(cooldown));
            
    }

    private IEnumerator SpawnMissile(float coold)
    {
        _canFire = false;
        var position = new Vector2(Random.Range(-10.0f, 10.0f), 5);
        var rotation = Quaternion.Euler(0, 0, Random.Range(-45.0f, 45.0f));
        
        var missileInstance = Instantiate(missile, position, rotation);
        var direction = missileInstance.transform.rotation * Vector3.down;
        
        missileInstance.velocity = direction * speed;

        yield return new WaitForSeconds(coold);
        UpdateDifficulty();
        _canFire = true;

    }

    private void UpdateDifficulty()
    {
        if (cooldown > 1) cooldown -= 0.1f;

    }

}
