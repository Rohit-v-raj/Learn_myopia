using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elongation : MonoBehaviour
{
    // Start is called before the first frame update
    public int state;
    [SerializeField] GameObject eye_normal;
    [SerializeField] GameObject eye_def;
    [SerializeField] GameObject _object;
    [SerializeField] GameObject _dest;
    public Animator ball_ani;
    public Animator pine_ani;


    void Start()
    {
        state = 0;
        ball_ani.enabled = false;
        pine_ani.enabled = false;
        eye_normal.SetActive(true);
        eye_def.SetActive(false);
    }
    private void Update()
    {
        if(state==1)
        {
            Vector3 pos = _object.transform.position;
            if(pos.x<16)
            {
                Vector3 _pos = _dest.transform.position;
                _pos.x = 24;
                _dest.transform.position = _pos;
            }
            else
            {
                Vector3 _pos = _dest.transform.position;
                _pos.x = (float)25.5145;
                _dest.transform.position = _pos;
            }
        }
    }

    // Update is called once per frame
    public void E_Button_clicked() 
    {
        if(state==0)
        {
            eye_normal.SetActive(false);
            eye_def.SetActive(true);
            ball_ani.enabled = true;
            pine_ani.enabled = true;
            state = 1;
        }
        else
        {
            eye_normal.SetActive(true);
            eye_def.SetActive(false);
            state = 0;
        }
    }
}
