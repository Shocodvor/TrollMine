


using UnityEngine;

namespace Spawner


{

    public class BaseSpawner<T> : MonoBehaviour where T : AppleAddForce
    {




        [SerializeField] private T _prefab;
        [SerializeField] private Vector3 _spawnPoint;



        public T MainInstance ()
        {



            return Instantiate(_prefab, _spawnPoint, Quaternion.identity);
        }




    }



}

