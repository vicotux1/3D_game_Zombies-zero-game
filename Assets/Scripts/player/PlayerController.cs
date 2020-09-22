using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour{
    [Header("Movement")]
    [Range(1.0f, 10.0f)][SerializeField] float speed=2.0f;
    [SerializeField]
    string AxisHorizontal="Horizontal",AxisVertical="Vertical";
    [Header("Posición")]
    public Vector3 Posicion_inicial;
    Animator anim;
    private float MovX, MovY;
    private Rigidbody rb;
    
    private void Awake() {
        rb=GetComponent<Rigidbody>();
        anim=GetComponent<Animator>();
        Cursor.visible = false;
        transform.position=Posicion_inicial;
        }

    void FixedUpdate(){
        MovX=Input.GetAxis(AxisHorizontal);
        MovY=Input.GetAxis(AxisVertical);
        anim.SetFloat("SpeedY", MovY);
        anim.SetFloat("SpeedX", MovX);
        Debug.Log(MovX);
        Debug.Log(MovY);
        OnMove(MovX,MovY);
    }
    void OnMove(float MovY, float MovX){
        Vector3 moveVector=new Vector3(MovY,0,MovX);
        rb.velocity=moveVector*speed;
    }
    void OnTriggerEnter(Collider other){
        if (other.tag == "Enemy"){
			//Game_Manager.estancia.Lives();
			rb.velocity=Vector3.zero;
			transform.position=Posicion_inicial;
			}
		}	
}
