    using UnityEngine;

    public class Spawner : MonoBehaviour
    {
        public float Delay;
        public GameObject SpawnPrefab;
        public float RandomLowerBound = -10;
        public float RandomUpperBound = 10;

        private float timeUntilSpawn = 0;

        // Start is called before the first frame update
        void Start()
        {
            
        }

        // Update is called once per frame
        void Update()
        {
            timeUntilSpawn -= Time.deltaTime;
            if (timeUntilSpawn <= 0)
            {
                Instantiate(SpawnPrefab, new Vector3(RandomLowerBound, 0, RandomUpperBound), transform.rotation);
                timeUntilSpawn = Delay;
            }
        }
    }
