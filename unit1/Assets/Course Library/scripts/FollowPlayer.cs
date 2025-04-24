using UnityEngine;
public class FollowPlayer : MonoBehaviour
{
        public GameObject Player;
        private Vector3 offset = new Vector3(0, 7, -11);
    void Start()
    {
        
    }


    // Update is called once per frame
    void Update()
    {
        transform.position = Player.transform.position + offset;
    }
}
