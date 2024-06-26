using UnityEditor;
using UnityEngine;

namespace  Buld.Scripts
{
    public class UiRoot:MonoBehaviour
    {

        [SerializeField] private GameObject LoadingScreen;

        private void Awake()
        {
            HideScreenLoad();   
        }

        public void ShowScreenLoad()
        {

            LoadingScreen.SetActive(true);

        }

        public void HideScreenLoad()
        {

            LoadingScreen.SetActive(false);

        }

    }
}