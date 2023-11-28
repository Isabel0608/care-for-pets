using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuizUI : MonoBehaviour
{
    [SerializeField] private Text question = null;
    [SerializeField] private List<OptionButton> buttonList = null; 

    public void Construc(Questions q, Action<OptionButton> callback)
    {
        question.text = q.text;
        for (int i = 0; i < buttonList.Count; i++)
        {
            buttonList[i].Construct(q.options[i], callback);
        }
    }
}
