using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OverlapCheck : MonoBehaviour
{

    public bool MyPartnerBound;
    public Rigidbody2D myRB2D;
    public Collider2D currentCollider;
    public Collider2D myOwnCircleCollider2D;


    // Start is called before the first frame update
    void Start()
    {
        myRB2D = GetComponent<Rigidbody2D>();
        myOwnCircleCollider2D = GetComponent<Collider2D>();
    }

    void OnCollisionEnter2D(Collision2D other) 
        {
            print(other.gameObject.name);        
        }

}
