using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{   
    [SerializeField] Color32 hasPackageColor = new Color32 (1,1,1,1);
    [SerializeField] Color32 NoPackageColor = new Color32 (1,1,1,1);

    [SerializeField] float destroyDelay = 0.001f;
    bool hasPackage;
    
    SpriteRenderer spriteRenderer;
   
   private void Start() {
        spriteRenderer = GetComponent<SpriteRenderer>(); // Way to add SpriteRenderer
   }
    private void OnCollisionEnter2D(Collision2D other) {
        Debug.Log("Ouch !");
    }
    void OnTriggerEnter2D(Collider2D other){
        if (other.tag == "Package" && !hasPackage)
        {
            Debug.Log("Package Received");  
            hasPackage = true;
            spriteRenderer.color = hasPackageColor;
            Destroy(other.gameObject,0.001f);
        }
         if (other.tag == "Customer" && hasPackage)
        {
            Debug.Log("Package Delivered");  
            hasPackage = false;
            spriteRenderer.color = NoPackageColor;

        }
    }
}
