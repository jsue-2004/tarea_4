using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    public Animator _componentAnimation;
    // Start is called before the first frame update
    void Awake()
    {
        _componentAnimation = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void destroyself()
    {
        Destroy(this.gameObject);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "bullet")
        {
            _componentAnimation.SetBool("dead", true);
        }

    }
}
