using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPresentation : MonoBehaviour
{
    [SerializeField]
    private Vector3 tPosition = Vector3.zero;
    [SerializeField]
    private Vector3 bPosition = Vector3.zero;
    [SerializeField]
    private float rotateSpeed = 10f;
    [SerializeField]
    private float moveUpSpeed = 10f;

    private bool goesUp = true;

    // Start is called before the first frame update
    void Start()
    {
        if (bPosition == Vector3.zero)
            bPosition = transform.position;
        if (tPosition == Vector3.zero)
            tPosition = transform.position + new Vector3(transform.position.x, transform.position.y + 10, transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(bPosition, Vector3.up, rotateSpeed * Time.deltaTime);
        if (goesUp == true)
        {
            transform.Translate(moveUpSpeed * Time.deltaTime * Vector3.up, Space.World);
            if (transform.position.y > tPosition.y)
            {
                goesUp = false;
            }
        } else
        {
            transform.Translate(Vector3.up * moveUpSpeed * Time.deltaTime * -1, Space.World);
            if (transform.position.y < bPosition.y)
                goesUp = true;
        }
    }
}
