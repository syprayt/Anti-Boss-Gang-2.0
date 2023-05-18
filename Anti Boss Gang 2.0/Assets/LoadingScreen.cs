using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoadingScreen : MonoBehaviour
{
    [SerializeField] private Slider loadingSlider;
    [SerializeField] private Text loadingText;

    private AsyncOperation loadingOperation;
    private float targetProgress = 0.5f;
    private float currentProgress = 0f;
    private bool loadingComplete = false;

    private void Start()
    {
        // Загрузка первой сцены
        loadingOperation = SceneManager.LoadSceneAsync(1);
        loadingOperation.allowSceneActivation = false;
    }

    private void Update()
    {
        // Обновление прогресса загрузки
        if (!loadingComplete)
        {
            if (currentProgress < targetProgress)
            {
                currentProgress += Time.deltaTime * 0.1f;
            }
            else
            {
                loadingComplete = true;
            }
        }
        else
        {
            currentProgress += Time.deltaTime * 0.1f;
        }

        loadingSlider.value = currentProgress;

        // Если загрузка завершена, можно переключиться на загруженную сцену
        if (currentProgress >= 1f)
        {
            loadingOperation.allowSceneActivation = true;
        }

        loadingText.text = Mathf.Round(currentProgress * 100f) + "%";
    }
}
