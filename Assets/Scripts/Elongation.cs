using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Elongation : MonoBehaviour
{
    // Start is called before the first frame update
    public int state;
    [SerializeField] GameObject eye_normal;
    [SerializeField] GameObject eye_def;
    [SerializeField] GameObject eye_cur;
    [SerializeField] GameObject _object;
    [SerializeField] GameObject _dest;
    [SerializeField] Slider slider;
    [SerializeField] GameObject lens;
    [SerializeField] GameObject clens;
    [SerializeField] GameObject c_lens;
    public Animator ball_ani;
    Curvature curvature;

    public int anim;
    private int _lens;


    void Start()
    {
        state = 0;
        _lens = 0;
        eye_normal.SetActive(true);
        eye_cur.SetActive(false);
        eye_def.SetActive(false);
        lens.SetActive(false);
        c_lens.SetActive(false);
    }
    private void Update()
    {
        if(state==1&_lens==0)
        {
            Vector3 pos = _object.transform.position;
            if(pos.x<16)
            {
                Vector3 _pos = _dest.transform.position;
                _pos.x = (20+(slider.value/(float)12.515))*(float)1.2048;
                _dest.transform.position = _pos;
            }
            else
            {
                Vector3 _pos = _dest.transform.position;
                _pos.x = (float)25.8145;
                _dest.transform.position = _pos;
            }
        }
    }

    // Update is called once per frame

    public void L_Button_clicked()
    {
        if (_lens == 0)
        {
            c_lens.SetActive(true);
            Vector3 _pos = _dest.transform.position;
            _pos.x = (float)25.8145;
            _dest.transform.position = _pos;
            _lens = 1;
        }
        else
        {
            _lens = 0;
            c_lens.SetActive(false);
        }

    }
    public void Cr_Button_clicked()
    {
        state = 0;
        _lens = 0;
    }


    public void E_Button_clicked() 
    {
        if(state==0)
        {          
            eye_cur.SetActive(false);
            eye_normal.SetActive(false);
            eye_def.SetActive(true);
            c_lens.SetActive(false);
            clens.SetActive(false);
            lens.SetActive(true);
            ball_ani.enabled = true;
            state = 1;
        }
        else
        {
            eye_cur.SetActive(false);
            eye_normal.SetActive(true);
            lens.SetActive(false);
            clens.SetActive(false);
            c_lens.SetActive(false);
            eye_def.SetActive(false);
            state = 0;
        }
    }
}
