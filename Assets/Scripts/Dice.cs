using System.Collections;
using UnityEngine;

public class Dice : MonoBehaviour {

    private Sprite[] diceSides;
    private SpriteRenderer rend;
    private int whosTurn = 1;
    private bool coroutineAllowed = true;
    [SerializeField] private GameObject GC;
    private GameControl _gameControl;
    private void Start () {

        rend = GetComponent<SpriteRenderer>();
        diceSides = Resources.LoadAll<Sprite>("DiceSides/");
        rend.sprite = diceSides[5];
        _gameControl = GC.GetComponent<GameControl>();
    }
	
    private void OnMouseDown()
    {
        if(!_gameControl.gameOver && coroutineAllowed)
        StartCoroutine("RollTheDice");
    }

    private IEnumerator RollTheDice()
    {
        coroutineAllowed = false;
        int randomDiceSide = 0;
        int finalSide = 0;
        for (int i = 0; i <= 20; i++)
        {
            randomDiceSide = Random.Range(0, 6);
            rend.sprite = diceSides[randomDiceSide];
            yield return new WaitForSeconds(0.05f);
        }
        finalSide = randomDiceSide + 1;
        Debug.Log(finalSide);

        _gameControl.diceSideThrown = randomDiceSide + 1;
        if (whosTurn == 1)
        {
            _gameControl.MovePlayer(1);
        } else if (whosTurn == -1)
        {
            _gameControl.MovePlayer(2);
        }
        whosTurn *= -1;
        coroutineAllowed = true;
    }
}