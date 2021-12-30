using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Controller : MonoBehaviour
{
    public float rotationSpeed = 100;
    public float projectileSpeed = 20;
    public float cooldown = 0.5f;
    public Rigidbody2D projectileObj;
    
    private bool _canFire = true;
    private bool _damaged = false;

    private void Update ()
    {
        if (Input.GetAxis("Horizontal") != 0)
        {
            var actualRotation = transform.rotation.eulerAngles.z;
            
            var rotation = -Input.GetAxis("Horizontal") * rotationSpeed * Time.deltaTime;
        
            if (actualRotation > 80.0f && actualRotation <= 180)
            {
                actualRotation = 80.0f;
                this.transform.localRotation = Quaternion.Euler(0, 0, actualRotation);
            }
            else if (actualRotation < 280 && actualRotation >= 180)
            {
                actualRotation = 280.0f;
                this.transform.localRotation = Quaternion.Euler(0, 0, actualRotation);
            }
            else
                this.transform.localRotation = Quaternion.Euler(0, 0, actualRotation+ rotation);
        }

        if (!Input.GetButtonDown("Jump")) return;
        if(!_damaged && _canFire)
            StartCoroutine(Fire(cooldown));


    }
    
    private void OnCollisionEnter2D(Collision2D col)
    {
        StartCoroutine(WaitForRepair());
        
    }
    

    private IEnumerator Fire(float coold)
    {
        _canFire = false;
        
        var projectileInstance = Instantiate(projectileObj, transform.position, transform.rotation);
        var direction = projectileInstance.transform.rotation * Vector3.up;
        
        projectileInstance.velocity = direction * projectileSpeed;
        
        yield return new WaitForSeconds(coold);
        
        _canFire = true;
    }
    
    private IEnumerator WaitForRepair()
    {
        _damaged = true;
        
        gameObject.GetComponent<MeshRenderer>().material.color = Color.yellow;
        
        yield return new WaitForSeconds(2);
        
        gameObject.GetComponent<MeshRenderer>().material.color = Color.white;
        
        _damaged = false;
    }
}
