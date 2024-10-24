using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestManager : MonoBehaviour
{
    private static QuestManager instance;

    [SerializeField] private List<QuestDataSO> questList = new List<QuestDataSO>();

    public static QuestManager Instance

    {
        get
        {
            return instance;
        }
        
        set
        {
            instance = value;
        }
    }

    private void Awake()
    {
        Instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            PrintQuestList();
        }
    }

    public void PrintQuestList()
    {
        for (int i = 0; i < questList.Count; i++)
        {
            string questString =
                $"Quest {i + 1} - {questList[i].QusetName} (최소 레벨 {questList[i].QusetRequiredLevel})";

            if (questList[i] is MonsterQuestDataSO)
            {
                MonsterQuestDataSO mon = (MonsterQuestDataSO)questList[i];
                questString += $"\n 안혜린 매니저님의 꾸준과제 를 {mon.requireMonsterKillCount} 마리 소탕";
            }
            else if (questList[i] is EncounterQuestDataSO)
            {
                EncounterQuestDataSO en = (EncounterQuestDataSO)questList[i];
                questString += $"\n 한효승 매니저님과 대화하기";
            }

            Debug.Log(questString);
        }
    }
}
