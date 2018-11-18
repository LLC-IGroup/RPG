using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneBuilder  {
    #region Fields

    #endregion
    #region Function
    // Static
    static public void LoadScene(string sceneName, string loadScreenName = null) {
        UIBuilder.CloseAllPanel();
        if (loadScreenName != null) {
            SceneManager.LoadScene("LoadScreen");
        }
        SceneManager.LoadSceneAsync(sceneName);
    }
    // Private
    #endregion
    #region Events

    #endregion
    #region Button Events

    #endregion
    #region Structs

    #endregion
    #region Enums

    #endregion
}        