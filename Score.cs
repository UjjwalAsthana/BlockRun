using UnityEngine;
using UnityEngine.UI;
public class Score : MonoBehaviour
{
    public Transform block;
    public Text score;
    // Update is called once per frame
    void Update()
    {
        score.text= block.position.z.ToString("0");
    }
}
