using Unity.VisualScripting;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public Vector3 PlayerPos;
    public Vector3 enemyDir;

    public float playerDotEnemyDir;

    public GameObject ChildCube;
    public GameObject Enemy;

    private void Start()
    {
        PlayerPos = transform.position;

        ChildCube.transform.position = PlayerPos + transform.forward;
    }
    void Update()
    {
        if(Input.GetKey(KeyCode.W))
        {
            PlayerPos.z += 3 * Time.deltaTime;
        }
        else if(Input.GetKey(KeyCode.S))
        {
            PlayerPos.z -= 3 * Time.deltaTime;
        }

        transform.position = PlayerPos;
        enemyDir = (Enemy.transform.position - transform.position).normalized;
        playerDotEnemyDir = Vector3.Dot(transform.forward, enemyDir.normalized);
    }
}
