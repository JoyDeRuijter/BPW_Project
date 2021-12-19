using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestManager2 : MonoBehaviour
{
    /*public Quest quest = new Quest();
    public GameObject questPrintBox, buttonPrefab, victoryPopup, player;

    QuestEvent final;

    public GameObject A, B, C, D, E;

    void Start()
    {
        //create each event
        QuestEvent a = quest.AddQuestEvent("Lower your weapon!", "Press 'Q' to holster your weapon", A);
        QuestEvent b = quest.AddQuestEvent("Switch it up", "Use your scrollwheel to switch weapons", B);
        QuestEvent c = quest.AddQuestEvent("Release your anger", "Find and shoot a target dummy", C);
        QuestEvent d = quest.AddQuestEvent("Keep those bullets coming", "Reload manually by pressing 'R'", D);
        QuestEvent e = quest.AddQuestEvent("Patch up", "Find and walk through a health boost", E);

        //define the paths between the events - e.g. the order they must be completed
        quest.AddPath(a.GetId(), b.GetId());
        quest.AddPath(a.GetId(), c.GetId());
        quest.AddPath(b.GetId(), c.GetId());
        quest.AddPath(c.GetId(), d.GetId());
        quest.AddPath(d.GetId(), e.GetId());

        quest.BFS(a.GetId());

        QuestButton button = CreateButton(a).GetComponent<QuestButton>();
        A.GetComponent<QuestKeyInput>().Setup(this, a, button);
        button = CreateButton(b).GetComponent<QuestButton>();
        B.GetComponent<QuestKeyInput>().Setup(this, b, button);
        button = CreateButton(c).GetComponent<QuestButton>();
        C.GetComponent<QuestKill>().Setup(this, c, button);
        button = CreateButton(d).GetComponent<QuestButton>();
        D.GetComponent<QuestKeyInput>().Setup(this, d, button);
        button = CreateButton(e).GetComponent<QuestButton>();
        E.GetComponent<QuestPickup>().Setup(this, e, button);

        final = e;
    }

    GameObject CreateButton(QuestEvent e)
    {
        GameObject b = Instantiate(buttonPrefab);
        b.GetComponent<QuestButton>().Setup(e, questPrintBox);
        if (e.order == 1)
        {
            b.GetComponent<QuestButton>().UpdateButton(QuestEvent.EventStatus.CURRENT);
            e.status = QuestEvent.EventStatus.CURRENT;
        }
        return b;
    }

    public void UpdateQuestOnCompletion(QuestEvent e)
    {
        if (e == final)
        {
            StartCoroutine(DisplayVictoryPopup(3));
            player.GetComponent<Player>().currentMoney += 500;
            player.GetComponent<Player>().currentXp += 100;
            return;
        }

        foreach (QuestEvent n in quest.questEvents)
        {
            //if this event is next in order
            if (n.order == (e.order + 1))
            {
                //make the next in line available for completion
                n.UpdateQuestEvent(QuestEvent.EventStatus.CURRENT);
            }
        }
    }

    private IEnumerator DisplayVictoryPopup(float seconds)
    {
        victoryPopup.SetActive(true);
        yield return new WaitForSeconds(seconds);
        victoryPopup.SetActive(false);
    }
    */
}