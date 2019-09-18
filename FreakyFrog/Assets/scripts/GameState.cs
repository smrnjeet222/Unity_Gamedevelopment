using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class GameState : MonoBehaviour
{
    private bool GameStarted = false;

    [SerializeField]
    private Text gamestatetext;

    [SerializeField]
    private GameObject Player;

    [SerializeField]
    private GameObject Canvas;

    [SerializeField]
    private GameObject Bird;

    [SerializeField]
    private BirdMovement birdMovement;

    [SerializeField]
    private followCamera followCamera;

    public Text ScoreText;


    private ScoreCounter Score;

    public float RestartDelay = 5f;
    public float RestartTimer = 0f;

    private Animator FrogAnimator;

    private Animator BirdAnimator;

    private Frogovement frogovement;

    public FrogHealth frogHealth;

    void Start()
    {

        Cursor.visible = false;

        frogovement = Player.GetComponent<Frogovement>();
        frogHealth = Player.GetComponent<FrogHealth>();
        FrogAnimator = Player.GetComponent<Animator>();
        BirdAnimator = Bird.GetComponent<Animator>();
        Score = Canvas.GetComponent<ScoreCounter>();
        frogovement.enabled = false;

        birdMovement.enabled = false;

        followCamera.enabled = false;

    }

    public void GameStart()
    {
        if (Input.GetKeyUp(KeyCode.Space) && GameStarted == false)
        {
            gamestatetext.enabled = false;
            GameStarted = true;
        }

        if (GameStarted == true)
        {
            frogovement.enabled = true;

            birdMovement.enabled = true;

            followCamera.enabled = true;
        }
    }

    public void GameOver()
    {
        frogovement.enabled = false;

        birdMovement.enabled = false;

        followCamera.enabled = false;

        Score.Score = 0;

        Invoke("FrogErase", 0.5f);

        FrogAnimator.SetBool("IsIdle", true);
        BirdAnimator.SetBool("IDLE", true);

        ScoreText.text = "Game Over";

        Invoke("Restart", RestartDelay);

    }
    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    void FrogErase()
    {
        Player.SetActive(false);
    }

    void Update()
    {
        GameStart();
        if (frogHealth.Alive == false)
        {
            GameOver();

        }

    }
}
