using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
[RequireComponent(typeof(Destroyer))]
[RequireComponent(typeof(TimedDestroy))]
public class Wanderer : MonoBehaviour
{
    public float wanderRadius = 10f; // 徘徊する範囲の半径
    public float wanderTimer = 5f; // 新しい目的地を設定する時間間隔

    private Transform target; // 目的地
    private NavMeshAgent agent; // NavMeshAgentコンポーネント
    private float timer; // 時間を計るためのタイマー

    // Start is called before the first frame update
    void OnEnable()
    {
        agent = GetComponent<NavMeshAgent>();
        timer = wanderTimer; // タイマーを初期化
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= wanderTimer)
        {
            Vector3 newPos = RandomNavSphere(transform.position, wanderRadius, -1);
            agent.SetDestination(newPos);
            timer = 0;
        }
    }

    // 現在の位置からランダムな目的地を生成するメソッド
    public static Vector3 RandomNavSphere(Vector3 origin, float dist, int layermask)
    {
        Vector3 randDirection = Random.insideUnitSphere * dist;

        randDirection += origin;

        NavMeshHit navHit;

        NavMesh.SamplePosition(randDirection, out navHit, dist, layermask);

        return navHit.position;
    }
}