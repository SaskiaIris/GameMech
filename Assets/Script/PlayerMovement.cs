using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public CharacterController2D controller;
    public Animator animator;
    public MonsterManager monstermanager;

    public float runSpeed = 40f;

    float horizontalMove = 0f;
    bool jump = false;
    bool playeractive = true;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        animator.SetFloat("Speed", Mathf.Abs(horizontalMove));

        if (Input.GetKeyDown(KeyCode.X) && playeractive == true)
        {
            playeractive = false;
        } else if(Input.GetKeyDown(KeyCode.X) && playeractive == false)
        {
            playeractive = true;
        }

        if (playeractive == true) {
            horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;
            Debug.Log(horizontalMove);

            if (Input.GetButtonDown("Jump"))
            {
                jump = true;
                animator.SetBool("IsJumping", true);
            }
        } 
    }

    public void OnLand()
    {
        animator.SetBool("IsJumping", false);
    }

    private void FixedUpdate()
    {
        if (playeractive == true)
        {
            controller.Move(horizontalMove * Time.fixedDeltaTime, false, jump);
            jump = false;
        } 
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
       if(other.gameObject.CompareTag("Enemy"))
       {
            Debug.Log("there be collision");
            Destroy(this.gameObject);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            //Time.timeScale = 0f;
       }
        if (other.gameObject.CompareTag("Housetut") && monstermanager.killed == 1 )
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        if (other.gameObject.CompareTag("GameOver"))
        {
            SceneManager.LoadScene(sceneName: "Tutorial");
            
        }
    }
}
