using UnityEngine;

public class Door1Control : MonoBehaviour
{
    Animator animator;
    public bool Door;
    
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        animator.SetBool("DoorOpen", Door);
    }

    public void Button()
    {
        if(Door == true){Door = false;}

        else{Door = true;}
    }
}
