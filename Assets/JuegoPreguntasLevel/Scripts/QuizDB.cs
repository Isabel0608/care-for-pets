using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuizDB : MonoBehaviour
{
    [SerializeField] List<Questions> m_QuestionList = null;

    private List<Questions> m_Backup = null;

    private void Awake()
    {
        m_Backup = m_QuestionList;
    }

    public Questions GetRandom(bool remove = true)
    {
        if(m_QuestionList.Count == 0)
            RestoreBackup();

        int index = Random.Range(0, m_QuestionList.Count);

        if (!remove)
            return m_QuestionList[index];
        Questions q = m_QuestionList[index];
        m_QuestionList.RemoveAt(index);

        return q;
        
    }

    private void RestoreBackup()
    {
        m_QuestionList = m_Backup;
    }
}
