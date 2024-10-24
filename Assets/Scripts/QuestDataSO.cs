using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "DeaultQuestDataSO", menuName = "Week2_Standard/Quest/Default", order = 0)]
public class QuestDataSO : ScriptableObject
{
    public string QusetName;
    public int QusetRequiredLevel;
    public int QuestNPC;
    public int QuestID;
    public List<int> QuestPrerequisites = new List<int>();
}
