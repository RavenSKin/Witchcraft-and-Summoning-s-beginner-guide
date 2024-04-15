using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class Controller : MonoBehaviour
{
    bool BattleMod;


    [Header("Player Movement")]
    public bool InteractWithItem;
    GameObject getCollision;
    public GameObject spriteComponent;
    public float speed;
    public AnimationCurve _speedCurve;
    private Animator _anim;
    bool Run;
    private SpriteRenderer _spriteRenderer;
    float HorizontalMovement;
    Vector3 Movement;


    void Start()
    {

        _anim = spriteComponent.GetComponent<Animator>();
        _spriteRenderer = spriteComponent.GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        Move();
        if (Input.GetKeyDown(KeyCode.Space) && InteractWithItem)
        {
           
            getCollision.GetComponent<TransmitFonctions>().InvokingEventChain();
        }


    }
    // Update is called once per frame
    void FixedUpdate()
    {
        Movement = new Vector3(HorizontalMovement * speed, 0, 0);
        transform.Translate(Movement * _speedCurve.Evaluate(Time.deltaTime));

    }


    void Move()
    {
        HorizontalMovement = Input.GetAxis("Horizontal");

        switch (HorizontalMovement)
        {
            case < 0:
                _anim.SetBool("Running", true);
                _spriteRenderer.flipX = true;
                break;
            case > 0:
                _anim.SetBool("Running", true);
                _spriteRenderer.flipX = false;
                break;
            case 0:
                _anim.SetBool("Running", false);
                break;
        }
        if (BattleMod) { _spriteRenderer.flipX = false; _anim.SetBool("Running", false); }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        InteractWithItem = true;
        getCollision = collision.gameObject;
        //if (Input.GetKeyDown()
        //{
        //    Debug.Log("Fonctionne !!!");
        //    
        //}

    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.gameObject == getCollision)
        {
            InteractWithItem = false;
            getCollision = null;
        }
    }
}
