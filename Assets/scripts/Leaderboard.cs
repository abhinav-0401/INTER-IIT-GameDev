using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Dan.Main;

public class Leaderboard : MonoBehaviour
{
    [SerializeField]
    private List<TextMeshProUGUI> names;
    [SerializeField]
    private List<TextMeshProUGUI> scores;
    private string publicLeaderboardKey="4bc11f00d71dc41e787c2351dca77f358a7de85558c8cd297b2f8b517b3f3c3f";

    public void GetLeaderboard()
    {
        LeaderboardCreator.GetLeaderboard(publicLeaderboardKey, ((msg)=>{
            int Looplength = (msg.Length<names.Count)?msg.Length:names.Count;
            for(int i=0;i<Looplength;i++)
            {
                names[i].text=msg[i].Username;
                scores[i].text=msg[i].Score.ToString();                
            }
        }));
    }
    public void SetLeaderboardEntry(string username, int score){
        LeaderboardCreator.UploadNewEntry(publicLeaderboardKey,username,score,((msg)=>{
             GetLeaderboard();
        }));
    }

    // Start is called before the first frame update
    void Start()
    {
        GetLeaderboard();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
