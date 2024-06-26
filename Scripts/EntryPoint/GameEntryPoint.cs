using System;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using Object = UnityEngine.Object;



namespace Buld.Scripts
{

    public class GameEntryPoint
    {


        private static GameEntryPoint _instance;
        private Courutines _couroutins;
        private UiRoot _uiRoot; 
    
            [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]


            public static void AutoStart()

        {

            Application.targetFrameRate = 60;
            Screen.sleepTimeout = SleepTimeout.NeverSleep;

            _instance = new GameEntryPoint();
            _instance.Rungame();

        }

        private GameEntryPoint() {
        
        
            _couroutins = new GameObject(name:"[Couroutins").AddComponent<Courutines>();    
            Object.DontDestroyOnLoad(_couroutins.gameObject);


            var prefabUiRoot = Resources.Load<UiRoot>(path: "Uiroot");
            _uiRoot = Object.Instantiate(prefabUiRoot);
            Object.DontDestroyOnLoad(_uiRoot.gameObject);  

        }    

        private void Rungame()
        {

            _couroutins.StartCoroutine (routine:LoadAndStartGameplay ());


        }

      private IEnumerator LoadAndStartGameplay()
        {

            _uiRoot.ShowScreenLoad();

            yield return LoadScene (ScenesNames.BOOT);
            yield return LoadScene(ScenesNames.GAMEPLAY);


            _uiRoot.HideScreenLoad();
        
       }


        private IEnumerator LoadScene (string sceneName)
        {
          yield return SceneManager.LoadSceneAsync(sceneName);
        }
    }


}

