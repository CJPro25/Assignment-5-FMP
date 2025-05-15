using UnityEngine;

public class Door1Control1 : MonoBehaviour
{
    Animator animator;
    public bool Door1;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        animator.SetBool("DoorOpen", Door1);
    }

    public void Button1()
    {
        if(Door1 == true){Door1 = false;}

        else{Door1 = true;}
    }
}