using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Controller : MonoBehaviour
{
    private Vector3 _input;
    public Rigidbody rb;
    public float _speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void FixedUpdate()
    {
        Move();
        GatherInputs();
        Look();
    }

    void GatherInputs()
    {
        _input = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));
    }

    void Move()
    {
        rb.MovePosition(transform.position + transform.forward * _speed * Time.deltaTime);
    }

    void Look()
    {
        if (_input != Vector3.zero)
        {
            var relative = (transform.position + _input) - transform.position;
            var rot = Quaternion.LookRotation(relative, Vector3.up);

            transform.rotation = rot;

            Debug.Log(_input);
        }
        
    }
}
