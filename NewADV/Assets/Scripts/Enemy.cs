using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Quest
{
    public class Enemy : MonoBehaviour
    {

        [SerializeField]private GameObject enemyPrefab;
        private GameObject enemy;
        private Vector3 enemyPosition = new Vector3(59.135f, 2.718f, 15.611f);

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            enemy = Instantiate(enemyPrefab, transform);
            enemy.transform.localPosition = enemyPosition;
        }
    }
}
