using UnityEngine;

public class FollowBlock : MonoBehaviour
{
    public Transform block;
    public Vector3 offset;
    // Update is called once per frame
    void Update()
    {
        transform.position= block.position + offset;
    }
}
